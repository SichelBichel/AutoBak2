namespace AutoBak2
{
    partial class Form1
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            showHelpWindowToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            visitWebsiteToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            openConfigfolderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1253, 24);
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
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(55, 20);
            optionsToolStripMenuItem.Text = "Config";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
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
            tabControl1.Size = new Size(1229, 614);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1221, 586);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Instance 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1221, 586);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Instance 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // openConfigfolderToolStripMenuItem
            // 
            openConfigfolderToolStripMenuItem.Name = "openConfigfolderToolStripMenuItem";
            openConfigfolderToolStripMenuItem.Size = new Size(180, 22);
            openConfigfolderToolStripMenuItem.Text = "Open Configfolder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 653);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AutoBak 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
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
    }
}
