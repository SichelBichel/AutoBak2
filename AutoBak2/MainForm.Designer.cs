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
            tabPage2 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1270, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addInstanceToolStripMenuItem, deleteInstanceToolStripMenuItem, stopAllInstancesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // addInstanceToolStripMenuItem
            // 
            addInstanceToolStripMenuItem.Name = "addInstanceToolStripMenuItem";
            addInstanceToolStripMenuItem.Size = new Size(167, 22);
            addInstanceToolStripMenuItem.Text = "Add Instance";
            // 
            // deleteInstanceToolStripMenuItem
            // 
            deleteInstanceToolStripMenuItem.Name = "deleteInstanceToolStripMenuItem";
            deleteInstanceToolStripMenuItem.Size = new Size(167, 22);
            deleteInstanceToolStripMenuItem.Text = "Delete Instance";
            // 
            // stopAllInstancesToolStripMenuItem
            // 
            stopAllInstancesToolStripMenuItem.Name = "stopAllInstancesToolStripMenuItem";
            stopAllInstancesToolStripMenuItem.Size = new Size(167, 22);
            stopAllInstancesToolStripMenuItem.Text = "Stop All Instances";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, openConfigfolderToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(55, 20);
            optionsToolStripMenuItem.Text = "Config";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(173, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(173, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // openConfigfolderToolStripMenuItem
            // 
            openConfigfolderToolStripMenuItem.Name = "openConfigfolderToolStripMenuItem";
            openConfigfolderToolStripMenuItem.Size = new Size(173, 22);
            openConfigfolderToolStripMenuItem.Text = "Open Configfolder";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHelpWindowToolStripMenuItem, settingsToolStripMenuItem, visitWebsiteToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpWindowToolStripMenuItem
            // 
            showHelpWindowToolStripMenuItem.Name = "showHelpWindowToolStripMenuItem";
            showHelpWindowToolStripMenuItem.Size = new Size(178, 22);
            showHelpWindowToolStripMenuItem.Text = "Show Help Window";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(178, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // visitWebsiteToolStripMenuItem
            // 
            visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            visitWebsiteToolStripMenuItem.Size = new Size(178, 22);
            visitWebsiteToolStripMenuItem.Text = "Visit Website";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(178, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1246, 641);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1238, 613);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Control";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1238, 613);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job Editor";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(135, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 325);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(261, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 285);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(599, 23);
            textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1270, 680);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDarkDark;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "AutoBak 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
    }
}
