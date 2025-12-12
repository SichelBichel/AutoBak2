using AutoBak2.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public static class JobConfigurationManager
{
    private const string DataDirectoryName = "data";
    private const string JobsDirectoryName = "jobs";

    private const string FileExtension = ".xml";

    private static string GetJobsDirectoryPath()
    {
        string exeRoot = AppDomain.CurrentDomain.BaseDirectory;

        return Path.Combine(exeRoot, DataDirectoryName, JobsDirectoryName);
    }

    private static string GetJobFilePath(string jobName)
    {
        string safeJobName = SanitizeFileName(jobName);
        string jobsDir = GetJobsDirectoryPath();

        return Path.Combine(jobsDir, safeJobName + FileExtension);
    }

    private static string SanitizeFileName(string input)
    {
        string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
        foreach (char c in invalidChars)
        {
            input = input.Replace(c, '_');
        }
        return input;
    }

    /// <summary>
    /// Speichert eine JobConfig-Instanz in einer separaten XML-Datei.
    /// Der Dateiname basiert auf dem JobNamen.
    /// </summary>
    /// <param name="config">Die zu speichernde Job-Konfiguration.</param>
    public static void SaveJob(JobConfig config)
    {
        if (string.IsNullOrWhiteSpace(config.Name))
        {
            throw new ArgumentException("Name Can't be empty");
            MessageHandler.DisplayWarningBox("Caution", "Name cant be empty");
        }

        string jobsDir = GetJobsDirectoryPath();
        Directory.CreateDirectory(jobsDir);

        string filePath = GetJobFilePath(config.Name);

        XmlSerializer serializer = new XmlSerializer(typeof(JobConfig));

        using (TextWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, config);
        }

        MessageHandler.DisplayInfoBox("Success", $"Configuration for {config.Name} saved successfully to {filePath}");
    }

    /// <summary>
    /// Lädt eine JobConfig-Instanz aus einer XML-Datei.
    /// </summary>
    /// <param name="jobName">Der Name des zu ladenden Jobs (entspricht dem Dateinamen).</param>
    /// <returns>Die geladene JobConfig-Instanz.</returns>
    public static JobConfig LoadJob(string jobName)
    {
        string filePath = GetJobFilePath(jobName);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File not found: {filePath}");
        }

        // deserialize
        XmlSerializer serializer = new XmlSerializer(typeof(JobConfig));
        JobConfig config;

        using (TextReader reader = new StreamReader(filePath))
        {
            config = (JobConfig)serializer.Deserialize(reader);
        }

        return config;
    }


    public static List<string> ListAvailableJobs()
    {
        string jobsDir = GetJobsDirectoryPath();
        if (!Directory.Exists(jobsDir))
        {
            return new List<string>();
        }

        List<string> jobNames = new List<string>();
        string[] files = Directory.GetFiles(jobsDir, $"*{FileExtension}");

        foreach (string file in files)
        {
            // Dateiname ohne Pfad und ohne Erweiterung
            string jobName = Path.GetFileNameWithoutExtension(file);
            jobNames.Add(jobName);
        }

        return jobNames;
    }
}