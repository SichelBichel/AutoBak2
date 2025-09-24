using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBak2.Utils
{
    public static class Logger
    {
        public static void writeLog(string message)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoStage.log");
            string timeStampedMessage = $"[{DateTime.Now:yyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(logFilePath, timeStampedMessage + Environment.NewLine);
        }
    }
}
