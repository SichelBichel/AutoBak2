// Dateiname: JobExecutor.cs
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using AutoBak2.ConfigStructs;
using AutoBak2.Utils;

namespace AutoBak2.Utils
{

    public static class JobExecutor
    {
        public static void ExecuteJob(JobConfig config, IProgress<JobProgressData> progress, CancellationToken ct)
        {
            //MessageHandler.DisplayInfoBox("Job Start", $"Starting job: {config.Name}");

            if (!Directory.Exists(config.SourcePath))
            {
                MessageHandler.DisplayErrorBox("Error", $"Source directory not found: {config.SourcePath}");
                return;
            }

                string finalTargetPath = DetermineFinalTargetPath(config);

                if (config.ArchiveEnabled)
                {
                    CreateArchiveJob(config, finalTargetPath, progress, ct); // ADD PROGRESS LATER ON
                }
                else
                {
                    //cloud
                    if (config.CloudMode)
                        {
                            CopyDirectoryCloudParallel(config, finalTargetPath, progress, ct);
                        }
                    else
                    //Default (not cloud)
                        {
                            CopyDirectoryJob(config, finalTargetPath, progress, ct);
                        }
                }

            if (!ct.IsCancellationRequested)
            {
                MessageHandler.DisplayInfoBox("Job Success", $"Job '{config.Name}' completed successfully!");
            }
        }

        private static string DetermineFinalTargetPath(JobConfig config)
        {
            string baseTarget = config.TargetPath;
            string targetDirectoryName = string.Empty;

            if (!config.CreateSubdirectory)
            {
                return baseTarget;
            }

            if (config.UseSourcedirectoryName)
            {
                targetDirectoryName = Path.GetFileName(config.SourcePath.TrimEnd(Path.DirectorySeparatorChar));
            }
            else
            {
                targetDirectoryName = config.SubdirectoryName;
            }

            if (string.IsNullOrWhiteSpace(targetDirectoryName))
            {
                targetDirectoryName = config.Name;
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");

            string finalSubdirectoryName = $"{timestamp}__{targetDirectoryName}";

            string finalTargetPath = Path.Combine(baseTarget, finalSubdirectoryName);

            return finalTargetPath;
        }


        private static void CopyDirectoryJob(JobConfig config, string finalTargetPath, IProgress<JobProgressData> progress, CancellationToken ct)
        {
            Directory.CreateDirectory(finalTargetPath);

            // Erst Dateien zählen für korrekten Progress
            int totalFiles = CountFiles(config.SourcePath, config.ExcludedItems);
            int currentFileCount = 0;

            CopyDirectoryRecursive(config.SourcePath, finalTargetPath, config.ExcludedItems, ref currentFileCount, totalFiles, ct, progress);
        }


        private static void CopyDirectoryCloudParallel(JobConfig config, string finalTargetPath, IProgress<JobProgressData> progress, CancellationToken ct)
        {
            Directory.CreateDirectory(finalTargetPath);
            int currentFileCount = 0;

            // EnumerateFiles ist der Schlüssel: Es liefert die erste Datei SOFORT.
            // SearchOption.AllDirectories ersetzt die manuelle Rekursion für den flachen Parallel-Ansatz.
            var allFiles = Directory.EnumerateFiles(config.SourcePath, "*", SearchOption.AllDirectories);

            Parallel.ForEach(allFiles, new ParallelOptions { MaxDegreeOfParallelism = 10, CancellationToken = ct }, filePath =>
            {
                // Deine vorhandene Exclusion-Logik (muss evtl. kurz als Helper greifbar sein)
                if (IsManualExcluded(filePath, config.ExcludedItems)) return;

                string relativePath = Path.GetRelativePath(config.SourcePath, filePath);
                string targetFilePath = Path.Combine(finalTargetPath, relativePath);

                // Verzeichnis am Ziel erstellen (Thread-safe)
                string targetDir = Path.GetDirectoryName(targetFilePath);
                if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);

                // Kopieren - hier wird die Latenz durch Parallelität "versteckt"
                File.Copy(filePath, targetFilePath, true);

                // Progress melden
                Interlocked.Increment(ref currentFileCount);
                progress?.Report(new JobProgressData
                {
                    ProgressPercentage = 0, // Wir verzichten auf CountFiles, daher keine %
                    CurrentFile = Path.GetFileName(filePath),
                    IsComplete = false
                });
            });
        }

