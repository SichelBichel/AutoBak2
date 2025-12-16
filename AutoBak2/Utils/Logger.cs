using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace AutoBak2.Utils
{
    public static class Logger
    {
        private static string _currentLogFilePath = null;
        private static readonly object _lock = new object();
        public static void writeLog(string message)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoStage.log");
            string timeStampedMessage = $"[{DateTime.Now:yyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(logFilePath, timeStampedMessage + Environment.NewLine);
        }
        public static void InitializeLog(string jobName)
        {
            if (_currentLogFilePath != null) return;

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string logDirPath = Path.Combine(baseDir, "logs");

            if (!Directory.Exists(logDirPath))
            {
                Directory.CreateDirectory(logDirPath);
            }

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string logFileName = $"{jobName}_{timestamp}.log";

            _currentLogFilePath = Path.Combine(logDirPath, logFileName);

            WriteLogEntry($"--- Job '{jobName}' started at {DateTime.Now.ToString(CultureInfo.InvariantCulture)} ---");
        }

        public static void WriteLogEntry(string message)
        {
            if (_currentLogFilePath == null) return;
            string logLine = $"{DateTime.Now.ToString("HH:mm:ss.fff")} | {message}{Environment.NewLine}";

            lock (_lock)
            {
                File.AppendAllText(_currentLogFilePath, logLine);
            }
        }


    }
}
