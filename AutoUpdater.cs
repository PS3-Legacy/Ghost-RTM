using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Globalization;

namespace Ghost_RTM_By_BISOON
{
    class AutoUpdater
    {
        public static WebClient Wc = new WebClient();
        public static SaveFileDialog Sf = new SaveFileDialog();
        public static string UrlLink = "https://dl.dropboxusercontent.com/s/z0dpyijtu3xpzod/My_Ghost.txt";
        public static string Ver_In_Lbl;
        public static string[] GetInfo;

        public static void CheckForUpdates(string ToolVer)
        {
            try
            {
                GetInfo = Wc.DownloadString(UrlLink).Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                decimal NewupdNumer = decimal.Parse(GetInfo[0].Replace(".", ""), NumberStyles.Number);
                string Getinfo_0 = GetInfo[0];
                string newUpInMsg = Getinfo_0[0] + "." + Getinfo_0[2];
                Ver_In_Lbl = ToolVer[0] + "." + ToolVer[1];

                if (NewupdNumer > decimal.Parse(ToolVer) )
                {
                    if (MessageBox.Show("There is new update\nOld Ver " + Ver_In_Lbl + "\nnew ver  " + Getinfo_0 + "\n\nChangelog : \n" + GetInfo[1] + "\n\nWould You Like To Update ??", "Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Sf.Filter = "RAR File|*.rar";
                        Sf.FileName = "Ghost RTM " + Getinfo_0;
                        Sf.Title = "Ghost RTM By BISOON";
                        if (Sf.ShowDialog() == DialogResult.OK)
                        {
                            UpdFrm upd = new UpdFrm();
                            upd.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You Have Latest Version " + Ver_In_Lbl, "Updates", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
