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

                    comboBoxJobSelection.Text = "Keine Jobs gefunden";
            }
            
            catch (Exception ex)
            {
                // Fehlerbehandlung, falls das Datenverzeichnis nicht erreichbar ist, etc.
                MessageBox.Show($"Fehler beim Laden der Job-Liste: {ex.Message}", "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadJobConfigToEditor(JobConfig config)
        {
            textBoxJobName.Text = config.Name;


            richTextBoxJobDescription.Text = config.JobDescription;

            textBoxSourcePath.Text = config.SourcePath;

            textBoxDestinationPath.Text = config.TargetPath;

            checkBoxArchive.Checked = config.ArchiveEnabled;

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
                MessageBox.Show("Bitte wählen Sie zuerst einen Job aus der Liste im 'Job Manager' aus.", "Auswahl erforderlich", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Die Konfigurationsdatei für den Job '{selectedJobName}' wurde nicht gefunden.", "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Job-Konfiguration: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
