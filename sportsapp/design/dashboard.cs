using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SportsApp
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/martindolores");
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/martindolores/");
        }

        private void btnAmFoot_Click(object sender, EventArgs e)
        {
            this.Hide();
            amFoot newamFoot = new amFoot();
            newamFoot.ShowDialog();
            
        }

        private void btnAussieRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            aussieRules aussieRules = new aussieRules();
            aussieRules.ShowDialog();
        }

        private void btnCricket_Click(object sender, EventArgs e)
        {
            this.Hide();
            cricket cricket = new cricket();
            cricket.ShowDialog();
        }

        private void btnRugby_Click(object sender, EventArgs e)
        {
            this.Hide();
            rugby rugby = new rugby();
            rugby.ShowDialog();
        }

        private void btnFoot_Click(object sender, EventArgs e)
        {
            this.Hide();
            football football = new football();
            football.ShowDialog();
        }

        private void btnMMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            mma mma = new mma();
            mma.ShowDialog();
        }
    }
}
