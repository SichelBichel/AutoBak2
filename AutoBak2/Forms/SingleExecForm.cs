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
            if (comboBoxJobSelection.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxJobSelection.Text))
            {
                MessageHandler.DisplayWarningBox("Caution", "Please select a job to execute.");
                return;
            }

            string selectedJobName = comboBoxJobSelection.Text;

            try
            {
                JobConfig config = JobConfigurationManager.LoadJob(selectedJobName);

                JobExecutor.ExecuteJob(config);


            }
            catch (FileNotFoundException)
            {
                MessageHandler.DisplayErrorBox("Error", $"Job configuration file for '{selectedJobName}' not found.");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Execution Error", $"An error occurred during job execution: {ex.Message}");
            }
        }
    }
}
