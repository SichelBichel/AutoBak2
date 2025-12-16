using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBak2.Utils.ShellActions
{
    public static class ShellHandler
    {
        public static void path(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageHandler.DisplayErrorBox("Invalid Path", $"The specified path does not exist: {path}");
                }
            }
            catch (Exception ex)
            {
                //form.Invoke(() => form.AppendErrorText($"[ERROR] failed to open path: {ex.Message}"));
                MessageHandler.DisplayErrorBox("Error Opening Path", $"Failed to open the path: {path}\n\nError: {ex.Message}");
            }
        }
        public static void url(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                //form.Invoke(() => form.AppendErrorText($"[ERROR] failed to open URL: {ex.Message}"));
                MessageHandler.DisplayErrorBox("Error Opening URL", $"Failed to open the URL: {url}\n\nError: {ex.Message}");
            }
        }
        public static void file(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageHandler.DisplayWarningBox("File Not Found", $"The specified file does not exist: {filePath}");
                }
            }
            catch (Exception ex)
            {
                //form.Invoke(() => form.AppendErrorText($"[ERROR] failed to open file: {ex.Message}"));
                MessageHandler.DisplayErrorBox("Error Opening File", $"Failed to open the file: {filePath}\n\nError: {ex.Message}");
            }
        }
    }
}
