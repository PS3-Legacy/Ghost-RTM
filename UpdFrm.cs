using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost_RTM_By_BISOON
{
    public partial class UpdFrm : Form
    {
        public UpdFrm()
        {
            InitializeComponent();
        }

        private void UpdFrm_Load(object sender, EventArgs e)
        {
            try
            {
                AutoUpdater.Wc.DownloadFileAsync(new Uri(AutoUpdater.GetInfo[2]), AutoUpdater.Sf.FileName);
                AutoUpdater.Wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                AutoUpdater.Wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            }
            catch
            {
                MessageBox.Show("There Was An Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            Environment.Exit(0);
        }

        void Wc_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            tobyLbl.Text = "Total Size  : " + e.TotalBytesToReceive.ToString() + " KB";
            prcLbl.Text = "% " + e.ProgressPercentage.ToString();
            progBar.Maximum = (int)e.TotalBytesToReceive;
            progBar.Value = (int)e.BytesReceived;
        }
    }
}
