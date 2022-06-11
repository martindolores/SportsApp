using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SportsApp
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dash = new dashboard();
            dash.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/martindolores/");
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/martindolores");
        }
    }
}
