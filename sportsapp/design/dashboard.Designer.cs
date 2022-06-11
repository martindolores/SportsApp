
using System.Drawing;

namespace SportsApp
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAmFoot = new System.Windows.Forms.Button();
            this.btnMMA = new System.Windows.Forms.Button();
            this.btnFoot = new System.Windows.Forms.Button();
            this.btnRugby = new System.Windows.Forms.Button();
            this.btnCricket = new System.Windows.Forms.Button();
            this.btnAussieRules = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLinkedin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.btnAmFoot);
            this.panel1.Controls.Add(this.btnMMA);
            this.panel1.Controls.Add(this.btnFoot);
            this.panel1.Controls.Add(this.btnRugby);
            this.panel1.Controls.Add(this.btnCricket);
            this.panel1.Controls.Add(this.btnAussieRules);
            this.panel1.Location = new System.Drawing.Point(1, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 184);
            this.panel1.TabIndex = 4;
            // 
            // btnAmFoot
            // 
            this.btnAmFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.btnAmFoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAmFoot.FlatAppearance.BorderSize = 0;
            this.btnAmFoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmFoot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmFoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAmFoot.Image = ((System.Drawing.Image)(resources.GetObject("btnAmFoot.Image")));
            this.btnAmFoot.Location = new System.Drawing.Point(-10, 0);
            this.btnAmFoot.Name = "btnAmFoot";
            this.btnAmFoot.Size = new System.Drawing.Size(202, 184);
            this.btnAmFoot.TabIndex = 5;
            this.btnAmFoot.Text = "American Football";
            this.btnAmFoot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAmFoot.UseVisualStyleBackColor = false;
            this.btnAmFoot.Click += new System.EventHandler(this.btnAmFoot_Click);
            // 
            // btnMMA
            // 
            this.btnMMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMMA.FlatAppearance.BorderSize = 0;
            this.btnMMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMMA.Image = ((System.Drawing.Image)(resources.GetObject("btnMMA.Image")));
            this.btnMMA.Location = new System.Drawing.Point(1011, 0);
            this.btnMMA.Name = "btnMMA";
            this.btnMMA.Size = new System.Drawing.Size(196, 184);
            this.btnMMA.TabIndex = 4;
            this.btnMMA.Text = "Mixed Martial Arts";
            this.btnMMA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMMA.UseVisualStyleBackColor = true;
            this.btnMMA.Click += new System.EventHandler(this.btnMMA_Click);
            // 
            // btnFoot
            // 
            this.btnFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.btnFoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFoot.FlatAppearance.BorderSize = 0;
            this.btnFoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFoot.Image = ((System.Drawing.Image)(resources.GetObject("btnFoot.Image")));
            this.btnFoot.Location = new System.Drawing.Point(809, 0);
            this.btnFoot.Name = "btnFoot";
            this.btnFoot.Size = new System.Drawing.Size(196, 184);
            this.btnFoot.TabIndex = 3;
            this.btnFoot.Text = "Football";
            this.btnFoot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoot.UseVisualStyleBackColor = false;
            this.btnFoot.Click += new System.EventHandler(this.btnFoot_Click);
            // 
            // btnRugby
            // 
            this.btnRugby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRugby.FlatAppearance.BorderSize = 0;
            this.btnRugby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRugby.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRugby.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRugby.Image = ((System.Drawing.Image)(resources.GetObject("btnRugby.Image")));
            this.btnRugby.Location = new System.Drawing.Point(607, 0);
            this.btnRugby.Name = "btnRugby";
            this.btnRugby.Size = new System.Drawing.Size(196, 184);
            this.btnRugby.TabIndex = 2;
            this.btnRugby.Text = "Rugby";
            this.btnRugby.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRugby.UseVisualStyleBackColor = true;
            this.btnRugby.Click += new System.EventHandler(this.btnRugby_Click);
            // 
            // btnCricket
            // 
            this.btnCricket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(191)))), ((int)(((byte)(245)))));
            this.btnCricket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCricket.FlatAppearance.BorderSize = 0;
            this.btnCricket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCricket.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCricket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCricket.Image = ((System.Drawing.Image)(resources.GetObject("btnCricket.Image")));
            this.btnCricket.Location = new System.Drawing.Point(405, 0);
            this.btnCricket.Name = "btnCricket";
            this.btnCricket.Size = new System.Drawing.Size(196, 184);
            this.btnCricket.TabIndex = 1;
            this.btnCricket.Text = "Cricket";
            this.btnCricket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCricket.UseVisualStyleBackColor = false;
            this.btnCricket.Click += new System.EventHandler(this.btnCricket_Click);
            // 
            // btnAussieRules
            // 
            this.btnAussieRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAussieRules.FlatAppearance.BorderSize = 0;
            this.btnAussieRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAussieRules.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAussieRules.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAussieRules.Image = ((System.Drawing.Image)(resources.GetObject("btnAussieRules.Image")));
            this.btnAussieRules.Location = new System.Drawing.Point(198, 0);
            this.btnAussieRules.Name = "btnAussieRules";
            this.btnAussieRules.Size = new System.Drawing.Size(212, 184);
            this.btnAussieRules.TabIndex = 0;
            this.btnAussieRules.Text = "Aussie Rules";
            this.btnAussieRules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAussieRules.UseVisualStyleBackColor = true;
            this.btnAussieRules.Click += new System.EventHandler(this.btnAussieRules_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(164)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.btnLinkedin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnGitHub);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 66);
            this.panel2.TabIndex = 5;
            // 
            // btnLinkedin
            // 
            this.btnLinkedin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLinkedin.BackgroundImage")));
            this.btnLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinkedin.FlatAppearance.BorderSize = 0;
            this.btnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedin.Location = new System.Drawing.Point(1108, 16);
            this.btnLinkedin.Name = "btnLinkedin";
            this.btnLinkedin.Size = new System.Drawing.Size(31, 30);
            this.btnLinkedin.TabIndex = 10;
            this.btnLinkedin.UseVisualStyleBackColor = true;
            this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sports App";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1143, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGitHub.BackgroundImage")));
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Location = new System.Drawing.Point(1059, 13);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(43, 36);
            this.btnGitHub.TabIndex = 9;
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAussieRules;
        private System.Windows.Forms.Button btnAmFoot;
        private System.Windows.Forms.Button btnMMA;
        private System.Windows.Forms.Button btnFoot;
        private System.Windows.Forms.Button btnRugby;
        private System.Windows.Forms.Button btnCricket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLinkedin;
        private System.Windows.Forms.Button btnGitHub;
    }
}

