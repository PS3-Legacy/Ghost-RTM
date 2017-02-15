using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost_RTM_By_BISOON
{
    public partial class Mainfrm : Form
    {
        string Tool = "10";
        public Mainfrm()
        {
            InitializeComponent();
            ToolTip tool = new ToolTip();
            tool.SetToolTip(antiBanBtn, "Before signing in Enable AntiBan");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           labelVer.Text = "Ver : " + Tool[0] + "." + Tool[1];
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            if (cexCh.Checked)
                PS3.CCAPI();
            if (dexCh.Checked)
                PS3.TMAPI();
            if (PS3.Connect())
            {
                MessageBox.Show("Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cant Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            if (PS3.Attach())
            {
                Ghost.AntiBan();
                RPC.Enable_RPC();
                nameBox.Text = Ghost.NonHostModz.GetName();
                clanBox.Text = Ghost.NonHostModz.GetClan();
            }

            else
            {
                MessageBox.Show("Can't Attach");
            }
        }
       void Delay(double Sec)
        {
            DateTime dt = DateTime.Now.AddSeconds(1.15740740740741E-05).AddSeconds(Sec);
            while (DateTime.Now < dt)
                Application.DoEvents();

            /*
             *  DateTime dateTime2 = DateTime.Now.AddSeconds(1.15740740740741E-05).AddSeconds(dblSecs);
             while (DateTime.Now < dateTime2)
                 Application.DoEvents();
             * */
        }
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            Ghost.AntiBan();
            MessageBox.Show("AntiBan Enabled");  
        }

        private void iTalk_Button_118_Click(object sender, EventArgs e)
        {
            if (prestigeCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Prestige, (int)prestigeNum.Value);
            }
            if (levelCh.Checked)
            {
                if (levelNum.Value == 1)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.Soldier1, new byte[] { 0xFF });
                }
                if (levelNum.Value == 2)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier2, new byte[] { 0xFF });
                }
                if (levelNum.Value == 3)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier3, new byte[] { 0xFF });
                }
                if (levelNum.Value == 4)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier4, new byte[] { 0xFF });
                }
                if (levelNum.Value == 5)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier5, new byte[] { 0xFF });
                }
                if (levelNum.Value == 6)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier6, new byte[] { 0xFF });
                }
                if (levelNum.Value == 7)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier7, new byte[] { 0xFF });
                }
                if (levelNum.Value == 8)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier8, new byte[] { 0xFF });
                }
                if (levelNum.Value == 9)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier9, new byte[] { 0xFF });
                }
                if (levelNum.Value == 10)
                {
                    PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier10, new byte[] { 0xFF });
                }
            }
            if (killsCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Kills, (int)killsNum.Value);
            }
            if (deathsCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Deaths, (int)deathNum.Value);
            }
            if (winsCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Wins, (int)winsNum.Value);
            }
            if (lossesCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Losses, (int)lossesNum.Value);
            }
            if (gplayedCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.GamesPlayed, (int)gplayedNum.Value);
            }
            if (tplayedCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.TimePlayed, (int)tplayedNum.Value);
            }
            if (hitsCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.Hits, (int)hitsNum.Value);
            }
            if (xpCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.XPSoldier, (int)xpNum.Value);
            }
            if(squadCh.Checked)
            {
                Ghost.Stats.MultiPlayer.SetStats(Ghost.Stats.MultiPlayer.StatsOffset.SquadPoints, (int)squadNum.Value);
            }
        }

        private void iTalk_Button_119_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.Soldier1, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier2, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier3, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier4, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier5, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier6, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier7, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier8, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier9, new byte[] { 0xFF });
            PS3.SetMemory(Ghost.Stats.MultiPlayer.SoldierOffset.soldier10, new byte[] { 0xFF });
        }

        private void iTalk_Button_120_Click(object sender, EventArgs e)
        {
            Ghost.Stats.MultiPlayer.UnlockAll();
        }

        private void iTalk_Button_121_Click(object sender, EventArgs e)
        {
            Func.Sv.UnlockTrophy.UnlockAllTrophies();
        }

        private void advCh_ToggledChanged()
        {
            if (advCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.AdvancedUAV, Ghost.NonHostModz.AllBytes.AdvancedUAV_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.AdvancedUAV, Ghost.NonHostModz.AllBytes.AdvancedUAV_Off);
            }
        }

        private void laserCh_ToggledChanged()
        {
            if (laserCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.Laser, Ghost.NonHostModz.AllBytes.Laser_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.Laser, Ghost.NonHostModz.AllBytes.Laser_Off);
            }
        }

        private void nocrosshairCh_ToggledChanged()
        {
            if (nocrosshairCh.Toggled)
            {
                Func.Cbuf_AddText(0, "cg_drawCrosshair 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "cg_drawCrosshair 1");
            }
        }

        private void norecoilCh_ToggledChanged()
        {
            if (norecoilCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.NoRecoil, Ghost.NonHostModz.AllBytes.NoRecoil_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.NoRecoil, Ghost.NonHostModz.AllBytes.NoRecoil_Off);
            }
        }

        private void redboxCh_ToggledChanged()
        {
            if (redboxCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.RedBoxes, Ghost.NonHostModz.AllBytes.RedBox_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.RedBoxes, Ghost.NonHostModz.AllBytes.RedBox_Off);
            }
        }

        private void thirdCh_ToggledChanged()
        {
            if (thirdCh.Toggled)
            {
                Func.Cbuf_AddText(0, "camera_thirdPerson 1");
            }
            else
            {
                Func.Cbuf_AddText(0, "camera_thirdPerson 0");
            }
        }

        private void chromeCh_ToggledChanged()
        {
            if (chromeCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.ChromePlayer, Ghost.NonHostModz.AllBytes.ChromePlayer_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.ChromePlayer, Ghost.NonHostModz.AllBytes.ChromePlayer_Off);
            }
        }

        private void bignameCh_ToggledChanged()
        {
            if (bignameCh.Toggled)
            {
                Func.Cbuf_AddText(0, "cg_overheadNamesSize 3");
                Func.Cbuf_AddText(0, "cg_overheadNamesFarScale 2");
                Func.Cbuf_AddText(0, "cg_overheadRankSize 1.2");
                Func.Cbuf_AddText(0, "cg_overheadIconSize 3");
            }
            else
            {
                Func.Cbuf_AddText(0, "cg_overheadNamesSize 1");
                Func.Cbuf_AddText(0, "cg_overheadNamesFarScale 1");
                Func.Cbuf_AddText(0, "cg_overheadRankSize 1");
                Func.Cbuf_AddText(0, "cg_overheadIconSize 1");
            }
        }

        private void disableHUDCh_ToggledChanged()
        {
            if (disableHUDCh.Toggled)
            {
                Func.Cbuf_AddText(0, "cg_draw2D 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "cg_draw2D 1");
            }
        }

        private void weirdshowCh_ToggledChanged()
        {
            if (weirdshowCh.Toggled)
            {
                Func.Cbuf_AddText(0, "set r_subwindow 0 1 0 2");
            }
            else
            {
                Func.Cbuf_AddText(0, "set r_subwindow 0 1 0 1");
            }
        }

        private void disableshadowCh_ToggledChanged()
        {
            if (disableshadowCh.Toggled)
            {
                Func.Cbuf_AddText(0, "sm_enable 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "sm_enable 1");
            }
        }

        private void disableFxCh_ToggledChanged()
        {
            if (disableFxCh.Toggled)
            {
                Func.Cbuf_AddText(0, "fx_enable 0");
                Func.Cbuf_AddText(0, "fx_draw 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "fx_enable 1");
                Func.Cbuf_AddText(0, "fx_draw 1");
            }
        }

        private void floatingbodiesCh_ToggledChanged()
        {
            if (floatingbodiesCh.Toggled)
            {
                Func.Cbuf_AddText(0, "phys_gravity_ragdoll 1");
            }
            else
            {
                Func.Cbuf_AddText(0, "phys_gravity_ragdoll 0");
            }
        }

        private void steadyAimCh_ToggledChanged()
        {
            if (steadyAimCh.Toggled)
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.SteadyAim, Ghost.NonHostModz.AllBytes.SteadyAim_On);
            }
            else
            {
                Ghost.NonHostModz.NonHost_Modz(Ghost.NonHostModz.NonHoastOffsets.SteadyAim, Ghost.NonHostModz.AllBytes.SteadyAim_Off);
            }
        }

        private void invisibleweapCh_ToggledChanged()
        {
            if (invisibleweapCh.Toggled)
            {
                Func.Cbuf_AddText(0, "cg_drawGun 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "cg_drawGun 1");
            }
        }

        private void blackHoleCh_ToggledChanged()
        {
            if (blackHoleCh.Toggled)
            {
                Func.Cbuf_AddText(0, "r_singleCell 1");
            }
            else
            {
                Func.Cbuf_AddText(0, "r_singleCell 0");
            }
        }

        private void uavHardCoreCh_ToggledChanged()
        {
            if (uavHardCoreCh.Toggled)
            {
                Func.Cbuf_AddText(0, "g_hardcore 0");
            }
            else
            {
                Func.Cbuf_AddText(0, "g_hardcore 1");
            }
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            miniMapSizeNum.Value = 0;
            Func.Cbuf_AddText(0, "reset compassSize");
        }

        private void iTalk_Button_13_Click(object sender, EventArgs e)
        {
            compassSizeNum.Value = 0;
            Func.Cbuf_AddText(0, "reset compassMaxRange");
        }

        private void iTalk_Button_15_Click(object sender, EventArgs e)
        {
            brightnessNum.Value = 0;
            Func.Cbuf_AddText(0, "reset r_specularmap");
            Func.Cbuf_AddText(0, "reset r_specularcolorscale");
        }

        private void yNum_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "cg_gun_y " + yNum.Value);
        }

        private void xNum_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "cg_gun_x " + xNum.Value);
        }

        private void zNum_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "cg_gun_z " + zNum.Value);
        }

        private void fovNum_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "cg_fov " + fovNum.Value);
        }

        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "reset cg_fov");
            Func.Cbuf_AddText(0, "reset cg_fovScale");
            Func.Cbuf_AddText(0, "reset cg_gun_x");
            Func.Cbuf_AddText(0, "reset cg_gun_y");
            Func.Cbuf_AddText(0, "reset cg_gun_z");
            fovNum.Value = 0;
            xNum.Value = 0;
            yNum.Value = 0;
            zNum.Value = 0;
        }

        private void iTalk_Button_16_Click(object sender, EventArgs e)
        {
            Ghost.NonHostModz.PlayerColor_Modz(Ghost.NonHostModz.AllBytes.Color_Index[bodyCombo.SelectedIndex]);
        }

        private void iTalk_Button_17_Click(object sender, EventArgs e)
        {
            if (visionCombo.SelectedIndex == 0)//fixed
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");
            }
            if (visionCombo.SelectedIndex == 1)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_brightness -.2");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
            }
            if (visionCombo.SelectedItem.ToString() == "Blue And Purple")
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmTweakInvert 1");
                Func.Cbuf_AddText(0, "r_brightness -.2");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmTweakenable 1");
                Func.Cbuf_AddText(0, "r_filmtweakLighttint 1 2 0");
                Func.Cbuf_AddText(0, "r_filmtweakdarktint 1 2 1;");
            }
            if (visionCombo.SelectedIndex == 2)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                //r_filmTweakLightTint 2 - infection
                Func.Cbuf_AddText(0, "r_filmTweakInvert 0");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmTweakenable 1");
                Func.Cbuf_AddText(0, "r_filmtweakLighttint 1 2 1");
                Func.Cbuf_AddText(0, "r_filmtweakdarktint 1 2 1");
            }
            if (visionCombo.SelectedIndex == 3)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmTweakLightTint 1 1 0");
                Func.Cbuf_AddText(0, "r_filmTweakContrast 1.4");
                Func.Cbuf_AddText(0, "r_filmtweakenable 1");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmtweakinvert 1");
            }

            if (visionCombo.SelectedIndex == 4)
            {//r_filmTweakLightTint 1 0 0 chapelin
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmtweakenable 1");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmtweakinvert 1");
                Func.Cbuf_AddText(0, "r_filmTweakContrast 1.4");
            }

            if (visionCombo.SelectedIndex == 5)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                //r_filmTweakLightTint 2 - infection
                Func.Cbuf_AddText(0, "r_filmTweakInvert 0");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmTweakenable 1");
                Func.Cbuf_AddText(0, "r_filmtweakdarktint 1 2 1");
                Func.Cbuf_AddText(0, "r_filmTweakLightTint 2");
            }

            if (visionCombo.SelectedIndex == 6)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmTweakInvert 1");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmTweakenable 1");
                Func.Cbuf_AddText(0, "r_filmtweakLighttint 1 2 1");
                Func.Cbuf_AddText(0, "r_filmtweakdarktint 1 2 1");
                Func.Cbuf_AddText(0, "r_filmTweakContrast 1.4");
            }

            if (visionCombo.SelectedIndex == 7)//its inverted need to fix
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmtweakenable 1 0");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1 0");
            }

            if (visionCombo.SelectedIndex == 8)//fixed
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmtweakenable 1");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmtweakinvert 1");
                Func.Cbuf_AddText(0, "r_filmTweakLightTint 1 0 0");
                Func.Cbuf_AddText(0, "r_filmTweakContrast 1.4");
            }

            if (visionCombo.SelectedIndex == 9)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_singleCell 1");
            }

            if (visionCombo.SelectedIndex == 10)//fixed
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmTweakInvert 0");
                Func.Cbuf_AddText(0, "r_filmTweakbrightness 2");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmTweakenable 1");
                Func.Cbuf_AddText(0, "r_filmtweakLighttint 1.06 0.5 1.3");
            }

            if (visionCombo.SelectedIndex == 11)
            {
                Func.Cbuf_AddText(0, "reset r_filmtweakdarktint");
                Func.Cbuf_AddText(0, "reset r_singleCell");
                Func.Cbuf_AddText(0, "reset r_filmTweakInvert");
                Func.Cbuf_AddText(0, "reset r_filmTweakbrightness");
                Func.Cbuf_AddText(0, "reset r_filmusetweaks");
                Func.Cbuf_AddText(0, "reset r_filmTweakenable");
                Func.Cbuf_AddText(0, "reset r_filmtweakLighttint");
                Func.Cbuf_AddText(0, "reset r_filmTweakContrast");
                Func.Cbuf_AddText(0, "reset r_brightness");

                Func.Cbuf_AddText(0, "r_filmTweakContrast 3");
                Func.Cbuf_AddText(0, "r_filmtweakenable 1");
                Func.Cbuf_AddText(0, "r_filmusetweaks 1");
                Func.Cbuf_AddText(0, "r_filmtweakinvert 1");
            }
        }

        private void speedTrack_ValueChanged()
        {
            if (speedTrack.Value == 0)
            {
                Ghost.LobbyModz.SpeedLobby(Ghost.LobbyModz.AllBytes.SpeedLevel.Normal);
            }
            if (speedTrack.Value == 1)
            {
                Ghost.LobbyModz.SpeedLobby(Ghost.LobbyModz.AllBytes.SpeedLevel.Fast);
            }
            if (speedTrack.Value == 2)
            {
                Ghost.LobbyModz.SpeedLobby(Ghost.LobbyModz.AllBytes.SpeedLevel.SuperFast);
            }
        }

        private void jumpTrack_ValueChanged()
        {
            if (jumpTrack.Value == 0)
            {
                Ghost.LobbyModz.LobbyJump(Ghost.LobbyModz.AllBytes.JumpLevel.Normal);
            }
            if (jumpTrack.Value == 1)
            {
                Ghost.LobbyModz.LobbyJump(Ghost.LobbyModz.AllBytes.JumpLevel.High);
            }
            if (jumpTrack.Value == 2)
            {
                Ghost.LobbyModz.LobbyJump(Ghost.LobbyModz.AllBytes.JumpLevel.SuperHigh);
            }
        }

        private void timeScaleTrack_ValueChanged()
        {
            if (timeScaleTrack.Value == 0)
            {
                Func.Cbuf_AddText(0, "reset fixedtime");
            }
            else
            {
                Func.Cbuf_AddText(0, "set fixedtime " + timeScaleTrack.Value);
            }
            timescaleLbl.Text = timeScaleTrack.Value.ToString();
        }

        private void knockTrack_ValueChanged()
        {
            if (knockTrack.Value == 0)
            {
                Func.Cbuf_AddText(0, "reset g_knockback");
            }
            else
            {
                Func.Cbuf_AddText(0, "set g_knockback  " + knockTrack.Value);
            }
            knockLbl.Text = knockTrack.Value.ToString();
        }

        private void iTalk_Button_113_Click(object sender, EventArgs e)
        {
            Func.Sv.UnlockTrophy.UnlockAllTrophies();
        }

        private void antiJoinCh_ToggledChanged()
        {
            if(antiJoinCh.Toggled)
            {
                Ghost.LobbyModz.Antijoin(true);
            }
            else
            {
                Ghost.LobbyModz.Antijoin(false);
            }
        }

        private void timelimitBtn_Click(object sender, EventArgs e)
        {
            Ghost.LobbyModz.TimeLimit((int)timeLimitNum.Value);
        }

        private void scorelimitBtn_Click(object sender, EventArgs e)
        {
            Ghost.LobbyModz.ScoreLimit((int)scoreLimitNum.Value);
        }

        private void iTalk_Button_112_Click(object sender, EventArgs e)
        {
            Ghost.LobbyModz.LiveNum((int)liveNum.Value);
        }

        private void scoreperkillBtn_Click(object sender, EventArgs e)
        {
            Ghost.LobbyModz.ScorePerKill((int)scorePerKillNum.Value);
        }

        private void scorepersuicideBtn_Click(object sender, EventArgs e)
        {
            Ghost.LobbyModz.ScorePerSuicide((int)scorePerSuicide.Value);
        }

        private void promodeBtn_Click(object sender, EventArgs e)
        {
            Func.Sv.Fov(-1, (int)proModNum.Value);
        }

        private void promodResetBtn_Click(object sender, EventArgs e)
        {
            Func.Sv.Fov(-1, 65);
        }
        //Client
        private void iTalk_CheckBox18_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox18.Checked)
            {
                Ghost.G_Client.GodMode(0, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(0, "Off");
            }
        }

        private void iTalk_CheckBox19_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox19.Checked)
            {
                Ghost.G_Client.GodMode(1, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(1, "Off");
            }
        }

        private void iTalk_CheckBox20_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox20.Checked)
            {
                Ghost.G_Client.GodMode(2, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(2, "Off");
            }
        }

        private void iTalk_CheckBox21_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox21.Checked)
            {
                Ghost.G_Client.GodMode(3, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(3, "Off");
            }
        }

        private void iTalk_CheckBox22_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox22.Checked)
            {
                Ghost.G_Client.GodMode(4, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(4, "Off");
            }
        }

        private void iTalk_CheckBox23_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox23.Checked)
            {
                Ghost.G_Client.GodMode(5, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(5, "Off");
            }
        }

        private void iTalk_CheckBox24_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox24.Checked)
            {
                Ghost.G_Client.GodMode(6, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(6, "Off");
            }
        }

        private void iTalk_CheckBox25_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox25.Checked)
            {
                Ghost.G_Client.GodMode(7, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(7, "Off");
            }
        }

        private void iTalk_CheckBox26_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox26.Checked)
            {
                Ghost.G_Client.GodMode(8, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(8, "Off");
            }
        }

        private void iTalk_CheckBox27_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox27.Checked)
            {
                Ghost.G_Client.GodMode(9, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(9, "Off");
            }
        }

        private void iTalk_CheckBox28_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox28.Checked)
            {
                Ghost.G_Client.GodMode(10, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(10, "Off");
            }
        }

        private void iTalk_CheckBox29_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox29.Checked)
            {
                Ghost.G_Client.GodMode(11, "On");
            }
            else
            {
                Ghost.G_Client.GodMode(11, "Off");
            }
        }
        //all godmode
        private void iTalk_CheckBox126_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox126.Checked)
            {
                iTalk_CheckBox18.Checked = true;
                iTalk_CheckBox19.Checked = true;
                iTalk_CheckBox20.Checked = true;
                iTalk_CheckBox21.Checked = true;
                iTalk_CheckBox22.Checked = true;
                iTalk_CheckBox23.Checked = true;
                iTalk_CheckBox24.Checked = true;
                iTalk_CheckBox25.Checked = true;
                iTalk_CheckBox26.Checked = true;
                iTalk_CheckBox27.Checked = true;
                iTalk_CheckBox28.Checked = true;
                iTalk_CheckBox29.Checked = true;
            }
            else
            {
                iTalk_CheckBox18.Checked = false;
                iTalk_CheckBox19.Checked = false;
                iTalk_CheckBox20.Checked = false;
                iTalk_CheckBox21.Checked = false;
                iTalk_CheckBox22.Checked = false;
                iTalk_CheckBox23.Checked = false;
                iTalk_CheckBox24.Checked = false;
                iTalk_CheckBox25.Checked = false;
                iTalk_CheckBox26.Checked = false;
                iTalk_CheckBox27.Checked = false;
                iTalk_CheckBox28.Checked = false;
                iTalk_CheckBox29.Checked = false;
            }
        }

        private void iTalk_CheckBox41_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox41.Checked)
            {
                Ghost.G_Client.GiveAmmo(0);
            }
        }

        private void iTalk_CheckBox40_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox40.Checked)
            {
                Ghost.G_Client.GiveAmmo(1);
            }
        }

        private void iTalk_CheckBox39_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox39.Checked)
            {
                Ghost.G_Client.GiveAmmo(2);
            }
        }

        private void iTalk_CheckBox38_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox38.Checked)
            {
                Ghost.G_Client.GiveAmmo(3);
            }
        }

        private void iTalk_CheckBox37_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox37.Checked)
            {
                Ghost.G_Client.GiveAmmo(4);
            }
        }

        private void iTalk_CheckBox36_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox36.Checked)
            {
                Ghost.G_Client.GiveAmmo(5);
            }
        }

        private void iTalk_CheckBox35_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox35.Checked)
            {
                Ghost.G_Client.GiveAmmo(6);
            }
        }

        private void iTalk_CheckBox34_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox34.Checked)
            {
                Ghost.G_Client.GiveAmmo(7);
            }
        }

        private void iTalk_CheckBox33_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox33.Checked)
            {
                Ghost.G_Client.GiveAmmo(8);
            }
        }

        private void iTalk_CheckBox32_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox32.Checked)
            {
                Ghost.G_Client.GiveAmmo(9);
            }
        }

        private void iTalk_CheckBox31_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox31.Checked)
            {
                Ghost.G_Client.GiveAmmo(10);
            }
        }

        private void iTalk_CheckBox30_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox30.Checked)
            {
                Ghost.G_Client.GiveAmmo(11);
            }
        }

        private void iTalk_CheckBox127_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox127.Checked)
            {
                iTalk_CheckBox41.Checked = true;
                iTalk_CheckBox40.Checked = true;
                iTalk_CheckBox39.Checked = true;
                iTalk_CheckBox38.Checked = true;
                iTalk_CheckBox37.Checked = true;
                iTalk_CheckBox36.Checked = true;
                iTalk_CheckBox35.Checked = true;
                iTalk_CheckBox34.Checked = true;
                iTalk_CheckBox33.Checked = true;
                iTalk_CheckBox32.Checked = true;
                iTalk_CheckBox31.Checked = true;
                iTalk_CheckBox30.Checked = true;
            }
            else
            {
                iTalk_CheckBox41.Checked = false;
                iTalk_CheckBox40.Checked = false;
                iTalk_CheckBox39.Checked = false;
                iTalk_CheckBox38.Checked = false;
                iTalk_CheckBox37.Checked = false;
                iTalk_CheckBox36.Checked = false;
                iTalk_CheckBox35.Checked = false;
                iTalk_CheckBox34.Checked = false;
                iTalk_CheckBox33.Checked = false;
                iTalk_CheckBox32.Checked = false;
                iTalk_CheckBox31.Checked = false;
                iTalk_CheckBox30.Checked = false;
            }
        }

        private void iTalk_Button_116_Click(object sender, EventArgs e)
        {
            textBox2.Text = Ghost.G_Client.GetClientName(0);
            textBox3.Text = Ghost.G_Client.GetClientName(1);
            textBox4.Text = Ghost.G_Client.GetClientName(2);
            textBox5.Text = Ghost.G_Client.GetClientName(3);
            textBox6.Text = Ghost.G_Client.GetClientName(4);
            textBox7.Text = Ghost.G_Client.GetClientName(5);
            textBox8.Text = Ghost.G_Client.GetClientName(6);
            textBox9.Text = Ghost.G_Client.GetClientName(7);
            textBox10.Text = Ghost.G_Client.GetClientName(8);
            textBox11.Text = Ghost.G_Client.GetClientName(9);
            textBox12.Text = Ghost.G_Client.GetClientName(10);
            textBox13.Text = Ghost.G_Client.GetClientName(11);
            textBox23.Text = Ghost.G_Client.GetClientName(0);
            textBox25.Text = Ghost.G_Client.GetClientName(1);
            textBox24.Text = Ghost.G_Client.GetClientName(2);
            textBox22.Text = Ghost.G_Client.GetClientName(3);
            textBox21.Text = Ghost.G_Client.GetClientName(4);
            textBox20.Text = Ghost.G_Client.GetClientName(5);
            textBox19.Text = Ghost.G_Client.GetClientName(6);
            textBox18.Text = Ghost.G_Client.GetClientName(7);
            textBox17.Text = Ghost.G_Client.GetClientName(8);
            textBox16.Text = Ghost.G_Client.GetClientName(9);
            textBox15.Text = Ghost.G_Client.GetClientName(10);
            textBox14.Text = Ghost.G_Client.GetClientName(11);
            textBox35.Text = Ghost.G_Client.GetClientName(0);
            textBox37.Text = Ghost.G_Client.GetClientName(1);
            textBox36.Text = Ghost.G_Client.GetClientName(2);
            textBox34.Text = Ghost.G_Client.GetClientName(3);
            textBox33.Text = Ghost.G_Client.GetClientName(4);
            textBox32.Text = Ghost.G_Client.GetClientName(5);
            textBox31.Text = Ghost.G_Client.GetClientName(6);
            textBox30.Text = Ghost.G_Client.GetClientName(7);
            textBox29.Text = Ghost.G_Client.GetClientName(8);
            textBox28.Text = Ghost.G_Client.GetClientName(9);
            textBox27.Text = Ghost.G_Client.GetClientName(10);
            textBox26.Text = Ghost.G_Client.GetClientName(11);
            textBox47.Text = Ghost.G_Client.GetClientName(0);
            textBox49.Text = Ghost.G_Client.GetClientName(1);
            textBox48.Text = Ghost.G_Client.GetClientName(2);
            textBox46.Text = Ghost.G_Client.GetClientName(3);
            textBox45.Text = Ghost.G_Client.GetClientName(4);
            textBox44.Text = Ghost.G_Client.GetClientName(5);
            textBox43.Text = Ghost.G_Client.GetClientName(6);
            textBox42.Text = Ghost.G_Client.GetClientName(7);
            textBox41.Text = Ghost.G_Client.GetClientName(8);
            textBox40.Text = Ghost.G_Client.GetClientName(9);
            textBox39.Text = Ghost.G_Client.GetClientName(10);
            textBox38.Text = Ghost.G_Client.GetClientName(11);
        }

        private void iTalk_CheckBox53_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox53.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 0, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 0, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox52_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox52.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 1, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 1, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox51_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox51.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 2, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 2, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox50_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox50.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 3, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 3, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox49_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox49.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 4, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 4, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox48_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox48.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 5, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 5, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox47_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox47.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 6, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 6, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox46_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox46.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 7, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 7, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox45_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox45.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 8, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 8, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox44_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox44.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 9, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 9, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox43_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox43.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 10, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 10, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox42_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox42.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 11, Ghost.G_Client.AllBytes.UAVOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.UAV, 11, Ghost.G_Client.AllBytes.UAVOff);
            }
        }

        private void iTalk_CheckBox128_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox128.Checked)
            {
                iTalk_CheckBox53.Checked = true;
                iTalk_CheckBox52.Checked = true;
                iTalk_CheckBox51.Checked = true;
                iTalk_CheckBox50.Checked = true;
                iTalk_CheckBox49.Checked = true;
                iTalk_CheckBox48.Checked = true;
                iTalk_CheckBox47.Checked = true;
                iTalk_CheckBox46.Checked = true;
                iTalk_CheckBox45.Checked = true;
                iTalk_CheckBox44.Checked = true;
                iTalk_CheckBox43.Checked = true;
                iTalk_CheckBox42.Checked = true;
            }
            else
            {
                iTalk_CheckBox53.Checked = false;
                iTalk_CheckBox52.Checked = false;
                iTalk_CheckBox51.Checked = false;
                iTalk_CheckBox50.Checked = false;
                iTalk_CheckBox49.Checked = false;
                iTalk_CheckBox48.Checked = false;
                iTalk_CheckBox47.Checked = false;
                iTalk_CheckBox46.Checked = false;
                iTalk_CheckBox45.Checked = false;
                iTalk_CheckBox44.Checked = false;
                iTalk_CheckBox43.Checked = false;
                iTalk_CheckBox42.Checked = false;
            }
        }
        //redbox
        private void iTalk_CheckBox65_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox65.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 0, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 0, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox64_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox64.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 1, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 1, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox63_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox63.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 2, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 2, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox62_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox62.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 3, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 3, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox61_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox61.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 4, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 4, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox60_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox60.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 5, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 5, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox59_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox59.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 6, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 6, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox58_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox58.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 7, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 7, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox57_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox57.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 8, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 8, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox56_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox56.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 9, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 9, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox55_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox55.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 10, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 10, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox54_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox54.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 11, Ghost.G_Client.AllBytes.RedBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.RedBox, 11, Ghost.G_Client.AllBytes.RedBoxOff);
            }
        }

        private void iTalk_CheckBox129_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox129.Checked)
            {
                iTalk_CheckBox65.Checked = true;
                iTalk_CheckBox64.Checked = true;
                iTalk_CheckBox63.Checked = true;
                iTalk_CheckBox62.Checked = true;
                iTalk_CheckBox61.Checked = true;
                iTalk_CheckBox60.Checked = true;
                iTalk_CheckBox59.Checked = true;
                iTalk_CheckBox58.Checked = true;
                iTalk_CheckBox57.Checked = true;
                iTalk_CheckBox56.Checked = true;
                iTalk_CheckBox55.Checked = true;
                iTalk_CheckBox54.Checked = true;
            }
            else
            {
                iTalk_CheckBox65.Checked = false;
                iTalk_CheckBox64.Checked = false;
                iTalk_CheckBox63.Checked = false;
                iTalk_CheckBox62.Checked = false;
                iTalk_CheckBox61.Checked = false;
                iTalk_CheckBox60.Checked = false;
                iTalk_CheckBox59.Checked = false;
                iTalk_CheckBox58.Checked = false;
                iTalk_CheckBox57.Checked = false;
                iTalk_CheckBox56.Checked = false;
                iTalk_CheckBox55.Checked = false;
                iTalk_CheckBox54.Checked = false;
            }
        }

        private void iTalk_CheckBox77_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox77.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 0, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 0, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox76_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox76.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 1, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 1, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox75_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox75.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 2, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 2, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox74_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox74.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 3, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 3, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox73_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox73.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 4, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 4, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox72_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox72.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 5, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 5, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox71_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox71.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 6, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 6, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox70_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox70.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 7, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 7, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox69_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox69.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 8, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 8, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox68_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox78.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 9, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 9, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox67_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox67.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 10, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 10, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }

        private void iTalk_CheckBox66_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox66.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 11, Ghost.G_Client.AllBytes.Speed_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.PlayerSpeed, 11, Ghost.G_Client.AllBytes.Speed_Off);
            }
        }
       
        private void iTalk_CheckBox130_CheckedChanged(object sender)
        {
            
            if (iTalk_CheckBox130.Checked)
            {
                iTalk_CheckBox77.Checked = true;
                iTalk_CheckBox76.Checked = true;
                iTalk_CheckBox75.Checked = true;
                iTalk_CheckBox74.Checked = true;
                iTalk_CheckBox73.Checked = true;
                iTalk_CheckBox72.Checked = true;
                iTalk_CheckBox71.Checked = true;
                iTalk_CheckBox70.Checked = true;
                iTalk_CheckBox69.Checked = true;
                iTalk_CheckBox68.Checked = true;
                iTalk_CheckBox67.Checked = true;
                iTalk_CheckBox66.Checked = true;
            }
            else
            {
                iTalk_CheckBox77.Checked = false;
                iTalk_CheckBox76.Checked = false;
                iTalk_CheckBox75.Checked = false;
                iTalk_CheckBox74.Checked = false;
                iTalk_CheckBox73.Checked = false;
                iTalk_CheckBox72.Checked = false;
                iTalk_CheckBox71.Checked = false;
                iTalk_CheckBox70.Checked = false;
                iTalk_CheckBox69.Checked = false;
                iTalk_CheckBox68.Checked = false;
                iTalk_CheckBox67.Checked = false;
                iTalk_CheckBox66.Checked = false;
            }
        }

        private void iTalk_CheckBox89_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox89.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 0, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 0, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox88_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox88.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 1, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 1, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox87_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox87.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 2, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 2, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox86_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox86.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 3, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 3, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox85_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox85.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 4, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 4, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox84_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox84.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 5, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 5, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox83_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox83.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 6, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 6, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox82_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox82.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 7, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 7, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox81_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox81.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 8, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 8, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox80_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox80.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 9, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 9, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox79_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox79.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 10, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 10, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox78_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox78.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 11, Ghost.G_Client.AllBytes.NoClip_On);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 11, Ghost.G_Client.AllBytes.NoClip_Off);
            }
        }

        private void iTalk_CheckBox131_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox131.Checked)
            {
                iTalk_CheckBox89.Checked = true;
                iTalk_CheckBox88.Checked = true;
                iTalk_CheckBox87.Checked = true;
                iTalk_CheckBox86.Checked = true;
                iTalk_CheckBox85.Checked = true;
                iTalk_CheckBox84.Checked = true;
                iTalk_CheckBox83.Checked = true;
                iTalk_CheckBox82.Checked = true;
                iTalk_CheckBox81.Checked = true;
                iTalk_CheckBox80.Checked = true;
                iTalk_CheckBox79.Checked = true;
                iTalk_CheckBox78.Checked = true;
            }
            else
            {
                iTalk_CheckBox89.Checked = false;
                iTalk_CheckBox88.Checked = false;
                iTalk_CheckBox87.Checked = false;
                iTalk_CheckBox86.Checked = false;
                iTalk_CheckBox85.Checked = false;
                iTalk_CheckBox84.Checked = false;
                iTalk_CheckBox83.Checked = false;
                iTalk_CheckBox82.Checked = false;
                iTalk_CheckBox81.Checked = false;
                iTalk_CheckBox80.Checked = false;
                iTalk_CheckBox79.Checked = false;
                iTalk_CheckBox78.Checked = false;
            }
        }

        private void iTalk_CheckBox101_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox101.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 0, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 0, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox100_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox100.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 1, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 1, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox99_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox99.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 2, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 2, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox98_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox98.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 3, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 3, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox97_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox97.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 4, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 4, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox96_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox96.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 5, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 5, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox95_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox95.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 6, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 6, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox94_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox94.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 7, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 7, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox93_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox93.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 8, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 8, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox92_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox92.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 9, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 9, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox91_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox91.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 10, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 10, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox90_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox90.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 11, Ghost.G_Client.AllBytes.FreezeOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.mflag, 11, Ghost.G_Client.AllBytes.FreezeOff);
            }
        }

        private void iTalk_CheckBox132_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox132.Checked)
            {
                iTalk_CheckBox101.Checked = true;
                iTalk_CheckBox100.Checked = true;
                iTalk_CheckBox99.Checked = true;
                iTalk_CheckBox98.Checked = true;
                iTalk_CheckBox97.Checked = true;
                iTalk_CheckBox96.Checked = true;
                iTalk_CheckBox95.Checked = true;
                iTalk_CheckBox94.Checked = true;
                iTalk_CheckBox93.Checked = true;
                iTalk_CheckBox92.Checked = true;
                iTalk_CheckBox91.Checked = true;
                iTalk_CheckBox90.Checked = true;
            }
            else
            {
                iTalk_CheckBox101.Checked = false;
                iTalk_CheckBox100.Checked = false;
                iTalk_CheckBox99.Checked = false;
                iTalk_CheckBox98.Checked = false;
                iTalk_CheckBox97.Checked = false;
                iTalk_CheckBox96.Checked = false;
                iTalk_CheckBox95.Checked = false;
                iTalk_CheckBox94.Checked = false;
                iTalk_CheckBox93.Checked = false;
                iTalk_CheckBox92.Checked = false;
                iTalk_CheckBox91.Checked = false;
                iTalk_CheckBox90.Checked = false;
            }
        }

        private void iTalk_CheckBox113_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox113.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 0, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 0, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox112_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox112.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 1, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 1, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox111_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox111.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 2, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 2, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox110_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox110.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 3, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 3, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox109_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox109.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 4, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 4, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox108_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox108.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 5, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 5, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox107_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox107.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 6, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 6, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox106_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox106.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 7, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 7, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox105_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox105.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 8, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 8, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox104_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox104.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 9, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 9, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox103_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox103.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 10, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 10, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox102_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox102.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 11, Ghost.G_Client.AllBytes.GreenCheckBoxOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GreenCheckBox, 11, Ghost.G_Client.AllBytes.GreenCheckBoxOff);
            }
        }

        private void iTalk_CheckBox133_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox133.Checked)
            {
                iTalk_CheckBox113.Checked = true;
                iTalk_CheckBox112.Checked = true;
                iTalk_CheckBox111.Checked = true;
                iTalk_CheckBox110.Checked = true;
                iTalk_CheckBox109.Checked = true;
                iTalk_CheckBox108.Checked = true;
                iTalk_CheckBox107.Checked = true;
                iTalk_CheckBox106.Checked = true;
                iTalk_CheckBox105.Checked = true;
                iTalk_CheckBox104.Checked = true;
                iTalk_CheckBox103.Checked = true;
                iTalk_CheckBox102.Checked = true;
            }
            else
            {
                iTalk_CheckBox113.Checked = false;
                iTalk_CheckBox112.Checked = false;
                iTalk_CheckBox111.Checked = false;
                iTalk_CheckBox110.Checked = false;
                iTalk_CheckBox109.Checked = false;
                iTalk_CheckBox108.Checked = false;
                iTalk_CheckBox107.Checked = false;
                iTalk_CheckBox106.Checked = false;
                iTalk_CheckBox105.Checked = false;
                iTalk_CheckBox104.Checked = false;
                iTalk_CheckBox103.Checked = false;
                iTalk_CheckBox102.Checked = false;
            }
        }

        private void iTalk_CheckBox125_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox125.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 0, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 0, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox124_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox124.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 1, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 1, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox123_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox123.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 2, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 2, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox122_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox122.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 3, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 3, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox121_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox121.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 4, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 4, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox120_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox120.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 5, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 5, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox119_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox119.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 6, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 6, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox118_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox118.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 7, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 7, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox117_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox117.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 8, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 8, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox116_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox116.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 9, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 9, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox115_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox115.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 10, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 10, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox114_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox114.Checked)
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 11, Ghost.G_Client.AllBytes.GiveLagOn);
            }
            else
            {
                Ghost.G_Client.ClientModz(Ghost.G_Client.ClientOffset.GiveLag, 11, Ghost.G_Client.AllBytes.GiveLagOff);
            }
        }

        private void iTalk_CheckBox134_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox134.Checked)
            {
                iTalk_CheckBox125.Checked = true;
                iTalk_CheckBox124.Checked = true;
                iTalk_CheckBox123.Checked = true;
                iTalk_CheckBox122.Checked = true;
                iTalk_CheckBox121.Checked = true;
                iTalk_CheckBox120.Checked = true;
                iTalk_CheckBox119.Checked = true;
                iTalk_CheckBox118.Checked = true;
                iTalk_CheckBox117.Checked = true;
                iTalk_CheckBox116.Checked = true;
                iTalk_CheckBox115.Checked = true;
                iTalk_CheckBox114.Checked = true;
            }
            else
            {
                iTalk_CheckBox125.Checked = false;
                iTalk_CheckBox124.Checked = false;
                iTalk_CheckBox123.Checked = false;
                iTalk_CheckBox122.Checked = false;
                iTalk_CheckBox121.Checked = false;
                iTalk_CheckBox120.Checked = false;
                iTalk_CheckBox119.Checked = false;
                iTalk_CheckBox118.Checked = false;
                iTalk_CheckBox117.Checked = false;
                iTalk_CheckBox116.Checked = false;
                iTalk_CheckBox115.Checked = false;
                iTalk_CheckBox114.Checked = false;
            }
        }

        private void iTalk_ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(0, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox3.SelectedIndex]);
        }

        private void iTalk_ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(1, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox4.SelectedIndex]);
        }

        private void iTalk_ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(2, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox6.SelectedIndex]);
        }

        private void iTalk_ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(3, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox5.SelectedIndex]);
        }

        private void iTalk_ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(4, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox8.SelectedIndex]);
        }

        private void iTalk_ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(5, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox7.SelectedIndex]);
        }

        private void iTalk_ComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(6, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox11.SelectedIndex]);
        }

        private void iTalk_ComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(7, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox10.SelectedIndex]);
        }

        private void iTalk_ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(8, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox9.SelectedIndex]);
        }

        private void iTalk_ComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(9, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox12.SelectedIndex]);
        }

        private void iTalk_ComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(10, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox13.SelectedIndex]);
        }

        private void iTalk_ComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(11, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox14.SelectedIndex]);
        }

        private void iTalk_ComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.ChangeTeam(0, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(1, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(2, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(3, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(4, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(5, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(6, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(7, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(8, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(9, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(10, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
            Ghost.G_Client.ChangeTeam(11, Ghost.G_Client.AllBytes.Teams_Index[iTalk_ComboBox15.SelectedIndex]);
        }

        private void iTalk_ComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(0, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox28.SelectedIndex]);
        }

        private void iTalk_ComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(1, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox27.SelectedIndex]);
        }

        private void iTalk_ComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(2, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox26.SelectedIndex]);
        }

        private void iTalk_ComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(3, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox25.SelectedIndex]);
        }

        private void iTalk_ComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(4, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox24.SelectedIndex]);
        }

        private void iTalk_ComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(5, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox23.SelectedIndex]);
        }

        private void iTalk_ComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(6, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox22.SelectedIndex]);
        }

        private void iTalk_ComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(7, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox21.SelectedIndex]);
        }

        private void iTalk_ComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(8, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox20.SelectedIndex]);
        }

        private void iTalk_ComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(9, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox19.SelectedIndex]);
        }

        private void iTalk_ComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(10, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox18.SelectedIndex]);
        }

        private void iTalk_ComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(11, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox17.SelectedIndex]);
        }

        private void iTalk_ComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Sv.Vision(-1, Ghost.G_Client.AllBytes.Vision_Index[iTalk_ComboBox16.SelectedIndex]);
        }

        private void iTalk_ComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(0, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox41.SelectedIndex]);
        }

        private void iTalk_ComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(1, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox40.SelectedIndex]);
        }

        private void iTalk_ComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(2, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox39.SelectedIndex]);
        }

        private void iTalk_ComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(3, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox38.SelectedIndex]);
        }

        private void iTalk_ComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(4, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox37.SelectedIndex]);
        }

        private void iTalk_ComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(5, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox36.SelectedIndex]);
        }

        private void iTalk_ComboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(6, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox35.SelectedIndex]);
        }

        private void iTalk_ComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(7, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox34.SelectedIndex]);
        }

        private void iTalk_ComboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(8, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox33.SelectedIndex]);
        }

        private void iTalk_ComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(9, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox32.SelectedIndex]);
        }

        private void iTalk_ComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(10, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox31.SelectedIndex]);
        }

        private void iTalk_ComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(11, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox30.SelectedIndex]);
        }

        private void iTalk_ComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.GiveWeapon(0, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(1, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(2, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(3, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(4, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(5, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(6, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(7, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(8, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(9, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(10, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
            Func.GiveWeapon(11, Ghost.G_Client.AllBytes.Weapon_Index[iTalk_ComboBox29.SelectedIndex]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           if (client0Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(0);
           }
           if (client1Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(1);
           }
           if (client2Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(2);
           }
           if (client3Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(3);
           }
           if (client4Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(4);
           }
           if (client5Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(5);
           }
           if (client6Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(6);
           }
           if (client7Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(7);
           }
           if (client8Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(8);
           }
           if (client9Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(9);
           }
           if (client10Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(10);
           }
           if (client11Ch.Checked)
           {
               Ghost.G_Client.LoadSavedLoaction(11);
           }
        }

        private void miniMapSizeNum_Click(object sender, EventArgs e)
        {
            if (miniMapSizeNum.Value == 0)
            {
                Func.Cbuf_AddText(0, "seta compassSize 1.0");   //Code for the first line
            }

            if (miniMapSizeNum.Value == 1)
            {
                Func.Cbuf_AddText(0, "seta compassSize 1.2");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 2)
            {
                Func.Cbuf_AddText(0, "seta compassSize 1.4");   //Code for the first line
            }

            if (miniMapSizeNum.Value == 3)
            {
                Func.Cbuf_AddText(0, "seta compassSize 1.7");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 4)
            {
                Func.Cbuf_AddText(0, "seta compassSize 2.0");   //Code for the first line
            }

            if (miniMapSizeNum.Value == 5)
            {
                Func.Cbuf_AddText(0, "seta compassSize 2.3");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 6)
            {
                Func.Cbuf_AddText(0, "seta compassSize 2.5");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 7)
            {
                Func.Cbuf_AddText(0, "seta compassSize 3.0");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 8)
            {
                Func.Cbuf_AddText(0, "seta compassSize 3.5");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 9)
            {
                Func.Cbuf_AddText(0, "seta compassSize 4.0");   //2nd line etc etc

            }

            if (miniMapSizeNum.Value == 10)
            {
                Func.Cbuf_AddText(0, "seta compassSize 5.0");   //2nd line etc etc
            }

            if (miniMapSizeNum.Value == 11)
            {
                Func.Cbuf_AddText(0, "seta compassSize 6.0");   //2nd line etc etc
            }
        }

        private void compassSizeNum_Click(object sender, EventArgs e)
        {//Thx To MangKnife
            if (compassSizeNum.Value == 0)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 500");   //Code for the first line
            }

            if (compassSizeNum.Value == 1)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 1000");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 2)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 1500");   //Code for the first line
            }

            if (compassSizeNum.Value == 3)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 2000");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 4)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 2500");   //Code for the first line
            }

            if (compassSizeNum.Value == 5)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 3000");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 6)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 3500");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 7)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 4000");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 8)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 4500");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 9)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 5000");   //2nd line etc etc

            }

            if (compassSizeNum.Value == 10)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 5500");   //2nd line etc etc
            }

            if (compassSizeNum.Value == 11)
            {
                Func.Cbuf_AddText(0, "set compassMaxRange 6000");   //2nd line etc etc
            }
        }

        private void brightnessNum_Click(object sender, EventArgs e)
        {
            Func.Cbuf_AddText(0, "set r_specularmap " + brightnessNum.Value);
            Func.Cbuf_AddText(0, "set r_specularcolorscale " + brightnessNum.Value);
        }

        private void iTalk_ComboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(0, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox63.SelectedIndex]);
        }

        private void iTalk_ComboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(1, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox62.SelectedIndex]);
        }

        private void iTalk_ComboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(2, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox61.SelectedIndex]);
        }

        private void iTalk_ComboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(3, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox60.SelectedIndex]);
        }

        private void iTalk_ComboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(4, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox59.SelectedIndex]);
        }

        private void iTalk_ComboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(5, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox58.SelectedIndex]);
        }

        private void iTalk_ComboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(6, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox57.SelectedIndex]);
        }

        private void iTalk_ComboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(7, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox56.SelectedIndex]);
        }

        private void iTalk_ComboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(8, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox55.SelectedIndex]);
        }

        private void iTalk_ComboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(9, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox54.SelectedIndex]);
        }

        private void iTalk_ComboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(10, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox53.SelectedIndex]);
        }

        private void iTalk_ComboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(11, Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox52.SelectedIndex]);
        }

        private void iTalk_ComboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox51.SelectedIndex], 0);
        }

        private void iTalk_ComboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox50.SelectedIndex], 1);
        }

        private void iTalk_ComboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox49.SelectedIndex], 2);
        }

        private void iTalk_ComboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox48.SelectedIndex], 3);
        }

        private void iTalk_ComboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox47.SelectedIndex], 4);
        }

        private void iTalk_ComboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox46.SelectedIndex], 5);
        }

        private void iTalk_ComboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox45.SelectedIndex], 6);
        }

        private void iTalk_ComboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox44.SelectedIndex], 7);
        }

        private void iTalk_ComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox43.SelectedIndex], 8);
        }

        private void iTalk_ComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox42.SelectedIndex], 9);
        }

        private void iTalk_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox2.SelectedIndex], 10);
        }

        private void iTalk_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(Ghost.G_Client.AllBytes.Client_Index[iTalk_ComboBox1.SelectedIndex], 11);
        }

        private void iTalk_Button_18_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(0, 1);
            Ghost.G_Client.TeleportClient(0, 2);
            Ghost.G_Client.TeleportClient(0, 3);
            Ghost.G_Client.TeleportClient(0, 4);
            Ghost.G_Client.TeleportClient(0, 5);
            Ghost.G_Client.TeleportClient(0, 6);
            Ghost.G_Client.TeleportClient(0, 7);
            Ghost.G_Client.TeleportClient(0, 8);
            Ghost.G_Client.TeleportClient(0, 9);
            Ghost.G_Client.TeleportClient(0, 10);
            Ghost.G_Client.TeleportClient(0, 11);

        }

        private void iTalk_Button_19_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(1, 0);
            Ghost.G_Client.TeleportClient(1, 2);
            Ghost.G_Client.TeleportClient(1, 3);
            Ghost.G_Client.TeleportClient(1, 4);
            Ghost.G_Client.TeleportClient(1, 5);
            Ghost.G_Client.TeleportClient(1, 6);
            Ghost.G_Client.TeleportClient(1, 7);
            Ghost.G_Client.TeleportClient(1, 8);
            Ghost.G_Client.TeleportClient(1, 9);
            Ghost.G_Client.TeleportClient(1, 10);
            Ghost.G_Client.TeleportClient(1, 11);
        }

        private void iTalk_Button_110_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(2, 1);
            Ghost.G_Client.TeleportClient(2, 0);
            Ghost.G_Client.TeleportClient(2, 3);
            Ghost.G_Client.TeleportClient(2, 4);
            Ghost.G_Client.TeleportClient(2, 5);
            Ghost.G_Client.TeleportClient(2, 6);
            Ghost.G_Client.TeleportClient(2, 7);
            Ghost.G_Client.TeleportClient(2, 8);
            Ghost.G_Client.TeleportClient(2, 9);
            Ghost.G_Client.TeleportClient(2, 10);
            Ghost.G_Client.TeleportClient(2, 11);
        }

        private void iTalk_Button_111_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(3, 1);
            Ghost.G_Client.TeleportClient(3, 2);
            Ghost.G_Client.TeleportClient(3, 0);
            Ghost.G_Client.TeleportClient(3, 4);
            Ghost.G_Client.TeleportClient(3, 5);
            Ghost.G_Client.TeleportClient(3, 6);
            Ghost.G_Client.TeleportClient(3, 7);
            Ghost.G_Client.TeleportClient(3, 8);
            Ghost.G_Client.TeleportClient(3, 9);
            Ghost.G_Client.TeleportClient(3, 10);
            Ghost.G_Client.TeleportClient(3, 11);
        }

        private void iTalk_Button_114_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(4, 1);
            Ghost.G_Client.TeleportClient(4, 2);
            Ghost.G_Client.TeleportClient(4, 3);
            Ghost.G_Client.TeleportClient(4, 0);
            Ghost.G_Client.TeleportClient(4, 5);
            Ghost.G_Client.TeleportClient(4, 6);
            Ghost.G_Client.TeleportClient(4, 7);
            Ghost.G_Client.TeleportClient(4, 8);
            Ghost.G_Client.TeleportClient(4, 9);
            Ghost.G_Client.TeleportClient(4, 10);
            Ghost.G_Client.TeleportClient(4, 11);
        }

        private void iTalk_Button_115_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(5, 1);
            Ghost.G_Client.TeleportClient(5, 2);
            Ghost.G_Client.TeleportClient(5, 3);
            Ghost.G_Client.TeleportClient(5, 4);
            Ghost.G_Client.TeleportClient(5, 0);
            Ghost.G_Client.TeleportClient(5, 6);
            Ghost.G_Client.TeleportClient(5, 7);
            Ghost.G_Client.TeleportClient(5, 8);
            Ghost.G_Client.TeleportClient(5, 9);
            Ghost.G_Client.TeleportClient(5, 10);
            Ghost.G_Client.TeleportClient(5, 11);
        }

        private void iTalk_Button_122_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(6, 1);
            Ghost.G_Client.TeleportClient(6, 2);
            Ghost.G_Client.TeleportClient(6, 3);
            Ghost.G_Client.TeleportClient(6, 4);
            Ghost.G_Client.TeleportClient(6, 5);
            Ghost.G_Client.TeleportClient(6, 0);
            Ghost.G_Client.TeleportClient(6, 7);
            Ghost.G_Client.TeleportClient(6, 8);
            Ghost.G_Client.TeleportClient(6, 9);
            Ghost.G_Client.TeleportClient(6, 10);
            Ghost.G_Client.TeleportClient(6, 11);
        }

        private void iTalk_Button_123_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(7, 1);
            Ghost.G_Client.TeleportClient(7, 2);
            Ghost.G_Client.TeleportClient(7, 3);
            Ghost.G_Client.TeleportClient(7, 4);
            Ghost.G_Client.TeleportClient(7, 5);
            Ghost.G_Client.TeleportClient(7, 6);
            Ghost.G_Client.TeleportClient(7, 0);
            Ghost.G_Client.TeleportClient(7, 8);
            Ghost.G_Client.TeleportClient(7, 9);
            Ghost.G_Client.TeleportClient(7, 10);
            Ghost.G_Client.TeleportClient(7, 11);
        }

        private void iTalk_Button_124_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(8, 1);
            Ghost.G_Client.TeleportClient(8, 2);
            Ghost.G_Client.TeleportClient(8, 3);
            Ghost.G_Client.TeleportClient(8, 4);
            Ghost.G_Client.TeleportClient(8, 5);
            Ghost.G_Client.TeleportClient(8, 6);
            Ghost.G_Client.TeleportClient(8, 7);
            Ghost.G_Client.TeleportClient(8, 0);
            Ghost.G_Client.TeleportClient(8, 9);
            Ghost.G_Client.TeleportClient(8, 10);
            Ghost.G_Client.TeleportClient(8, 11);
        }

        private void iTalk_Button_125_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(9, 1);
            Ghost.G_Client.TeleportClient(9, 2);
            Ghost.G_Client.TeleportClient(9, 3);
            Ghost.G_Client.TeleportClient(9, 4);
            Ghost.G_Client.TeleportClient(9, 5);
            Ghost.G_Client.TeleportClient(9, 6);
            Ghost.G_Client.TeleportClient(9, 7);
            Ghost.G_Client.TeleportClient(9, 8);
            Ghost.G_Client.TeleportClient(9, 0);
            Ghost.G_Client.TeleportClient(9, 10);
            Ghost.G_Client.TeleportClient(9, 11);
        }

        private void iTalk_Button_126_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(10, 1);
            Ghost.G_Client.TeleportClient(10, 2);
            Ghost.G_Client.TeleportClient(10, 3);
            Ghost.G_Client.TeleportClient(10, 4);
            Ghost.G_Client.TeleportClient(10, 5);
            Ghost.G_Client.TeleportClient(10, 6);
            Ghost.G_Client.TeleportClient(10, 7);
            Ghost.G_Client.TeleportClient(10, 8);
            Ghost.G_Client.TeleportClient(10, 9);
            Ghost.G_Client.TeleportClient(10, 0);
            Ghost.G_Client.TeleportClient(10, 11);
        }

        private void iTalk_Button_127_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.TeleportClient(11, 1);
            Ghost.G_Client.TeleportClient(11, 2);
            Ghost.G_Client.TeleportClient(11, 3);
            Ghost.G_Client.TeleportClient(11, 4);
            Ghost.G_Client.TeleportClient(11, 5);
            Ghost.G_Client.TeleportClient(11, 6);
            Ghost.G_Client.TeleportClient(11, 7);
            Ghost.G_Client.TeleportClient(11, 8);
            Ghost.G_Client.TeleportClient(11, 9);
            Ghost.G_Client.TeleportClient(11, 10);
            Ghost.G_Client.TeleportClient(11, 0);
        }

        private void iTalk_Button_139_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(0);
        }

        private void iTalk_Button_138_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(1);
        }

        private void iTalk_Button_137_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(2);
        }

        private void iTalk_Button_136_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(3);
        }

        private void iTalk_Button_135_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(4);
        }

        private void iTalk_Button_134_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(5);
        }

        private void iTalk_Button_133_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(6);
        }

        private void iTalk_Button_132_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(7);
        }

        private void iTalk_Button_131_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(8);
        }

        private void iTalk_Button_130_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(9);
        }

        private void iTalk_Button_129_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(10);
        }

        private void iTalk_Button_128_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.LoadSavedLoaction(11);
        }

        private void client0Ch_CheckedChanged(object sender)
        {
            if (client0Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox145_CheckedChanged(object sender)
        {
            if (client1Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox144_CheckedChanged(object sender)
        {
            if (client2Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox143_CheckedChanged(object sender)
        {
            if (client3Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox142_CheckedChanged(object sender)
        {
            if (client4Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox141_CheckedChanged(object sender)
        {
            if (client5Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox140_CheckedChanged(object sender)
        {
            if (client6Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox139_CheckedChanged(object sender)
        {
            if (client7Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox138_CheckedChanged(object sender)
        {
            if (client8Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox137_CheckedChanged(object sender)
        {
            if (client9Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox136_CheckedChanged(object sender)
        {
            if (client10Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_CheckBox135_CheckedChanged(object sender)
        {
            if (client11Ch.Checked)
            {
                saveLocation.Start();
            }
        }

        private void iTalk_Button_140_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SaveClientLocation((int)saveLocNum.Value);
        }

        private void iTalk_Button_152_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(0, textBox59.Text);
        }

        private void iTalk_Button_151_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(1, textBox61.Text);
        }

        private void iTalk_Button_150_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(2, textBox60.Text);
        }

        private void iTalk_Button_149_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(3, textBox58.Text);
        }

        private void iTalk_Button_148_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(4, textBox57.Text);
        }

        private void iTalk_Button_147_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(5, textBox56.Text);
        }

        private void iTalk_Button_146_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(6, textBox55.Text);
        }

        private void iTalk_Button_145_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(7, textBox54.Text);
        }

        private void iTalk_Button_144_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(8, textBox53.Text);
        }

        private void iTalk_Button_143_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(9, textBox52.Text);
        }

        private void iTalk_Button_142_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(10, textBox51.Text);
        }

        private void iTalk_Button_141_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(11, textBox50.Text);
        }

        private void iTalk_Button_153_Click(object sender, EventArgs e)
        {
            Ghost.G_Client.SetClientName(0, textBox75.Text);
            Ghost.G_Client.SetClientName(1, textBox75.Text);
            Ghost.G_Client.SetClientName(2, textBox75.Text);
            Ghost.G_Client.SetClientName(3, textBox75.Text);
            Ghost.G_Client.SetClientName(4, textBox75.Text);
            Ghost.G_Client.SetClientName(5, textBox75.Text);
            Ghost.G_Client.SetClientName(6, textBox75.Text);
            Ghost.G_Client.SetClientName(7, textBox75.Text);
            Ghost.G_Client.SetClientName(8, textBox75.Text);
            Ghost.G_Client.SetClientName(9, textBox75.Text);
            Ghost.G_Client.SetClientName(10, textBox75.Text);
            Ghost.G_Client.SetClientName(11, textBox75.Text);
        }
         void SendMessage(int Client,string Text)
        {
            if (msgCh.Value == 0)
                Func.Sv.iPrintln(Client, Text);
            else if (msgCh.Value == 1)
                Func.Sv.iPrintlnCenter(Client, Text);
        }
        private void iTalk_Button_166_Click(object sender, EventArgs e)
        {
            SendMessage(0, textBox73.Text);
        }

        private void iTalk_Button_165_Click(object sender, EventArgs e)
        {
            SendMessage(1, textBox72.Text);
        }

        private void iTalk_Button_164_Click(object sender, EventArgs e)
        {
            SendMessage(2, textBox71.Text);
        }

        private void iTalk_Button_163_Click(object sender, EventArgs e)
        {
            SendMessage(3, textBox70.Text);
        }

        private void iTalk_Button_162_Click(object sender, EventArgs e)
        {
            SendMessage(4, textBox69.Text);
        }

        private void iTalk_Button_161_Click(object sender, EventArgs e)
        {
            SendMessage(5, textBox68.Text);
        }

        private void iTalk_Button_160_Click(object sender, EventArgs e)
        {
            SendMessage(6, textBox67.Text);
        }

        private void iTalk_Button_159_Click(object sender, EventArgs e)
        {
            SendMessage(7, textBox66.Text);
        }

        private void iTalk_Button_158_Click(object sender, EventArgs e)
        {
            SendMessage(8, textBox65.Text);
        }

        private void iTalk_Button_157_Click(object sender, EventArgs e)
        {
            SendMessage(9, textBox64.Text);
        }

        private void iTalk_Button_156_Click(object sender, EventArgs e)
        {
            SendMessage(10, textBox63.Text);
        }

        private void iTalk_Button_155_Click(object sender, EventArgs e)
        {
            SendMessage(11, textBox62.Text);
        }

        private void iTalk_Button_154_Click(object sender, EventArgs e)
        {
            SendMessage(-1, textBox74.Text);
        }

        private void iTalk_Button_179_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(0, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_178_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(1, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_177_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(2, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_176_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(3, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_175_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(4, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_174_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(5, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_173_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(6, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_172_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(7, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_171_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(8, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_170_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(9, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_169_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(10, "^3BISOON's^5 RTM Tool");
        }

        private void iTalk_Button_168_Click(object sender, EventArgs e)
        {
            Func.Sv.KickWithError(11, "^3BISOON's^5 RTM Tool");
        }

        private void extinxtionsBtn_Click(object sender, EventArgs e)
        {
            if (ex_prestigeCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.Prestige, (int)ex_prestigeNum.Value);
            }
            if (ex_levelCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.Level, (int)ex_levelNum.Value);
            }
            if (ex_teathCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.Teeth, (int)ex_teathNum.Value);
            }
            if (ex_reviveCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.Revive, (int)ex_reviveNum.Value);
            }
            if (ex_missionCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.MissionCompleted, (int)ex_missionNum.Value);
            }
            if (ex_maxreCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.MaxRelics, (int)ex_maxNum.Value);
            }
            if (ex_alienskilledCh.Checked)
            {
                Ghost.Stats.Extinction.SetStats(Ghost.Stats.Extinction.ExtinctionOffsets.AliensKilled, (int)ex_aliensNum.Value);
            }
        }

        private void iTalk_Button_117_Click(object sender, EventArgs e)
        {
            AutoUpdater.CheckForUpdates(Tool);
        }

        private void iTalk_Button_167_Click(object sender, EventArgs e)
        {
            Ghost.NonHostModz.SetName(nameBox.Text);
        }

        private void iTalk_Button_180_Click(object sender, EventArgs e)
        {
            Ghost.NonHostModz.SetClanTag(clanBox.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.arabmodding.com/ar/members/2/");
        }

        private void iTalk_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Skype: BISOON-B7");
            Process.Start("https://www.youtube.com/channel/UCwFmpPW6wKmp47KXSPTVjnA");
        }

        private void iTalk_Toggle13_ToggledChanged()
        {
        }

        private void iTalk_ComboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox75.Text, 0);
        }

        private void iTalk_ComboBox74_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox74.Text, 1);
        }

        private void iTalk_ComboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox73.Text, 2);
        }

        private void iTalk_ComboBox72_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox72.Text, 3);
        }

        private void iTalk_ComboBox71_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox71.Text, 4);
        }

        private void iTalk_ComboBox70_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox70.Text, 5);
        }

        private void iTalk_ComboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox69.Text, 6);
        }

        private void iTalk_ComboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox68.Text, 7);
        }

        private void iTalk_ComboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox67.Text, 8);
        }

        private void iTalk_ComboBox66_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox66.Text, 9);
        }

        private void iTalk_ComboBox65_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox65.Text, 10);
        }

        private void iTalk_ComboBox64_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.SpawnTurret("a10_30mm_turret_mp", iTalk_ComboBox64.Text, 11);
        }

        private void iTalk_ComboBox87_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox87.Text, 0);
        }

        private void iTalk_ComboBox86_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox86.Text, 1);
        }

        private void iTalk_ComboBox85_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox85.Text, 2);
        }

        private void iTalk_ComboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox84.Text, 3);
        }

        private void iTalk_ComboBox83_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox83.Text, 4);
        }

        private void iTalk_ComboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox82.Text, 5);
        }

        private void iTalk_ComboBox81_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox81.Text, 6);
        }

        private void iTalk_ComboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox80.Text, 7);
        }

        private void iTalk_ComboBox79_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox79.Text, 8);
        }

        private void iTalk_ComboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox77.Text, 9);
        }

        private void iTalk_ComboBox78_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox78.Text, 10);
        }

        private void iTalk_ComboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.Spawn(iTalk_ComboBox76.Text, 11);
        }

        public void NewAction(Action task)
        {
            new Thread((ThreadStart)(() => task()))
            {
                Name = task.Method.Name
            }.Start();
        }
        private void iTalk_CheckBox12_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox12.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(0, true)));
            }
            else
            {
                JetPack.JetPackClient(0, false);
            }
        }

        private void iTalk_CheckBox8_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox8.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(1, true)));
            }
            else
            {
                JetPack.JetPackClient(1, false);
            }
        }

        private void iTalk_CheckBox11_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox11.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(1, true)));
            }
            else
            {
                JetPack.JetPackClient(1, false);
            }
        }

        private void iTalk_CheckBox7_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox7.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(2, true)));
            }
            else
            {
                JetPack.JetPackClient(2, false);
            }
        }

        private void iTalk_CheckBox9_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox9.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(3, true)));
            }
            else
            {
                JetPack.JetPackClient(3, false);
            }
        }

        private void iTalk_CheckBox10_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox10.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(4, true)));
            }
            else
            {
                JetPack.JetPackClient(4, false);
            }
        }

        private void iTalk_CheckBox6_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox6.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(5, true)));
            }
            else
            {
                JetPack.JetPackClient(5, false);
            }
        }

        private void iTalk_CheckBox5_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox5.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(6, true)));
            }
            else
            {
                JetPack.JetPackClient(6, false);
            }
        }

        private void iTalk_CheckBox4_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox4.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(7, true)));
            }
            else
            {
                JetPack.JetPackClient(7, false);
            }
        }

        private void iTalk_CheckBox3_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox3.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(8, true)));
            }
            else
            {
                JetPack.JetPackClient(8, false);
            }
        }

        private void iTalk_CheckBox2_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox2.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(9, true)));
            }
            else
            {
                JetPack.JetPackClient(9, false);
            }
        }

        private void iTalk_CheckBox1_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox1.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(10, true)));
            }
            else
            {
                JetPack.JetPackClient(10, false);
            }
        }

        private void iTalk_CheckBox13_CheckedChanged(object sender)
        {
            if (iTalk_CheckBox13.Checked)
            {
                NewAction(new Action(() => JetPack.JetPackClient(11, true)));
            }
            else
            {
                JetPack.JetPackClient(11, false);
            }
        }
    }
}
