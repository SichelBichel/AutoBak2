using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoBak2.ConfigStructs;
using AutoBak2.Utils;

namespace AutoBak2.Forms
{
    public partial class SingleExecForm : Form
    {
        public SingleExecForm()
        {
            InitializeComponent();
            LoadJobSelectionComboBox();
        }

        public void LoadJobSelectionComboBox()
        {
            try
            {
                comboBoxJobSelection.Items.Clear();

                List<string> availableJobs = JobConfigurationManager.ListAvailableJobs();

                if (availableJobs.Count > 0)
                {
                    foreach (string jobName in availableJobs)
                    {
                        comboBoxJobSelection.Items.Add(jobName);
                    }
                    comboBoxJobSelection.SelectedIndex = 0;
                }
                else

                    comboBoxJobSelection.Text = "No jobs found";
            }

            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Error", $"Error while loading joblist: {ex.Message}");
            }
        }

        private void singleExecuteButton_Click(object sender, EventArgs e)
        {
            if (comboBoxJobSelection.SelectedItem == null) return;

            string selectedJobName = comboBoxJobSelection.Text;
            JobConfig config = JobConfigurationManager.LoadJob(selectedJobName);

            // 1. ProgressForm initialisieren und anzeigen
            ProgressForm progressForm = new ProgressForm();
            progressForm.Show(); // Wichtig: Nicht-modal anzeigen

            // 2. IProgress-Handler erstellen (kümmert sich um die UI-Updates)
            IProgress<JobProgressData> progressHandler = new Progress<JobProgressData>(data =>
            {
                if (data.IsComplete)
                {
                    progressForm.Close();
                }
                else
                {
                    progressForm.Name = $"Copying: {data.CurrentFile}";
                    progressForm.progressBar.Value = data.ProgressPercentage;
                }
            });

            // 3. Job im Hintergrund starten
            Task.Run(() =>
            {
                try
                {
                    JobExecutor.ExecuteJob(config, progressHandler);
                }
                catch (Exception ex)
                {
                    // Bei einem Fehler muss das UI-Update auch im UI-Thread erfolgen
                    progressHandler.Report(new JobProgressData { IsComplete = true });
                    MessageBox.Show($"Execution failed: {ex.Message}", "Error");
                }
                finally
                {
                    // 4. Job beendet: Meldung senden, damit die Form geschlossen wird
                    progressHandler.Report(new JobProgressData { IsComplete = true });
                }
            });
        }

        private void comboBoxJobSelection_Click(object sender, EventArgs e)
        {
            LoadJobSelectionComboBox();
        }
    }
}
