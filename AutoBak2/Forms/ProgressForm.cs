using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoBak2.Utils;

namespace AutoBak2.Forms
{
    public partial class ProgressForm : Form
    {
        public event EventHandler JobAborted;
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void buttonProgressAbort_Click(object sender, EventArgs e)
        {
            JobAborted?.Invoke(this, EventArgs.Empty);

            buttonProgressAbort.Enabled = false;
            this.Text = "Canceling...";
        }

        public void UpdateProgress(JobProgressData data)
        {


            if (data.IsComplete)
            {
                progressBar.Value = progressBar.Maximum; // 100%
                // Optional: Form schließen oder Button aktivieren
                // this.Close(); // Oder je nach gewünschtem Verhalten
            }
            else
            {
                progressBar.Value = data.ProgressPercentage;
            }
        }


    }
}
