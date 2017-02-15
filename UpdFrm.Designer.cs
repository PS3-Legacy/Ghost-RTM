namespace Ghost_RTM_By_BISOON
{
    partial class UpdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdFrm));
            this.iTalk_ThemeContainer1 = new iTalk.iTalk_ThemeContainer();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.prcLbl = new iTalk.iTalk_Label();
            this.tobyLbl = new iTalk.iTalk_Label();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.progBar);
            this.iTalk_ThemeContainer1.Controls.Add(this.prcLbl);
            this.iTalk_ThemeContainer1.Controls.Add(this.tobyLbl);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Sizable = true;
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(208, 134);
            this.iTalk_ThemeContainer1.SmartBounds = false;
            this.iTalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.iTalk_ThemeContainer1.TabIndex = 0;
            this.iTalk_ThemeContainer1.Text = "Download RTM";
            // 
            // progBar
            // 
            this.progBar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progBar.Location = new System.Drawing.Point(12, 31);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(169, 23);
            this.progBar.TabIndex = 3;
            // 
            // prcLbl
            // 
            this.prcLbl.AutoSize = true;
            this.prcLbl.BackColor = System.Drawing.Color.Transparent;
            this.prcLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.prcLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.prcLbl.Location = new System.Drawing.Point(26, 87);
            this.prcLbl.Name = "prcLbl";
            this.prcLbl.Size = new System.Drawing.Size(29, 19);
            this.prcLbl.TabIndex = 2;
            this.prcLbl.Text = "%0";
            // 
            // tobyLbl
            // 
            this.tobyLbl.AutoSize = true;
            this.tobyLbl.BackColor = System.Drawing.Color.Transparent;
            this.tobyLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tobyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.tobyLbl.Location = new System.Drawing.Point(8, 59);
            this.tobyLbl.Name = "tobyLbl";
            this.tobyLbl.Size = new System.Drawing.Size(83, 19);
            this.tobyLbl.TabIndex = 1;
            this.tobyLbl.Text = "Total size  :";
            // 
            // UpdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 134);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "UpdFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download RTM";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.UpdFrm_Load);
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.iTalk_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ThemeContainer iTalk_ThemeContainer1;
        private iTalk.iTalk_Label tobyLbl;
        private iTalk.iTalk_Label prcLbl;
        private System.Windows.Forms.ProgressBar progBar;
    }
}