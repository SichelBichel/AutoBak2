using AutoBak2.Utils;

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

            // --- 4. Subdirectory-Einstellungen (basierend auf der JobConfig) ---

            // Ich nehme an, Sie haben hier die Steuerelemente checkBoxCreateSubdirectory 
            // und textBoxDirectoryName (oder ähnlich) verwendet, da sie im Screenshot sichtbar sind,
            // aber nicht explizit benannt wurden. Ich verwende Platzhalternamen:

            // Checkbox für das Erstellen eines Unterverzeichnisses
            checkBoxCreateSubdirectory.Checked = config.CreateSubdirectory;

            // Name des Unterverzeichnisses
            textBoxSubdirectoryName.Text = config.SubdirectoryName;

            // optional: Fokus setzen
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

            // 5. Exklusionen (Müssten hier ausgelesen werden, wir initialisieren sie leer)
            // Wenn der Job geladen wurde, enthält diese Liste möglicherweise schon Daten.
            // Beim Speichern eines geänderten Jobs müssen wir die Exclusions mitnehmen.
            // Da wir diese noch ignorieren, erstellen wir hier nur eine neue leere Liste.
            // Später müsste hier die Logik zum Auslesen der Exclusions-Liste hin.
            job.ExcludedItems = new List<string>();

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

        private void buttonNewJob_Click(object sender, EventArgs e)
        {
            clearEditorSelection();
            comboBoxJobSelection.Text = "New Job";
        }
    }
}
