namespace AutoBak2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addInstanceToolStripMenuItem = new ToolStripMenuItem();
            deleteInstanceToolStripMenuItem = new ToolStripMenuItem();
            stopAllInstancesToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            openConfigfolderToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            showHelpWindowToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            visitWebsiteToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanelInstances = new FlowLayoutPanel();
            label14 = new Label();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            imageListHighQualityIcons = new ImageList(components);
            tabPage2 = new TabPage();
            label9 = new Label();
            groupBox3 = new GroupBox();
            richTextBoxJobDescription = new RichTextBox();
            label10 = new Label();
            panel4 = new Panel();
            groupBoxProtocol = new GroupBox();
            radioButtonGz = new RadioButton();
            radioButtonRar = new RadioButton();
            radioButton7z = new RadioButton();
            radioButtonZip = new RadioButton();
            checkBoxArchive = new CheckBox();
            label11 = new Label();
            textBoxJobName = new TextBox();
            panel5 = new Panel();
            buttonOpenJobFolder = new Button();
            imageListIcons = new ImageList(components);
            buttonNewJob = new Button();
            buttonDeleteJob = new Button();
            buttonEditJob = new Button();
            buttonSaveJob = new Button();
            label12 = new Label();
            comboBoxJobSelection = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            panel3 = new Panel();
            buttonDeleteExclusions = new Button();
            flowLayoutPanelExclusions = new FlowLayoutPanel();
            buttonCreateExclusion = new Button();
            buttonSelectExclusionDialog = new Button();
            label5 = new Label();
            textBoxExclusionPath = new TextBox();
            label6 = new Label();
            buttonSelectSourcePath = new Button();
            label4 = new Label();
            textBoxSourcePath = new TextBox();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            checkBoxUseSourcedirectoryName = new CheckBox();
            label3 = new Label();
            textBoxSubdirectoryName = new TextBox();
            label2 = new Label();
            checkBoxCreateSubdirectory = new CheckBox();
            label1 = new Label();
            textBoxDestinationPath = new TextBox();
            buttonSelectDestinationPath = new Button();
            tabPage3 = new TabPage();
            buttonShowDates = new Button();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            panel7 = new Panel();
            buttonOpenSchedulefolder = new Button();
            buttonNewSchedule = new Button();
            buttonDeleteSchedule = new Button();
            buttonEditSchedule = new Button();
            buttonSaveSchedule = new Button();
            label13 = new Label();
            comboBox2 = new ComboBox();
            groupBox7 = new GroupBox();
            radioButtonEndTime = new RadioButton();
            radioButtonNever = new RadioButton();
            textBox2 = new TextBox();
            panel6 = new Panel();
            buttonSetNowEnd = new Button();
            numericUpDown3 = new NumericUpDown();
            monthCalendarEnd = new MonthCalendar();
            numericUpDown4 = new NumericUpDown();
            groupBox6 = new GroupBox();
            radioButtonUseWeekdays = new RadioButton();
            radioButtonUseInterval = new RadioButton();
            groupBox9 = new GroupBox();
            checkedListBoxWeekdays = new CheckedListBox();
            groupBox8 = new GroupBox();
            textBox3 = new TextBox();
            radioButtonMinutes = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox5 = new GroupBox();
            radioButtonStartTime = new RadioButton();
            radioButtonImmediate = new RadioButton();
            textBox1 = new TextBox();
            panel1 = new Panel();
            buttonSetNowStart = new Button();
            numericUpDown2 = new NumericUpDown();
            monthCalendarStart = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            flowLayoutPanelInstances.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxProtocol.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel7.SuspendLayout();
            groupBox7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1451, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addInstanceToolStripMenuItem, deleteInstanceToolStripMenuItem, stopAllInstancesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // addInstanceToolStripMenuItem
            // 
            addInstanceToolStripMenuItem.Name = "addInstanceToolStripMenuItem";
            addInstanceToolStripMenuItem.Size = new Size(235, 26);
            addInstanceToolStripMenuItem.Text = "Add Instance";
            // 
            // deleteInstanceToolStripMenuItem
            // 
            deleteInstanceToolStripMenuItem.Name = "deleteInstanceToolStripMenuItem";
            deleteInstanceToolStripMenuItem.Size = new Size(235, 26);
            deleteInstanceToolStripMenuItem.Text = "Delete Instance (N/A)";
            // 
            // stopAllInstancesToolStripMenuItem
            // 
            stopAllInstancesToolStripMenuItem.Name = "stopAllInstancesToolStripMenuItem";
            stopAllInstancesToolStripMenuItem.Size = new Size(235, 26);
            stopAllInstancesToolStripMenuItem.Text = "Stop All Instances";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, openConfigfolderToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(67, 24);
            optionsToolStripMenuItem.Text = "Config";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(216, 26);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(216, 26);
            exportToolStripMenuItem.Text = "Export";
            // 
            // openConfigfolderToolStripMenuItem
            // 
            openConfigfolderToolStripMenuItem.Name = "openConfigfolderToolStripMenuItem";
            openConfigfolderToolStripMenuItem.Size = new Size(216, 26);
            openConfigfolderToolStripMenuItem.Text = "Open Configfolder";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHelpWindowToolStripMenuItem, settingsToolStripMenuItem, visitWebsiteToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpWindowToolStripMenuItem
            // 
            showHelpWindowToolStripMenuItem.Name = "showHelpWindowToolStripMenuItem";
            showHelpWindowToolStripMenuItem.Size = new Size(223, 26);
            showHelpWindowToolStripMenuItem.Text = "Show Help Window";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(223, 26);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // visitWebsiteToolStripMenuItem
            // 
            visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            visitWebsiteToolStripMenuItem.Size = new Size(223, 26);
            visitWebsiteToolStripMenuItem.Text = "Visit Website";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(223, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 36);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1424, 855);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(flowLayoutPanelInstances);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1416, 822);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Control";
            // 
            // flowLayoutPanelInstances
            // 
            flowLayoutPanelInstances.BackColor = Color.DarkGray;
            flowLayoutPanelInstances.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelInstances.Controls.Add(label14);
            flowLayoutPanelInstances.Location = new Point(6, 101);
            flowLayoutPanelInstances.Name = "flowLayoutPanelInstances";
            flowLayoutPanelInstances.Size = new Size(1404, 714);
            flowLayoutPanelInstances.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(336, 32);
            label14.TabIndex = 0;
            label14.Text = "Not available in alpha verision";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(458, 8);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(451, 86);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Single Copy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageKey = "icon_Start.png";
            button1.ImageList = imageListHighQualityIcons;
            button1.Location = new Point(6, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 1;
            button1.Text = "Start Job";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // imageListHighQualityIcons
            // 
            imageListHighQualityIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListHighQualityIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListHighQualityIcons.ImageStream");
            imageListHighQualityIcons.TransparentColor = Color.Transparent;
            imageListHighQualityIcons.Images.SetKeyName(0, "icon_Check.png");
            imageListHighQualityIcons.Images.SetKeyName(1, "icon_blitz.png");
            imageListHighQualityIcons.Images.SetKeyName(2, "icon_clear.png");
            imageListHighQualityIcons.Images.SetKeyName(3, "icon_clearconsole.png");
            imageListHighQualityIcons.Images.SetKeyName(4, "icon_console.png");
            imageListHighQualityIcons.Images.SetKeyName(5, "icon_create.png");
            imageListHighQualityIcons.Images.SetKeyName(6, "icon_delete.png");
            imageListHighQualityIcons.Images.SetKeyName(7, "icon_disable.png");
            imageListHighQualityIcons.Images.SetKeyName(8, "icon_download.png");
            imageListHighQualityIcons.Images.SetKeyName(9, "icon_Edit.png");
            imageListHighQualityIcons.Images.SetKeyName(10, "icon_enable.png");
            imageListHighQualityIcons.Images.SetKeyName(11, "icon_export.png");
            imageListHighQualityIcons.Images.SetKeyName(12, "icon_help.png");
            imageListHighQualityIcons.Images.SetKeyName(13, "icon_import.png");
            imageListHighQualityIcons.Images.SetKeyName(14, "icon_information.png");
            imageListHighQualityIcons.Images.SetKeyName(15, "icon_inject.png");
            imageListHighQualityIcons.Images.SetKeyName(16, "icon_Load.png");
            imageListHighQualityIcons.Images.SetKeyName(17, "icon_reload.png");
            imageListHighQualityIcons.Images.SetKeyName(18, "icon_remove.png");
            imageListHighQualityIcons.Images.SetKeyName(19, "icon_Save.png");
            imageListHighQualityIcons.Images.SetKeyName(20, "icon_settings.png");
            imageListHighQualityIcons.Images.SetKeyName(21, "icon_Start.png");
            imageListHighQualityIcons.Images.SetKeyName(22, "icon_stopall.png");
            imageListHighQualityIcons.Images.SetKeyName(23, "icon_Uncheck.png");
            imageListHighQualityIcons.Images.SetKeyName(24, "icon_upload.png");
            imageListHighQualityIcons.Images.SetKeyName(25, "icon_website.png");
            imageListHighQualityIcons.Images.SetKeyName(26, "icon_Save2.png");
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ForeColor = SystemColors.ActiveCaptionText;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1416, 822);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job Editor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label9.Location = new Point(171, 176);
            label9.Name = "label9";
            label9.Size = new Size(337, 72);
            label9.TabIndex = 31;
            label9.Text = "JOB EDITOR";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBoxJobDescription);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBoxJobName);
            groupBox3.Location = new Point(7, 255);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(686, 305);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // richTextBoxJobDescription
            // 
            richTextBoxJobDescription.Location = new Point(7, 108);
            richTextBoxJobDescription.Margin = new Padding(3, 4, 3, 4);
            richTextBoxJobDescription.Name = "richTextBoxJobDescription";
            richTextBoxJobDescription.Size = new Size(671, 77);
            richTextBoxJobDescription.TabIndex = 58;
            richTextBoxJobDescription.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 84);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 57;
            label10.Text = "Job Description";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(groupBoxProtocol);
            panel4.Controls.Add(checkBoxArchive);
            panel4.Location = new Point(5, 195);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(674, 102);
            panel4.TabIndex = 55;
            // 
            // groupBoxProtocol
            // 
            groupBoxProtocol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProtocol.BackColor = Color.Silver;
            groupBoxProtocol.Controls.Add(radioButtonGz);
            groupBoxProtocol.Controls.Add(radioButtonRar);
            groupBoxProtocol.Controls.Add(radioButton7z);
            groupBoxProtocol.Controls.Add(radioButtonZip);
            groupBoxProtocol.FlatStyle = FlatStyle.Flat;
            groupBoxProtocol.Location = new Point(170, 7);
            groupBoxProtocol.Margin = new Padding(3, 4, 3, 4);
            groupBoxProtocol.Name = "groupBoxProtocol";
            groupBoxProtocol.Padding = new Padding(3, 4, 3, 4);
            groupBoxProtocol.Size = new Size(494, 76);
            groupBoxProtocol.TabIndex = 2;
            groupBoxProtocol.TabStop = false;
            groupBoxProtocol.Text = "Format";
            // 
            // radioButtonGz
            // 
            radioButtonGz.AutoSize = true;
            radioButtonGz.Location = new Point(185, 28);
            radioButtonGz.Margin = new Padding(3, 4, 3, 4);
            radioButtonGz.Name = "radioButtonGz";
            radioButtonGz.Size = new Size(49, 24);
            radioButtonGz.TabIndex = 3;
            radioButtonGz.TabStop = true;
            radioButtonGz.Text = ".gz";
            radioButtonGz.UseVisualStyleBackColor = true;
            // 
            // radioButtonRar
            // 
            radioButtonRar.AutoSize = true;
            radioButtonRar.Location = new Point(63, 29);
            radioButtonRar.Margin = new Padding(3, 4, 3, 4);
            radioButtonRar.Name = "radioButtonRar";
            radioButtonRar.Size = new Size(51, 24);
            radioButtonRar.TabIndex = 2;
            radioButtonRar.TabStop = true;
            radioButtonRar.Text = ".rar";
            radioButtonRar.UseVisualStyleBackColor = true;
            // 
            // radioButton7z
            // 
            radioButton7z.AutoSize = true;
            radioButton7z.Location = new Point(120, 29);
            radioButton7z.Margin = new Padding(3, 4, 3, 4);
            radioButton7z.Name = "radioButton7z";
            radioButton7z.Size = new Size(48, 24);
            radioButton7z.TabIndex = 1;
            radioButton7z.TabStop = true;
            radioButton7z.Text = ".7z";
            radioButton7z.UseVisualStyleBackColor = true;
            // 
            // radioButtonZip
            // 
            radioButtonZip.AutoSize = true;
            radioButtonZip.Location = new Point(7, 29);
            radioButtonZip.Margin = new Padding(3, 4, 3, 4);
            radioButtonZip.Name = "radioButtonZip";
            radioButtonZip.Size = new Size(53, 24);
            radioButtonZip.TabIndex = 0;
            radioButtonZip.TabStop = true;
            radioButtonZip.Text = ".zip";
            radioButtonZip.UseVisualStyleBackColor = true;
            // 
            // checkBoxArchive
            // 
            checkBoxArchive.AutoSize = true;
            checkBoxArchive.Location = new Point(31, 36);
            checkBoxArchive.Margin = new Padding(3, 4, 3, 4);
            checkBoxArchive.Name = "checkBoxArchive";
            checkBoxArchive.Size = new Size(80, 24);
            checkBoxArchive.TabIndex = 54;
            checkBoxArchive.Text = "Archive";
            checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 25);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 53;
            label11.Text = "Job Name";
            // 
            // textBoxJobName
            // 
            textBoxJobName.Location = new Point(7, 49);
            textBoxJobName.Margin = new Padding(3, 4, 3, 4);
            textBoxJobName.Name = "textBoxJobName";
            textBoxJobName.Size = new Size(671, 27);
            textBoxJobName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(buttonOpenJobFolder);
            panel5.Controls.Add(buttonNewJob);
            panel5.Controls.Add(buttonDeleteJob);
            panel5.Controls.Add(buttonEditJob);
            panel5.Controls.Add(buttonSaveJob);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(comboBoxJobSelection);
            panel5.Location = new Point(7, 20);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(685, 147);
            panel5.TabIndex = 29;
            // 
            // buttonOpenJobFolder
            // 
            buttonOpenJobFolder.Cursor = Cursors.Hand;
            buttonOpenJobFolder.Font = new Font("Segoe UI", 9F);
            buttonOpenJobFolder.ImageAlign = ContentAlignment.TopCenter;
            buttonOpenJobFolder.ImageIndex = 13;
            buttonOpenJobFolder.ImageList = imageListIcons;
            buttonOpenJobFolder.Location = new Point(543, 75);
            buttonOpenJobFolder.Margin = new Padding(3, 4, 3, 4);
            buttonOpenJobFolder.Name = "buttonOpenJobFolder";
            buttonOpenJobFolder.Size = new Size(126, 57);
            buttonOpenJobFolder.TabIndex = 7;
            buttonOpenJobFolder.Text = "Open Job Folder";
            buttonOpenJobFolder.TextAlign = ContentAlignment.BottomCenter;
            buttonOpenJobFolder.UseVisualStyleBackColor = true;
            buttonOpenJobFolder.Click += buttonOpenJobFolder_Click;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "icon_blitz.png");
            imageListIcons.Images.SetKeyName(1, "icon_Check.png");
            imageListIcons.Images.SetKeyName(2, "icon_create.png");
            imageListIcons.Images.SetKeyName(3, "icon_delete.png");
            imageListIcons.Images.SetKeyName(4, "icon_disable.png");
            imageListIcons.Images.SetKeyName(5, "icon_download.png");
            imageListIcons.Images.SetKeyName(6, "icon_Edit.png");
            imageListIcons.Images.SetKeyName(7, "icon_enable.png");
            imageListIcons.Images.SetKeyName(8, "icon_export.png");
            imageListIcons.Images.SetKeyName(9, "icon_help.png");
            imageListIcons.Images.SetKeyName(10, "icon_import.png");
            imageListIcons.Images.SetKeyName(11, "icon_information.png");
            imageListIcons.Images.SetKeyName(12, "icon_inject.png");
            imageListIcons.Images.SetKeyName(13, "icon_Load.png");
            imageListIcons.Images.SetKeyName(14, "icon_reload.png");
            imageListIcons.Images.SetKeyName(15, "icon_Save.png");
            imageListIcons.Images.SetKeyName(16, "icon_settings.png");
            imageListIcons.Images.SetKeyName(17, "icon_Start.png");
            imageListIcons.Images.SetKeyName(18, "icon_stopall.png");
            imageListIcons.Images.SetKeyName(19, "icon_Uncheck.png");
            imageListIcons.Images.SetKeyName(20, "icon_upload.png");
            imageListIcons.Images.SetKeyName(21, "icon_website.png");
            imageListIcons.Images.SetKeyName(22, "icon_clear.png");
            imageListIcons.Images.SetKeyName(23, "icon_console.png");
            imageListIcons.Images.SetKeyName(24, "icon_remove.png");
            imageListIcons.Images.SetKeyName(25, "icon_clearconsole.png");
            // 
            // buttonNewJob
            // 
            buttonNewJob.Cursor = Cursors.Hand;
            buttonNewJob.ImageAlign = ContentAlignment.TopCenter;
            buttonNewJob.ImageIndex = 6;
            buttonNewJob.ImageList = imageListIcons;
            buttonNewJob.Location = new Point(15, 75);
            buttonNewJob.Margin = new Padding(3, 4, 3, 4);
            buttonNewJob.Name = "buttonNewJob";
            buttonNewJob.Size = new Size(126, 57);
            buttonNewJob.TabIndex = 6;
            buttonNewJob.Text = "New Job";
            buttonNewJob.TextAlign = ContentAlignment.BottomCenter;
            buttonNewJob.UseVisualStyleBackColor = true;
            buttonNewJob.Click += buttonNewJob_Click;
            // 
            // buttonDeleteJob
            // 
            buttonDeleteJob.Cursor = Cursors.Hand;
            buttonDeleteJob.Font = new Font("Segoe UI", 9F);
            buttonDeleteJob.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteJob.ImageIndex = 3;
            buttonDeleteJob.ImageList = imageListIcons;
            buttonDeleteJob.Location = new Point(413, 75);
            buttonDeleteJob.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteJob.Name = "buttonDeleteJob";
            buttonDeleteJob.Size = new Size(126, 57);
            buttonDeleteJob.TabIndex = 5;
            buttonDeleteJob.Text = "Delete Job";
            buttonDeleteJob.TextAlign = ContentAlignment.BottomCenter;
            buttonDeleteJob.UseVisualStyleBackColor = true;
            buttonDeleteJob.Click += buttonDeleteJob_Click;
            // 
            // buttonEditJob
            // 
            buttonEditJob.Cursor = Cursors.Hand;
            buttonEditJob.Font = new Font("Segoe UI", 9F);
            buttonEditJob.ImageAlign = ContentAlignment.TopCenter;
            buttonEditJob.ImageIndex = 16;
            buttonEditJob.ImageList = imageListIcons;
            buttonEditJob.Location = new Point(280, 75);
            buttonEditJob.Margin = new Padding(3, 4, 3, 4);
            buttonEditJob.Name = "buttonEditJob";
            buttonEditJob.Size = new Size(126, 57);
            buttonEditJob.TabIndex = 4;
            buttonEditJob.Text = "Edit Job";
            buttonEditJob.TextAlign = ContentAlignment.BottomCenter;
            buttonEditJob.UseVisualStyleBackColor = true;
            buttonEditJob.Click += buttonEditJob_Click;
            // 
            // buttonSaveJob
            // 
            buttonSaveJob.Cursor = Cursors.Hand;
            buttonSaveJob.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveJob.ImageIndex = 15;
            buttonSaveJob.ImageList = imageListIcons;
            buttonSaveJob.Location = new Point(147, 75);
            buttonSaveJob.Margin = new Padding(3, 4, 3, 4);
            buttonSaveJob.Name = "buttonSaveJob";
            buttonSaveJob.Size = new Size(126, 57);
            buttonSaveJob.TabIndex = 2;
            buttonSaveJob.Text = "Save Job";
            buttonSaveJob.TextAlign = ContentAlignment.BottomCenter;
            buttonSaveJob.UseVisualStyleBackColor = true;
            buttonSaveJob.Click += buttonSaveJob_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(264, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 23);
            label12.TabIndex = 1;
            label12.Text = "Job Manager";
            // 
            // comboBoxJobSelection
            // 
            comboBoxJobSelection.FormattingEnabled = true;
            comboBoxJobSelection.Location = new Point(3, 36);
            comboBoxJobSelection.Margin = new Padding(3, 4, 3, 4);
            comboBoxJobSelection.Name = "comboBoxJobSelection";
            comboBoxJobSelection.Size = new Size(676, 28);
            comboBoxJobSelection.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(buttonSelectSourcePath);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxSourcePath);
            groupBox2.Location = new Point(722, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(686, 801);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Source";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 107);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 59;
            label7.Text = "Exclusions";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonDeleteExclusions);
            panel3.Controls.Add(flowLayoutPanelExclusions);
            panel3.Controls.Add(buttonCreateExclusion);
            panel3.Controls.Add(buttonSelectExclusionDialog);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxExclusionPath);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(5, 131);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 662);
            panel3.TabIndex = 58;
            // 
            // buttonDeleteExclusions
            // 
            buttonDeleteExclusions.Cursor = Cursors.Hand;
            buttonDeleteExclusions.Font = new Font("Segoe UI", 9F);
            buttonDeleteExclusions.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteExclusions.ImageKey = "icon_delete.png";
            buttonDeleteExclusions.ImageList = imageListHighQualityIcons;
            buttonDeleteExclusions.Location = new Point(551, 21);
            buttonDeleteExclusions.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteExclusions.Name = "buttonDeleteExclusions";
            buttonDeleteExclusions.Size = new Size(118, 63);
            buttonDeleteExclusions.TabIndex = 61;
            buttonDeleteExclusions.Text = "Delete All";
            buttonDeleteExclusions.TextAlign = ContentAlignment.BottomCenter;
            buttonDeleteExclusions.UseVisualStyleBackColor = true;
            buttonDeleteExclusions.Click += buttonDeleteExclusions_Click;
            // 
            // flowLayoutPanelExclusions
            // 
            flowLayoutPanelExclusions.AutoScroll = true;
            flowLayoutPanelExclusions.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanelExclusions.Location = new Point(3, 91);
            flowLayoutPanelExclusions.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelExclusions.Name = "flowLayoutPanelExclusions";
            flowLayoutPanelExclusions.Size = new Size(665, 564);
            flowLayoutPanelExclusions.TabIndex = 60;
            // 
            // buttonCreateExclusion
            // 
            buttonCreateExclusion.Cursor = Cursors.Hand;
            buttonCreateExclusion.Font = new Font("Segoe UI", 9F);
            buttonCreateExclusion.ImageAlign = ContentAlignment.TopCenter;
            buttonCreateExclusion.ImageKey = "icon_create.png";
            buttonCreateExclusion.ImageList = imageListHighQualityIcons;
            buttonCreateExclusion.Location = new Point(427, 21);
            buttonCreateExclusion.Margin = new Padding(3, 4, 3, 4);
            buttonCreateExclusion.Name = "buttonCreateExclusion";
            buttonCreateExclusion.Size = new Size(118, 63);
            buttonCreateExclusion.TabIndex = 59;
            buttonCreateExclusion.Text = "Create Exclusion";
            buttonCreateExclusion.TextAlign = ContentAlignment.BottomCenter;
            buttonCreateExclusion.UseVisualStyleBackColor = true;
            buttonCreateExclusion.Click += buttonCreateExclusion_Click;
            // 
            // buttonSelectExclusionDialog
            // 
            buttonSelectExclusionDialog.Location = new Point(389, 49);
            buttonSelectExclusionDialog.Margin = new Padding(3, 4, 3, 4);
            buttonSelectExclusionDialog.Name = "buttonSelectExclusionDialog";
            buttonSelectExclusionDialog.Size = new Size(32, 35);
            buttonSelectExclusionDialog.TabIndex = 58;
            buttonSelectExclusionDialog.Text = "🔍";
            buttonSelectExclusionDialog.UseVisualStyleBackColor = true;
            buttonSelectExclusionDialog.Click += buttonSelectExclusionDialog_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 55;
            label5.Text = "Directory Name";
            // 
            // textBoxExclusionPath
            // 
            textBoxExclusionPath.Location = new Point(3, 52);
            textBoxExclusionPath.Margin = new Padding(3, 4, 3, 4);
            textBoxExclusionPath.Name = "textBoxExclusionPath";
            textBoxExclusionPath.Size = new Size(378, 27);
            textBoxExclusionPath.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 48);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // buttonSelectSourcePath
            // 
            buttonSelectSourcePath.Location = new Point(647, 47);
            buttonSelectSourcePath.Margin = new Padding(3, 4, 3, 4);
            buttonSelectSourcePath.Name = "buttonSelectSourcePath";
            buttonSelectSourcePath.Size = new Size(32, 35);
            buttonSelectSourcePath.TabIndex = 57;
            buttonSelectSourcePath.Text = "🔍";
            buttonSelectSourcePath.UseVisualStyleBackColor = true;
            buttonSelectSourcePath.Click += buttonSelectSourcePath_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 25);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 56;
            label4.Text = "Source Path";
            // 
            // textBoxSourcePath
            // 
            textBoxSourcePath.Location = new Point(7, 49);
            textBoxSourcePath.Margin = new Padding(3, 4, 3, 4);
            textBoxSourcePath.Name = "textBoxSourcePath";
            textBoxSourcePath.Size = new Size(636, 27);
            textBoxSourcePath.TabIndex = 54;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(checkBoxCreateSubdirectory);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxDestinationPath);
            groupBox1.Controls.Add(buttonSelectDestinationPath);
            groupBox1.Location = new Point(7, 568);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(686, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destination";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkBoxUseSourcedirectoryName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxSubdirectoryName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 131);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 102);
            panel2.TabIndex = 55;
            // 
            // checkBoxUseSourcedirectoryName
            // 
            checkBoxUseSourcedirectoryName.AutoSize = true;
            checkBoxUseSourcedirectoryName.Location = new Point(408, 43);
            checkBoxUseSourcedirectoryName.Margin = new Padding(3, 4, 3, 4);
            checkBoxUseSourcedirectoryName.Name = "checkBoxUseSourcedirectoryName";
            checkBoxUseSourcedirectoryName.Size = new Size(207, 24);
            checkBoxUseSourcedirectoryName.TabIndex = 56;
            checkBoxUseSourcedirectoryName.Text = "Use Sourcedirectory Name";
            checkBoxUseSourcedirectoryName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 55;
            label3.Text = "Directory Name";
            // 
            // textBoxSubdirectoryName
            // 
            textBoxSubdirectoryName.Location = new Point(3, 40);
            textBoxSubdirectoryName.Margin = new Padding(3, 4, 3, 4);
            textBoxSubdirectoryName.Name = "textBoxSubdirectoryName";
            textBoxSubdirectoryName.Size = new Size(321, 27);
            textBoxSubdirectoryName.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // checkBoxCreateSubdirectory
            // 
            checkBoxCreateSubdirectory.AutoSize = true;
            checkBoxCreateSubdirectory.Location = new Point(7, 101);
            checkBoxCreateSubdirectory.Margin = new Padding(3, 4, 3, 4);
            checkBoxCreateSubdirectory.Name = "checkBoxCreateSubdirectory";
            checkBoxCreateSubdirectory.Size = new Size(162, 24);
            checkBoxCreateSubdirectory.TabIndex = 54;
            checkBoxCreateSubdirectory.Text = "Create Subdirectory";
            checkBoxCreateSubdirectory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 53;
            label1.Text = "Destination Path";
            // 
            // textBoxDestinationPath
            // 
            textBoxDestinationPath.Location = new Point(7, 49);
            textBoxDestinationPath.Margin = new Padding(3, 4, 3, 4);
            textBoxDestinationPath.Name = "textBoxDestinationPath";
            textBoxDestinationPath.Size = new Size(636, 27);
            textBoxDestinationPath.TabIndex = 0;
            // 
            // buttonSelectDestinationPath
            // 
            buttonSelectDestinationPath.Location = new Point(647, 47);
            buttonSelectDestinationPath.Margin = new Padding(3, 4, 3, 4);
            buttonSelectDestinationPath.Name = "buttonSelectDestinationPath";
            buttonSelectDestinationPath.Size = new Size(32, 35);
            buttonSelectDestinationPath.TabIndex = 52;
            buttonSelectDestinationPath.Text = "🔍";
            buttonSelectDestinationPath.UseVisualStyleBackColor = true;
            buttonSelectDestinationPath.Click += buttonSelectDestinationPath_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(buttonShowDates);
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(panel7);
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1416, 822);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Schedule Editor";
            // 
            // buttonShowDates
            // 
            buttonShowDates.ForeColor = Color.Black;
            buttonShowDates.Location = new Point(947, 8);
            buttonShowDates.Name = "buttonShowDates";
            buttonShowDates.Size = new Size(453, 35);
            buttonShowDates.TabIndex = 35;
            buttonShowDates.Text = "Calculate Backup Times";
            buttonShowDates.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(947, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(453, 761);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(183, 163);
            label8.Name = "label8";
            label8.Size = new Size(507, 72);
            label8.TabIndex = 33;
            label8.Text = "SCHEDULE EDITOR";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(buttonOpenSchedulefolder);
            panel7.Controls.Add(buttonNewSchedule);
            panel7.Controls.Add(buttonDeleteSchedule);
            panel7.Controls.Add(buttonEditSchedule);
            panel7.Controls.Add(buttonSaveSchedule);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(comboBox2);
            panel7.Location = new Point(102, 12);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(685, 147);
            panel7.TabIndex = 32;
            // 
            // buttonOpenSchedulefolder
            // 
            buttonOpenSchedulefolder.Cursor = Cursors.Hand;
            buttonOpenSchedulefolder.Font = new Font("Segoe UI", 9F);
            buttonOpenSchedulefolder.ForeColor = SystemColors.ActiveCaptionText;
            buttonOpenSchedulefolder.ImageAlign = ContentAlignment.TopCenter;
            buttonOpenSchedulefolder.ImageIndex = 13;
            buttonOpenSchedulefolder.ImageList = imageListIcons;
            buttonOpenSchedulefolder.Location = new Point(543, 75);
            buttonOpenSchedulefolder.Margin = new Padding(3, 4, 3, 4);
            buttonOpenSchedulefolder.Name = "buttonOpenSchedulefolder";
            buttonOpenSchedulefolder.Size = new Size(126, 57);
            buttonOpenSchedulefolder.TabIndex = 7;
            buttonOpenSchedulefolder.Text = "Open Folder";
            buttonOpenSchedulefolder.TextAlign = ContentAlignment.BottomCenter;
            buttonOpenSchedulefolder.UseVisualStyleBackColor = true;
            // 
            // buttonNewSchedule
            // 
            buttonNewSchedule.Cursor = Cursors.Hand;
            buttonNewSchedule.ForeColor = SystemColors.ActiveCaptionText;
            buttonNewSchedule.ImageAlign = ContentAlignment.TopCenter;
            buttonNewSchedule.ImageIndex = 6;
            buttonNewSchedule.ImageList = imageListIcons;
            buttonNewSchedule.Location = new Point(15, 75);
            buttonNewSchedule.Margin = new Padding(3, 4, 3, 4);
            buttonNewSchedule.Name = "buttonNewSchedule";
            buttonNewSchedule.Size = new Size(126, 57);
            buttonNewSchedule.TabIndex = 6;
            buttonNewSchedule.Text = "New Schedule";
            buttonNewSchedule.TextAlign = ContentAlignment.BottomCenter;
            buttonNewSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSchedule
            // 
            buttonDeleteSchedule.Cursor = Cursors.Hand;
            buttonDeleteSchedule.Font = new Font("Segoe UI", 9F);
            buttonDeleteSchedule.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeleteSchedule.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteSchedule.ImageIndex = 3;
            buttonDeleteSchedule.ImageList = imageListIcons;
            buttonDeleteSchedule.Location = new Point(413, 75);
            buttonDeleteSchedule.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteSchedule.Name = "buttonDeleteSchedule";
            buttonDeleteSchedule.Size = new Size(126, 57);
            buttonDeleteSchedule.TabIndex = 5;
            buttonDeleteSchedule.Text = "Delete";
            buttonDeleteSchedule.TextAlign = ContentAlignment.BottomCenter;
            buttonDeleteSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonEditSchedule
            // 
            buttonEditSchedule.Cursor = Cursors.Hand;
            buttonEditSchedule.Font = new Font("Segoe UI", 9F);
            buttonEditSchedule.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditSchedule.ImageAlign = ContentAlignment.TopCenter;
            buttonEditSchedule.ImageIndex = 16;
            buttonEditSchedule.ImageList = imageListIcons;
            buttonEditSchedule.Location = new Point(280, 75);
            buttonEditSchedule.Margin = new Padding(3, 4, 3, 4);
            buttonEditSchedule.Name = "buttonEditSchedule";
            buttonEditSchedule.Size = new Size(126, 57);
            buttonEditSchedule.TabIndex = 4;
            buttonEditSchedule.Text = "Edit";
            buttonEditSchedule.TextAlign = ContentAlignment.BottomCenter;
            buttonEditSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSchedule
            // 
            buttonSaveSchedule.Cursor = Cursors.Hand;
            buttonSaveSchedule.ForeColor = SystemColors.ActiveCaptionText;
            buttonSaveSchedule.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveSchedule.ImageIndex = 15;
            buttonSaveSchedule.ImageList = imageListIcons;
            buttonSaveSchedule.Location = new Point(147, 75);
            buttonSaveSchedule.Margin = new Padding(3, 4, 3, 4);
            buttonSaveSchedule.Name = "buttonSaveSchedule";
            buttonSaveSchedule.Size = new Size(126, 57);
            buttonSaveSchedule.TabIndex = 2;
            buttonSaveSchedule.Text = "Save";
            buttonSaveSchedule.TextAlign = ContentAlignment.BottomCenter;
            buttonSaveSchedule.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(264, 0);
            label13.Name = "label13";
            label13.Size = new Size(152, 23);
            label13.TabIndex = 1;
            label13.Text = "Schedule Manager";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 36);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(676, 28);
            comboBox2.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Transparent;
            groupBox7.Controls.Add(radioButtonEndTime);
            groupBox7.Controls.Add(radioButtonNever);
            groupBox7.Controls.Add(textBox2);
            groupBox7.Controls.Add(panel6);
            groupBox7.Location = new Point(395, 255);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(374, 555);
            groupBox7.TabIndex = 12;
            groupBox7.TabStop = false;
            groupBox7.Text = "End Time";
            // 
            // radioButtonEndTime
            // 
            radioButtonEndTime.AutoSize = true;
            radioButtonEndTime.Location = new Point(31, 76);
            radioButtonEndTime.Name = "radioButtonEndTime";
            radioButtonEndTime.Size = new Size(17, 16);
            radioButtonEndTime.TabIndex = 12;
            radioButtonEndTime.TabStop = true;
            radioButtonEndTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonNever
            // 
            radioButtonNever.AutoSize = true;
            radioButtonNever.BackColor = Color.Silver;
            radioButtonNever.ForeColor = Color.Black;
            radioButtonNever.Location = new Point(31, 41);
            radioButtonNever.Name = "radioButtonNever";
            radioButtonNever.Size = new Size(69, 24);
            radioButtonNever.TabIndex = 11;
            radioButtonNever.TabStop = true;
            radioButtonNever.Text = "Never";
            radioButtonNever.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(buttonSetNowEnd);
            panel6.Controls.Add(numericUpDown3);
            panel6.Controls.Add(monthCalendarEnd);
            panel6.Controls.Add(numericUpDown4);
            panel6.Location = new Point(66, 172);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 351);
            panel6.TabIndex = 9;
            // 
            // buttonSetNowEnd
            // 
            buttonSetNowEnd.BackColor = SystemColors.Control;
            buttonSetNowEnd.ForeColor = SystemColors.ActiveCaptionText;
            buttonSetNowEnd.Location = new Point(79, 308);
            buttonSetNowEnd.Name = "buttonSetNowEnd";
            buttonSetNowEnd.Size = new Size(94, 29);
            buttonSetNowEnd.TabIndex = 9;
            buttonSetNowEnd.Text = "set to now";
            buttonSetNowEnd.UseVisualStyleBackColor = false;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(135, 252);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(73, 27);
            numericUpDown3.TabIndex = 8;
            // 
            // monthCalendarEnd
            // 
            monthCalendarEnd.Location = new Point(11, 9);
            monthCalendarEnd.Name = "monthCalendarEnd";
            monthCalendarEnd.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(35, 252);
            numericUpDown4.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(73, 27);
            numericUpDown4.TabIndex = 7;
            numericUpDown4.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButtonUseWeekdays);
            groupBox6.Controls.Add(radioButtonUseInterval);
            groupBox6.Controls.Add(groupBox9);
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Location = new Point(775, 255);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(166, 555);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Schedule";
            // 
            // radioButtonUseWeekdays
            // 
            radioButtonUseWeekdays.AutoSize = true;
            radioButtonUseWeekdays.ForeColor = Color.Black;
            radioButtonUseWeekdays.Location = new Point(24, 88);
            radioButtonUseWeekdays.Name = "radioButtonUseWeekdays";
            radioButtonUseWeekdays.Size = new Size(96, 24);
            radioButtonUseWeekdays.TabIndex = 19;
            radioButtonUseWeekdays.TabStop = true;
            radioButtonUseWeekdays.Text = "Weekdays";
            radioButtonUseWeekdays.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseInterval
            // 
            radioButtonUseInterval.AutoSize = true;
            radioButtonUseInterval.ForeColor = Color.Black;
            radioButtonUseInterval.Location = new Point(24, 58);
            radioButtonUseInterval.Name = "radioButtonUseInterval";
            radioButtonUseInterval.Size = new Size(79, 24);
            radioButtonUseInterval.TabIndex = 18;
            radioButtonUseInterval.TabStop = true;
            radioButtonUseInterval.Text = "Interval";
            radioButtonUseInterval.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(checkedListBoxWeekdays);
            groupBox9.Location = new Point(15, 331);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(133, 192);
            groupBox9.TabIndex = 17;
            groupBox9.TabStop = false;
            groupBox9.Text = "Every";
            // 
            // checkedListBoxWeekdays
            // 
            checkedListBoxWeekdays.BackColor = Color.DarkGray;
            checkedListBoxWeekdays.FormattingEnabled = true;
            checkedListBoxWeekdays.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBoxWeekdays.Location = new Point(6, 26);
            checkedListBoxWeekdays.Name = "checkedListBoxWeekdays";
            checkedListBoxWeekdays.Size = new Size(121, 158);
            checkedListBoxWeekdays.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox3);
            groupBox8.Controls.Add(radioButtonMinutes);
            groupBox8.Controls.Add(radioButton2);
            groupBox8.Controls.Add(radioButton1);
            groupBox8.Location = new Point(15, 155);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(133, 170);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "Every";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 27);
            textBox3.TabIndex = 11;
            // 
            // radioButtonMinutes
            // 
            radioButtonMinutes.AutoSize = true;
            radioButtonMinutes.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonMinutes.Location = new Point(9, 73);
            radioButtonMinutes.Name = "radioButtonMinutes";
            radioButtonMinutes.Size = new Size(82, 24);
            radioButtonMinutes.TabIndex = 12;
            radioButtonMinutes.TabStop = true;
            radioButtonMinutes.Text = "Minutes";
            radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(9, 133);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Days";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(9, 103);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hours";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButtonStartTime);
            groupBox5.Controls.Add(radioButtonImmediate);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(panel1);
            groupBox5.Location = new Point(15, 255);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(374, 555);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Start Time";
            // 
            // radioButtonStartTime
            // 
            radioButtonStartTime.AutoSize = true;
            radioButtonStartTime.Location = new Point(31, 76);
            radioButtonStartTime.Name = "radioButtonStartTime";
            radioButtonStartTime.Size = new Size(17, 16);
            radioButtonStartTime.TabIndex = 12;
            radioButtonStartTime.TabStop = true;
            radioButtonStartTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonImmediate
            // 
            radioButtonImmediate.AutoSize = true;
            radioButtonImmediate.BackColor = Color.Silver;
            radioButtonImmediate.ForeColor = Color.Black;
            radioButtonImmediate.Location = new Point(31, 41);
            radioButtonImmediate.Name = "radioButtonImmediate";
            radioButtonImmediate.Size = new Size(102, 24);
            radioButtonImmediate.TabIndex = 11;
            radioButtonImmediate.TabStop = true;
            radioButtonImmediate.Text = "Immediate";
            radioButtonImmediate.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonSetNowStart);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(monthCalendarStart);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(54, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 351);
            panel1.TabIndex = 9;
            // 
            // buttonSetNowStart
            // 
            buttonSetNowStart.BackColor = SystemColors.Control;
            buttonSetNowStart.ForeColor = SystemColors.ActiveCaptionText;
            buttonSetNowStart.Location = new Point(73, 308);
            buttonSetNowStart.Name = "buttonSetNowStart";
            buttonSetNowStart.Size = new Size(94, 29);
            buttonSetNowStart.TabIndex = 9;
            buttonSetNowStart.Text = "set to now";
            buttonSetNowStart.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(129, 252);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // monthCalendarStart
            // 
            monthCalendarStart.Location = new Point(11, 9);
            monthCalendarStart.Name = "monthCalendarStart";
            monthCalendarStart.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 252);
            numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1451, 907);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "AutoBak 2 [0.0.1]";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            flowLayoutPanelInstances.ResumeLayout(false);
            flowLayoutPanelInstances.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxProtocol.ResumeLayout(false);
            groupBoxProtocol.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem addInstanceToolStripMenuItem;
        private ToolStripMenuItem deleteInstanceToolStripMenuItem;
        private ToolStripMenuItem stopAllInstancesToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem showHelpWindowToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem visitWebsiteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem openConfigfolderToolStripMenuItem;
        private TextBox textBoxDestinationPath;
        private Button buttonSelectDestinationPath;
        private ImageList imageListIcons;
        private ImageList imageListHighQualityIcons;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBoxCreateSubdirectory;
        private CheckBox checkBoxUseSourcedirectoryName;
        private Label label3;
        private TextBox textBoxSubdirectoryName;
        private Label label2;
        private Label label4;
        private TextBox textBoxSourcePath;
        private Button buttonSelectSourcePath;
        private Label label7;
        private Panel panel3;
        private Button buttonCreateExclusion;
        private Button buttonSelectExclusionDialog;
        private Label label5;
        private TextBox textBoxExclusionPath;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanelExclusions;
        private Button buttonDeleteExclusions;
        private TabPage tabPage3;
        private Panel panel5;
        private Button buttonDeleteJob;
        private Button buttonEditJob;
        private Button buttonSaveJob;
        private Label label12;
        private ComboBox comboBoxJobSelection;
        private Button buttonOpenJobFolder;
        private Button buttonNewJob;
        private GroupBox groupBox3;
        private Panel panel4;
        private CheckBox checkBoxArchive;
        private Label label11;
        private TextBox textBoxJobName;
        private GroupBox groupBoxProtocol;
        private RadioButton radioButtonGz;
        private RadioButton radioButtonRar;
        private RadioButton radioButton7z;
        private RadioButton radioButtonZip;
        private Label label9;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private RichTextBox richTextBoxJobDescription;
        private Label label10;
        private MonthCalendar monthCalendarStart;
        private Panel panel1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox5;
        private Button buttonSetNowStart;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private RadioButton radioButtonEndTime;
        private RadioButton radioButtonNever;
        private TextBox textBox2;
        private Panel panel6;
        private Button buttonSetNowEnd;
        private NumericUpDown numericUpDown3;
        private MonthCalendar monthCalendarEnd;
        private NumericUpDown numericUpDown4;
        private RadioButton radioButtonStartTime;
        private RadioButton radioButtonImmediate;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButtonMinutes;
        private TextBox textBox3;
        private GroupBox groupBox9;
        private CheckedListBox checkedListBoxWeekdays;
        private GroupBox groupBox8;
        private RadioButton radioButtonUseWeekdays;
        private RadioButton radioButtonUseInterval;
        private Label label8;
        private Panel panel7;
        private Button buttonOpenSchedulefolder;
        private Button buttonNewSchedule;
        private Button buttonDeleteSchedule;
        private Button buttonEditSchedule;
        private Button buttonSaveSchedule;
        private Label label13;
        private ComboBox comboBox2;
        private Button buttonShowDates;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowLayoutPanelInstances;
        private Label label14;
    }
}
