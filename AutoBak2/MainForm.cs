using AutoBak2.Forms;
using AutoBak2.Utils;
using AutoBak2.Utils.ShellActions;

namespace AutoBak2
{
    public partial class MainForm : Form
    {
        public MainForm()
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
                MessageHandler.DisplayErrorBox("Error", $"Error while loading jonblist: {ex.Message}");
            }
        }

        public void LoadJobConfigToEditor(JobConfig config)
        {
            textBoxJobName.Text = config.Name;


            richTextBoxJobDescription.Text = config.JobDescription;

            textBoxSourcePath.Text = config.SourcePath;

            textBoxDestinationPath.Text = config.TargetPath;

            checkBoxArchive.Checked = config.ArchiveEnabled;

            checkBoxUseSourcedirectoryName.Checked = config.UseSourcedirectoryName;

            radioButtonZip.Checked = false;
            radioButtonRar.Checked = false;
            radioButton7z.Checked = false;
            radioButtonGz.Checked = false;

            flowLayoutPanelExclusions.Controls.Clear();

            if (config.ArchiveEnabled)
            {
                switch (config.ArchiveType)
                {
                    case JobConfig.ArchiveFormat.Zip:
                        radioButtonZip.Checked = true;
                        break;
                    case JobConfig.ArchiveFormat.Rar:
                        radioButtonRar.Checked = true;
                        break;
                    case JobConfig.ArchiveFormat.SevenZip:
                        radioButton7z.Checked = true;
                        break;
                    case JobConfig.ArchiveFormat.Gzip:
                        radioButtonGz.Checked = true;
                        break;
                    case JobConfig.ArchiveFormat.None:

                        break;

                }
            }

            if (config.ExcludedItems != null)
            {
                foreach (string exclusionPath in config.ExcludedItems)
                {
                    ExclusionEntry entry = new ExclusionEntry();

                    entry.setExclusionPath(exclusionPath);

                    flowLayoutPanelExclusions.Controls.Add(entry);
                }
            }

            checkBoxCreateSubdirectory.Checked = config.CreateSubdirectory;

            textBoxSubdirectoryName.Text = config.SubdirectoryName;

            textBoxJobName.Focus();
        }

        public JobConfig GetJobDataFromUI()
        {
            JobConfig job = new JobConfig();

            job.Name = textBoxJobName.Text.Trim();
            job.JobDescription = richTextBoxJobDescription.Text;
            job.SourcePath = textBoxSourcePath.Text.Trim();
            job.TargetPath = textBoxDestinationPath.Text.Trim();
            job.ArchiveEnabled = checkBoxArchive.Checked;

            if (job.ArchiveEnabled)
            {
                if (radioButtonZip.Checked)
                {
                    job.ArchiveType = JobConfig.ArchiveFormat.Zip;
                }
                else if (radioButtonRar.Checked)
                {
                    job.ArchiveType = JobConfig.ArchiveFormat.Rar;
                }
                else if (radioButton7z.Checked)
                {
                    job.ArchiveType = JobConfig.ArchiveFormat.SevenZip;
                }
                else if (radioButtonGz.Checked)
                {
                    job.ArchiveType = JobConfig.ArchiveFormat.Gzip;
                }
                else
                {
                    job.ArchiveType = JobConfig.ArchiveFormat.None;
                }
            }
            else
            {
                job.ArchiveType = JobConfig.ArchiveFormat.None;
            }

            job.CreateSubdirectory = checkBoxCreateSubdirectory.Checked;
            job.SubdirectoryName = textBoxSubdirectoryName.Text.Trim();
            job.UseSourcedirectoryName = checkBoxUseSourcedirectoryName.Checked;

            job.ExcludedItems = new List<string>();
            foreach (Control control in flowLayoutPanelExclusions.Controls)
            {
                // Prüft, ob es sich um unser ExclusionEntry UserControl handelt
                if (control is ExclusionEntry exclusionEntry)
                {
                    string path = exclusionEntry.getExclusionPath();

                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        job.ExcludedItems.Add(path);
                    }
                }
            }

            // job.ExcludedItems = new List<string>();

            return job;
        }








        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }







        private void buttonEditJob_Click(object sender, EventArgs e)
        {

            if (comboBoxJobSelection.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxJobSelection.Text))
            {
                MessageHandler.DisplayWarningBox("Caution", $"Select a Job first");
                return;
            }

            string selectedJobName = comboBoxJobSelection.Text;

            try
            {
                JobConfig config = JobConfigurationManager.LoadJob(selectedJobName);

                LoadJobConfigToEditor(config);

            }
            catch (FileNotFoundException)
            {
                MessageHandler.DisplayWarningBox("Warning", $"{selectedJobName} not found");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("ERROR", $"Error while loading job config: {ex.Message}");
            }
        }

        private void buttonSaveJob_Click(object sender, EventArgs e)
        {
            try
            {
                JobConfig jobToSave = GetJobDataFromUI();

                if (string.IsNullOrWhiteSpace(jobToSave.Name))
                {
                    MessageHandler.DisplayWarningBox("Warning", "Name cant be empty");
                    return;
                }

                JobConfigurationManager.SaveJob(jobToSave);

                LoadJobSelectionComboBox();

                comboBoxJobSelection.Text = jobToSave.Name;

            }
            catch (ArgumentException ex)
            {
                MessageHandler.DisplayErrorBox(" Error", $"Argument Exception {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayErrorBox("Fatal Error", $"writing issues {ex.Message}");
            }
        }

        private void clearEditorSelection()
        {
            textBoxJobName.Clear();
            richTextBoxJobDescription.Clear();
            textBoxSourcePath.Clear();
            textBoxDestinationPath.Clear();
            textBoxSubdirectoryName.Clear();
            comboBoxJobSelection.Text = "";
            checkBoxArchive.Checked = false;
            checkBoxCreateSubdirectory.Checked = false;
            checkBoxUseSourcedirectoryName.Checked = false;
            radioButton7z.Checked = false;
            radioButtonGz.Checked = false;
            radioButtonRar.Checked = false;
            radioButtonZip.Checked = false;
        }


        private void SelectFolderAndSetTextBox(string context)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = $"Select the {context}Directory";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (context == "destination")
                    {
                        textBoxDestinationPath.Text = fbd.SelectedPath;
                    }
                    else if (context == "source")
                    {
                        textBoxSourcePath.Text = fbd.SelectedPath;
                    }
                    else if (context == "exclusion")
                    {
                        string exclusionPath = fbd.SelectedPath;

                        if (!string.IsNullOrWhiteSpace(exclusionPath))
                        {
                            if (IsExclusionPathAlreadyPresent(exclusionPath))
                            {
                                MessageHandler.DisplayWarningBox("Caution", $"The path '{exclusionPath}' is already listed as an exclusion.");
                                return;
                            }

                            ExclusionEntry entry = new ExclusionEntry();
                            entry.setExclusionPath(exclusionPath);
                            flowLayoutPanelExclusions.Controls.Add(entry);
                        }
                    }
                }
            }
        }



        private bool IsExclusionPathAlreadyPresent(string path)
        {
            foreach (Control control in flowLayoutPanelExclusions.Controls)
            {
                if (control is ExclusionEntry exclusionEntry)
                {
                    if (exclusionEntry.getExclusionPath().Trim().Equals(path.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }




        private void buttonNewJob_Click(object sender, EventArgs e)
        {
            clearEditorSelection();
            comboBoxJobSelection.Text = "New Job";
        }

        private void buttonSelectSourcePath_Click(object sender, EventArgs e)
        {
            SelectFolderAndSetTextBox("source");
        }

        private void buttonSelectDestinationPath_Click(object sender, EventArgs e)
        {
            SelectFolderAndSetTextBox("destination");
        }

        private void buttonOpenJobFolder_Click(object sender, EventArgs e)
        {
            string exeRoot = AppDomain.CurrentDomain.BaseDirectory;
            const string DataDirectoryName = "data";
            const string JobsDirectoryName = "jobs";

            string fullJobsPath = Path.Combine(exeRoot, DataDirectoryName, JobsDirectoryName);
            ShellHandler.path(fullJobsPath, this);
        }

        private void buttonDeleteJob_Click(object sender, EventArgs e)
        {
            if (comboBoxJobSelection.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxJobSelection.Text))
            {
                MessageHandler.DisplayWarningBox("Caution", "Select a Job first");
                return;
            }

            string selectedJobName = comboBoxJobSelection.Text;

            // 2. Bestätigung einholen
            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{selectedJobName}' permanently?",
                "Confirm deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    JobConfigurationManager.DeleteJob(selectedJobName);

                    clearEditorSelection();

                    LoadJobSelectionComboBox();

                    MessageHandler.DisplayInfoBox("Success", $"Job '{selectedJobName}' was deleted.");
                }
                catch (Exception ex)
                {
                    MessageHandler.DisplayErrorBox("Fatal Error", $"Error while deleting job: {ex.Message}");
                }
            }
        }

        private void buttonSelectExclusionDialog_Click(object sender, EventArgs e)
        {
            SelectFolderAndSetTextBox("exclusion");
        }

        private void buttonCreateExclusion_Click(object sender, EventArgs e)
        {
            string exclusionPath = textBoxExclusionPath.Text;

            if (!string.IsNullOrWhiteSpace(exclusionPath))
            {
                if (IsExclusionPathAlreadyPresent(exclusionPath))
                {
                    MessageHandler.DisplayWarningBox("Caution", $"The path '{exclusionPath}' is already listed as an exclusion.");
                    return;
                }

                ExclusionEntry entry = new ExclusionEntry();
                entry.setExclusionPath(exclusionPath);
                flowLayoutPanelExclusions.Controls.Add(entry);
            }
        }

        private void buttonDeleteExclusions_Click(object sender, EventArgs e)
        {
            flowLayoutPanelExclusions.Controls.Clear();
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellHandler.url("https://regoga-interactive.com/", this);
        }
    }
}