        // Kleiner Helper, der genau das tut, was deine Func bisher in der Rekursion gemacht hat
        private static bool IsManualExcluded(string path, List<string> exclusions)
        {
            string normalizedPath = path.TrimEnd(Path.DirectorySeparatorChar);
            return exclusions.Any(e => normalizedPath.StartsWith(e.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase));
        }


        private static void CopyDirectoryRecursive(
     string sourceDir,
     string targetDir,
     List<string> exclusions,
     ref int currentFileCount,
     int totalFileCount,
             CancellationToken ct,
     IProgress<JobProgressData> progress = null)
        {
            string normalizedSourceDir = sourceDir.TrimEnd(Path.DirectorySeparatorChar);
            string normalizedTargetDir = targetDir.TrimEnd(Path.DirectorySeparatorChar);


            Func<string, bool> isExcluded = (path) =>
            {
                string normalizedPath = path.TrimEnd(Path.DirectorySeparatorChar);
                return exclusions.Any(e => normalizedPath.StartsWith(e.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase));
            };

            if (!Directory.Exists(normalizedTargetDir))
            {
                Directory.CreateDirectory(normalizedTargetDir);
            }

            int lastReportedPercentage = -1;

            try
            {
                foreach (string filePath in Directory.GetFiles(normalizedSourceDir))
                {
                    if (!isExcluded(filePath))
                    {
                        ct.ThrowIfCancellationRequested();
                        string fileName = Path.GetFileName(filePath);
                        string targetFilePath = Path.Combine(normalizedTargetDir, fileName);

                        File.Copy(filePath, targetFilePath, true);

                        // Progress-Update
                        currentFileCount++;
                        if (progress != null && totalFileCount > 0)
                        {

                            int percentage = (int)((currentFileCount / (double)totalFileCount) * 100);
                            
                            if (percentage > lastReportedPercentage)
                                {
                                lastReportedPercentage = percentage;
                                progress.Report(new JobProgressData
                                {
                                    ProgressPercentage = Math.Min(percentage, 100),
                                    CurrentFile = fileName,
                                    IsComplete = false
                                });
                            }  
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageHandler.DisplayWarningBox("Permission Denied", $"Cannot access or copy file(s) in {normalizedSourceDir}: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("File Error", $"An error occurred during file copy in {normalizedSourceDir}: {ex.Message}");
            }

            try
            {
                foreach (string subDirPath in Directory.GetDirectories(normalizedSourceDir))
                {
                    if (!isExcluded(subDirPath))
                    {
                        ct.ThrowIfCancellationRequested();

                        string dirName = Path.GetFileName(subDirPath);
                        string targetSubDir = Path.Combine(normalizedTargetDir, dirName);

                        CopyDirectoryRecursive(subDirPath, targetSubDir, exclusions, ref currentFileCount, totalFileCount, ct, progress);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageHandler.DisplayWarningBox("Permission Denied", $"Cannot access subdirectory information in {normalizedSourceDir}: {ex.Message}");
            }
            catch (Exception ex)
            {
                // OUT BECAUSE OF ABORD MSG MessageHandler.DisplayErrorBox("Directory Error", $"An error occurred during directory traversal in {normalizedSourceDir}: {ex.Message}");
            }
        }



        private static int CountFiles(string directory, List<string> exclusions)
        {
            int count = 0;

            Func<string, bool> isExcluded = (path) =>
            {
                string normalizedPath = path.TrimEnd(Path.DirectorySeparatorChar);
                return exclusions.Any(e => normalizedPath.StartsWith(e.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase));
            };

            try
            {
                foreach (string file in Directory.GetFiles(directory))
                {
                    if (!isExcluded(file)) count++;
                }

                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    if (!isExcluded(subDir))
                    {
                        count += CountFiles(subDir, exclusions);
                    }
                }
            }
            catch { }

            return count;
        }


        //##################################################################
        //# ADD INSTANCED PROGRESS FORM HERE
        //##################################################################

        private static void CreateArchiveJob(JobConfig config, string finalTargetPath, IProgress<JobProgressData> progress, CancellationToken ct)
        {
            if (config.ArchiveType != JobConfig.ArchiveFormat.Zip)
            {
                MessageHandler.DisplayErrorBox("Error", $"Archive format '{config.ArchiveType}' not supported yet.");
                return;
            }

            string archiveExtension = GetArchiveExtension(config.ArchiveType);
            string baseName = Path.GetFileName(config.SourcePath.TrimEnd(Path.DirectorySeparatorChar));
            string archiveFileName = baseName + archiveExtension;

            // Ziel-Ordner (auf Drive) sicherstellen
            Directory.CreateDirectory(finalTargetPath);
            string remoteArchivePath = Path.Combine(finalTargetPath, archiveFileName);

            // WEICHE: Lokal zippen wenn CloudMode, sonst direkt (dein alter Weg)
            string localTempPath = config.CloudMode
                ? Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".zip")
                : remoteArchivePath;

            try
            {
                int totalFiles = config.CloudMode ? 0 : CountFiles(config.SourcePath, config.ExcludedItems);
                int currentFileCount = 0;

                if (File.Exists(localTempPath)) File.Delete(localTempPath);

                using (FileStream zipStream = new FileStream(localTempPath, FileMode.Create))
                using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                {
                    AddFilesToZipRecursive(
                        config.SourcePath,
                        archive,
                        config.ExcludedItems,
                        config.SourcePath,
                        ref currentFileCount,
                        totalFiles,
                        ct,
                        progress
                    );
                }

                // Wenn wir im CloudMode lokal gearbeitet haben, jetzt hochladen
                if (config.CloudMode)
                {
                    progress?.Report(new JobProgressData { CurrentFile = "Uploading ZIP to Cloud...", ProgressPercentage = 100 });

                    if (File.Exists(remoteArchivePath)) File.Delete(remoteArchivePath);
                    File.Move(localTempPath, remoteArchivePath);
                }
            }
            catch (Exception ex)
            {
                if (config.CloudMode && File.Exists(localTempPath)) File.Delete(localTempPath);
                MessageHandler.DisplayErrorBox("Archive Failed", $"Failed to create ZIP: {ex.Message}");
            }
        }

        private static void AddFilesToZipRecursive(
            string sourcePath,
            ZipArchive archive,
            List<string> exclusions,
            string rootPath,
            ref int currentFileCount,           // NEU
            int totalFileCount,
            CancellationToken ct,
            IProgress<JobProgressData> progress = null)  // NEU
        {
            string normalizedSourcePath = sourcePath.TrimEnd(Path.DirectorySeparatorChar);

            Func<string, bool> isExcluded = (path) =>
            {
                string normalizedPath = path.TrimEnd(Path.DirectorySeparatorChar);
                return exclusions.Any(e => normalizedPath.StartsWith(e.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase));
            };

            try
            {
                foreach (string filePath in Directory.GetFiles(normalizedSourcePath))
                {
                    if (!isExcluded(filePath))
                    {

                        ct.ThrowIfCancellationRequested();

                        string entryName = filePath.Substring(rootPath.Length).TrimStart(Path.DirectorySeparatorChar);
                        string fileName = Path.GetFileName(filePath);

                        archive.CreateEntryFromFile(filePath, entryName, CompressionLevel.Fastest);

                        // Progress-Update
                        currentFileCount++;
                        if (progress != null && totalFileCount > 0)
                        {
                            int percentage = (int)((currentFileCount / (double)totalFileCount) * 100);
                            progress.Report(new JobProgressData
                            {
                                ProgressPercentage = Math.Min(percentage, 100),
                                CurrentFile = fileName,
                                IsComplete = false
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding files in {normalizedSourcePath}: {ex.Message}");
            }

            try
            {
                foreach (string subDirPath in Directory.GetDirectories(normalizedSourcePath))
                {
                    if (!isExcluded(subDirPath))
                    {
                        ct.ThrowIfCancellationRequested();
                        AddFilesToZipRecursive(subDirPath, archive, exclusions, rootPath, ref currentFileCount, totalFileCount, ct, progress);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error traversing directories in {normalizedSourcePath}: {ex.Message}");
            }
        }
        private static string GetArchiveExtension(JobConfig.ArchiveFormat format)
        {
            return format switch
            {
                JobConfig.ArchiveFormat.Zip => ".zip",
                JobConfig.ArchiveFormat.Rar => ".rar",
                JobConfig.ArchiveFormat.SevenZip => ".7z",
                JobConfig.ArchiveFormat.Gzip => ".tar.gz",
                _ => string.Empty,
            };
        }
    }
}