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
        public static void ExecuteJob(JobConfig config, IProgress<JobProgressData> progress)
        {
            MessageHandler.DisplayInfoBox("Job Start", $"Starting job: {config.Name}");

            if (!Directory.Exists(config.SourcePath))
            {
                MessageHandler.DisplayErrorBox("Error", $"Source directory not found: {config.SourcePath}");
                return;
            }

            try
            {
                string finalTargetPath = DetermineFinalTargetPath(config);

                if (config.ArchiveEnabled)
                {
                    CreateArchiveJob(config, finalTargetPath);
                }
                else
                {
                    CopyDirectoryJob(config, finalTargetPath);
                }

                MessageHandler.DisplayInfoBox("Job Success", $"Job '{config.Name}' completed successfully!");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Job Failed", $"Job '{config.Name}' failed: {ex.Message}");
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

            string timestamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm");

            string finalSubdirectoryName = $"{timestamp}___{targetDirectoryName}";

            string finalTargetPath = Path.Combine(baseTarget, finalSubdirectoryName);

            return finalTargetPath;
        }


        // -------------------------------------------------------------
        // Hilfsmethode 2: Direkte Verzeichnis-Kopie (ohne Archivierung)
        // -------------------------------------------------------------
        private static void CopyDirectoryJob(JobConfig config, string finalTargetPath)
        {
            Directory.CreateDirectory(finalTargetPath);

            CopyDirectoryRecursive(config.SourcePath, finalTargetPath, config.ExcludedItems);
        }

        private static void CopyDirectoryRecursive(string sourceDir, string targetDir, List<string> exclusions)
        {
            string normalizedSourceDir = sourceDir.TrimEnd(Path.DirectorySeparatorChar);
            string normalizedTargetDir = targetDir.TrimEnd(Path.DirectorySeparatorChar);

            // exclusion testfunct
            Func<string, bool> isExcluded = (path) =>
            {
                string normalizedPath = path.TrimEnd(Path.DirectorySeparatorChar);
            
                return exclusions.Any(e => normalizedPath.StartsWith(e.TrimEnd(Path.DirectorySeparatorChar), StringComparison.OrdinalIgnoreCase));
            };

            if (!Directory.Exists(normalizedTargetDir))
            {
                Directory.CreateDirectory(normalizedTargetDir);
            }

            //copy data
            try
            {
                foreach (string filePath in Directory.GetFiles(normalizedSourceDir))
                {
                    if (!isExcluded(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string targetFilePath = Path.Combine(normalizedTargetDir, fileName);

                        File.Copy(filePath, targetFilePath, true);
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
                        string dirName = Path.GetFileName(subDirPath);
                        string targetSubDir = Path.Combine(normalizedTargetDir, dirName);

                        CopyDirectoryRecursive(subDirPath, targetSubDir, exclusions);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageHandler.DisplayWarningBox("Permission Denied", $"Cannot access subdirectory information in {normalizedSourceDir}: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Directory Error", $"An error occurred during directory traversal in {normalizedSourceDir}: {ex.Message}");
            }
        }





        //##################################################################
        //# ADD INSTANCED PROGRESS FORM HERE
        //##################################################################

        private static void CreateArchiveJob(JobConfig config, string finalTargetPath)
        {
            if (config.ArchiveType != JobConfig.ArchiveFormat.Zip)
            {
                MessageHandler.DisplayErrorBox("Error", $"Archive format '{config.ArchiveType}' not supported yet (only filtered Zip is built-in).");
                return;
            }

            string archiveExtension = GetArchiveExtension(config.ArchiveType);
            string baseName = Path.GetFileName(config.SourcePath.TrimEnd(Path.DirectorySeparatorChar));
            string archiveFileName = baseName + archiveExtension;

            Directory.CreateDirectory(finalTargetPath);

            string fullArchivePath = Path.Combine(finalTargetPath, archiveFileName);

            if (File.Exists(fullArchivePath))
            {
                File.Delete(fullArchivePath);
            }

            try
            {
                using (FileStream zipStream = new FileStream(fullArchivePath, FileMode.Create))
                using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                {
                    AddFilesToZipRecursive(
                        sourcePath: config.SourcePath,
                        archive: archive,
                        exclusions: config.ExcludedItems,
                        rootPath: config.SourcePath
                    );
                }

                MessageHandler.DisplayInfoBox("Archive Success",
                    $"Filtered ZIP archive created successfully at: {fullArchivePath}.");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Archive Failed",
                    $"Failed to create filtered ZIP archive: {ex.Message}");
            }
        }

        private static void AddFilesToZipRecursive(string sourcePath, ZipArchive archive, List<string> exclusions, string rootPath)
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
                        string entryName = filePath.Substring(rootPath.Length).TrimStart(Path.DirectorySeparatorChar);

                        archive.CreateEntryFromFile(filePath, entryName, CompressionLevel.Fastest);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding files in {normalizedSourcePath}: {ex.Message}");
            }


            // 2. Unterverzeichnisse rekursiv verarbeiten
            try
            {
                foreach (string subDirPath in Directory.GetDirectories(normalizedSourcePath))
                {
                    if (!isExcluded(subDirPath))
                    {
                        AddFilesToZipRecursive(subDirPath, archive, exclusions, rootPath);
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