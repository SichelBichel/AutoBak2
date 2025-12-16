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
using AutoBak2.Utils.ShellActions;

namespace AutoBak2.Forms
{
    public partial class SingleExecForm : Form
    {
        private CancellationTokenSource _cts;
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

            _cts = new CancellationTokenSource();

            ProgressForm progressForm = new ProgressForm();
            progressForm.Show();

            progressForm.JobAborted += (s, ev) =>
            {
                _cts.Cancel(); 
            };


            IProgress<JobProgressData> progressHandler = new Progress<JobProgressData>(data =>
            {
                if (progressForm.IsHandleCreated) // Prüfen, ob das Fenster noch existiert
                {
                    progressForm.Invoke((MethodInvoker)delegate
                    {
                        progressForm.richTextBoxLog.AppendText(Environment.NewLine + data.CurrentFile);
                        progressForm.Text = "Copying Files:  "+selectedJobName;
                        progressForm.progressBar.Value = data.ProgressPercentage;
                        progressForm.labelCurrentFile.Text = data.CurrentFile;
                        progressForm.richTextBoxLog.SelectionStart = progressForm.richTextBoxLog.Text.Length;
                        progressForm.richTextBoxLog.ScrollToCaret();
                    });
                }
            });

            Task.Run(() =>
            {
                try
                {
                    JobExecutor.ExecuteJob(config, progressHandler, _cts.Token);
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Operation aborted by user.", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Execution failed: {ex.Message}", "Error");
                }
                finally
                {
                    progressHandler.Report(new JobProgressData { IsComplete = true });

                    if (_cts != null)
                    {
                        _cts.Dispose();
                        _cts = null;
                    }
                }
            });
        }

        private void comboBoxJobSelection_Click(object sender, EventArgs e)
        {
            LoadJobSelectionComboBox();
        }

        private void comboBoxJobSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJobSelection.SelectedItem == null)
            { return; }

            string selectedJobName = comboBoxJobSelection.SelectedItem.ToString();
            JobConfig config = JobConfigurationManager.LoadJob(selectedJobName);

            if (config != null)
            {
                linkLabelBrowseToSource.Text = config.SourcePath;
                linkLabelBrowseToDestination.Text = config.TargetPath;
                richTextBox1.Text = config.JobDescription;
            }
        }

        private void linkLabelBrowseToSource_Click(object sender, EventArgs e)
        {
            var path = linkLabelBrowseToSource.Text;
            try
            {
                ShellHandler.path(path);
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Error", ex.Message);
            }
        }

        private void linkLabelBrowseToDestination_Click(object sender, EventArgs e)
        {
            var path = linkLabelBrowseToDestination.Text;
            try
            {
                ShellHandler.path(path);
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Error", ex.Message);
            }
        }
    }
}
