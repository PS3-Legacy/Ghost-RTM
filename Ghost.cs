using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost_RTM_By_BISOON
{
    class Ghost
    {
        public static void AntiBan()
        {
            byte[] _00 = new byte[] { 0x00 };
            byte[] AntiBan = new byte[] { 0x02 }; PS3.SetMemory(0x700AD7/*0x06FC487*/, AntiBan); //Report index Check
            PS3.SetMemory(0x6FF167/*0x06FB40B*/, AntiBan); //Challanges Check
            PS3.SetMemory(0x6FF4DB/*0x06FB77F*/, AntiBan); //Report Cid check
            PS3.SetMemory(0x700ADB/*0x06FC48B*/, _00); //Deamonware check
            PS3.SetMemory(0x700B13/*0x06FC4C3*/, AntiBan); //Deamonware check
            PS3.SetMemory(0x700ADF/*0x06FC48F*/, _00); // DeamonWare check
            byte[] newban = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x5CDBE0/*0x057A47C*/, newban);

        }
        public static byte[] Location_Byte = { 0x00 };
        public class G_Client
        {

            public enum ClientOffset
            {
                NextClient = 0x3700,
                UAV = 0xF47AE5,
                RedBox = 0xF44993,
                SkateMod = 0xF4498E,
                ThirdPerson = 0xF44993,
                Teleport = 0xF4499B,
                mflag = 0xF47C9F,
                PlayerSpeed = 0xF479D0,
                GiveLag = 0xF4791F,
                Freeze = 0xF47C9F,
                ChangeTeam = 0xF479E3,
                GreenCheckBox = 0xF44DA3,
                AkimboPrimary = 0xF44CC1,
                Godmode = 0xE04B2A,
                JetPack = 0xF449B0,
                ButtonMonitoring = 0xF47CB0,
                Models = 0xE04AF1,
                ChangeName = 0xF47A1C,//F47A1C
                GetName = 0xF4799c,
                KillsParty = 0xF47AD3,
                DeathsParty = 0xF47AD5,
                ScoreParty = 0xF47AD0,
                AssistParty = 0xF47AD7,
                Ammo1 = 0xF44EDA,
                Ammo2 = 0xF44EEA,
                Ammo3 = 0xF44ECA,
                Ammo4 = 0xF44EBA,
                Ammo5 = 0xF44EFA,
                TakeWeapon = 0xF44C6E
            }
            public class AllBytes
            {
                public static byte[] UAVOn = { 0x04 };
                public static byte[] UAVOff = { 0x00 };
                public static byte[] RedBoxOn = { 0x10 };
                public static byte[] RedBoxOff = { 0x00 };
                public static byte[] SkateOn = { 0x01 };
                public static byte[] SkateOff = { 0x00 };
                public static byte[] ThirdPersonOn = { 0x02 };
                public static byte[] ThirdPersonOff = { 0x00 };
                public static byte[] GiveLagOn = { 0x01 };
                public static byte[] GiveLagOff = { 0x02 };
                public static byte[] FreezeOn = { 0x04 };
                public static byte[] FreezeOff = { 0x00 };
                public static byte[] GreenCheckBoxOn = { 0xF0 };
                public static byte[] GreenCheckBoxOff = { 0x00 };
                public static byte[] GodmodeOn = { 0x80 };
                public static byte[] GodmodeOff = { 0x00 };
                public static byte[] Speed_On = { 0x3F, 0xFF };
                public static byte[] Speed_Off = { 0x3F, 0x80 };
                public static byte[] NoClip_On = { 0x02 };
                public static byte[] NoClip_Off = { 0x00 };
                public static int[] Client_Index = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                public static byte[] Teams_Index = { 0x03, 0x08, 0x01, 0x02 };
                public static string[] Vision_Index = {"default_mp","thermal_mp","default_night_mp","missilecam","ac130","ac130_enhanced","ac130_inverted","aftermath","black_bw","cheat_bw","coup_sunblind","default","default_night","default_night_mp","end_game","misslecam","mp_fahrenheit","mp_fahrenheit_storm_exterior_dark",
               "mp_flooded","mp_flooded_vision_set_cg_helo","mp_flooded_vision_set_cg_garage","mp_flooded_vision_set_cg_garage_water","mp_flooded_vision_set_cg_interior_ng","mp_flooded_vision_set_cg_ng","mp_frag","mp_hashima","mp_hashima_intiriors","mp_lonestar","mp_strikezone_bridge","mp_strikezone_flash","mp_strikezone_interior",
               "mp_strikezone_stadium_bar","mp_warhawk","mp_warhawk_interior","pintro","pintro_dart",
               "mpnuke","mpnuke_aftermath","mpoutro","near_death","near_death_mp","thermal_mp","thermal_snowlevel_mp"};

                public static byte[] Weapon_Index = { 84, 80, 73, 66, 41, 40, 48, 38, 43, 89, 86, 55, 46, 85, 69, 49, 45, 88, 79, 54, 50, 42, 57, 56, 51, 39, 87, 74, 65, 44, 78, 76, 75, 72, 62, 58, 82, 81, 77, 71, 70, 68, 67, 63, 23, 136, 137 };
            }

            public static void ClientModz(ClientOffset Offset, int Client, byte[] On_or_Off)
            {
                PS3.WriteBytes((uint)Offset + 0x3700 * (uint)Client, On_or_Off);
            }
            public static void GodMode(int Client, string str)
            {
                if (str == "On")
                {
                    PS3.WriteByte((uint)ClientOffset.Godmode + 0x280 * (uint)Client, 0x80);
                }
                else if (str == "Off")
                {
                    PS3.WriteByte((uint)ClientOffset.Godmode + 0x280 * (uint)Client, 0x00);
                }
            }
            public static void GiveAmmo(int Client)
            {
                 byte[] Ammo = new byte[] {0x50};
                 ClientModz(Ghost.G_Client.ClientOffset.Ammo1, Client, Ammo);
                 ClientModz(Ghost.G_Client.ClientOffset.Ammo2, Client, Ammo);
                 ClientModz(Ghost.G_Client.ClientOffset.Ammo3, Client, Ammo);
                 ClientModz(Ghost.G_Client.ClientOffset.Ammo4, Client, Ammo);
                 ClientModz(Ghost.G_Client.ClientOffset.Ammo5, Client, Ammo);
            }
            public static string GetClientName(int Client)
            {
                return PS3.ReadString((uint)ClientOffset.GetName + 0x3700 * (uint)Client);
            }
            public static void SetClientName(int Client, string newName)
            {
                PS3.WriteString((uint)ClientOffset.ChangeName, newName);
            }
            public static void ChangeTeam(int Client, byte NewTeam)
            {
                PS3.WriteByte((uint)ClientOffset.ChangeTeam + 0x3700 * (uint)Client, NewTeam);
            }

            public static void TeleportClient(int Client_Location, int Teleport_Client)
            {
                byte[] newLocation = PS3.GetMemory((uint)ClientOffset.Teleport + (uint)ClientOffset.NextClient * (uint)Client_Location, 12);
                PS3.SetMemory((uint)ClientOffset.Teleport + (uint)ClientOffset.NextClient * (uint)Teleport_Client, newLocation);
            }
            public static byte[] SaveClientLocation(int Client)
            {
                return Location_Byte = PS3.GetBytes((uint)ClientOffset.Teleport + (uint)ClientOffset.NextClient * (uint)Client, 12);
            }
            public static void LoadSavedLoaction(int Client)
            {
                PS3.SetMemory((uint)ClientOffset.Teleport + (uint)ClientOffset.NextClient * (uint)Client, Location_Byte);
            }
        }

        public class Stats
        {
            public class MultiPlayer
            {
                public enum StatsOffset
                {
                    Stats_updater = 0x179DE3D,
                    UnlockAll = Stats_updater + 0x4273,// (bytes in C# http://pastebin.com/AjexHw99 )
                    PreferredWeapon = Stats_updater,// (Prefered Weapon List http://pastebin.com/8Cfx83Kh  )
                    Prestige = Stats_updater + 0x4EDF,
                    XPSoldier = Stats_updater + 0xF9D,
                    Kills = Stats_updater + 0x3C,
                    Deaths = Stats_updater + 0x14,
                    Score = Stats_updater + 0x65,
                    Wins = Stats_updater + 0x8D,
                    Losses = Stats_updater + 0x44,
                    SquadPoints = Stats_updater + 0x4BE7,
                    Killstreak = Stats_updater + 0x40,
                    Currentstreak = Stats_updater + 0x910,
                    Winstreak = Stats_updater + 0x10,
                    Misses = Stats_updater + 0x49,
                    Hits = Stats_updater + 0x34,
                    GamesPlayed = Stats_updater + 0x2C,
                    TimePlayed = Stats_updater + 0x81,
                }
                public class SoldierOffset
                {
                    public static uint Soldier1 = 0x179eddc,
                    soldier2 = Soldier1  + 0x564,
                    soldier3 = soldier2 + 0x564,
                    soldier4 = soldier3 + 0x564,
                    soldier5 = soldier4 + 0x564,
                    soldier6 = soldier5 + 0x564,
                    soldier7 = soldier6 + 0x564,
                    soldier8 = soldier7 + 0x564,
                    soldier9 = soldier8 + 0x564,
                    soldier10 = soldier9 + 0x564;
                }
                public static void SetStats(StatsOffset Offset, int Stats)
                {
                    byte[] input = BitConverter.GetBytes(Convert.ToInt32(Stats));
                    PS3.SetMemory((uint)Offset, input);
                }
                public static void UnlockAll()
                {
                    byte[] buffer = new byte[] { 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x01, 0x01, 0x01, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x02, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00 };
                    PS3.SetMemory((uint)StatsOffset.UnlockAll, buffer);
                }
            }

            public class Extinction
            {
                public enum ExtinctionOffsets
                {
                    Prestige = 0x17A550C,
                    Level = 0x17A5513,
                    Teeth = 0x17A60E6,
                    Revive = 0x17A550A,
                    MissionCompleted = 0x17A5532,
                    MaxRelics = 0x17A5522,
                    AliensKilled = 0x17A552A,
                    Revives = 0x17A5470,
                    Score = 0x17A5574,
                    Kills = 0x17A558C,
                    Downs = 0x17A54C8,
                    CashFlow = 0x17A54FC,
                    Hives_Distroyed = 0x17A54CC,
                    Complated_Challenges = 0x17A54F1,
                    Attemtepted_Challenges = 0x17A54F5
                }
                public static void SetStats(ExtinctionOffsets Offset, int Stats)
                {
                    byte[] input = BitConverter.GetBytes(Convert.ToInt32(Stats));
                    PS3.SetMemory((uint)Offset, input);
                }
            }
        }

        public class NonHostModz
        {
            static uint Name = Name = 0x177A238,
                ClanTag = 0xCBFF70;
            public enum AllPlayer_Color
            {
                Normal = 0,
                White = 2,
                Red = 4,
                Green = 6,
                LightBlue = 8,
                Orange = 10,
                Yellow = 12,
            }
            public enum NonHoastOffsets
            {
                AdvancedUAV = 0x140A3A,
                NoRecoil = 0x6C65C0,
                Laser = 0x52DDE7,
                ChromePlayer = 0x478D5B,
                PlayerColour = 0x01CBEDB8,
                SteadyAim = 0x1215CC,
                SkyColour = 0x01CBF0B8,
                WallhackGlow = 0x16AB63,
                RedBoxes = 0x149134,
                GlowPlayers = 0x16AB63,
                SuperTargetfinder = 0x01CC4B78,
                ThirdPerson = 0x02363310,
                cg_fov = 0x008A4B46,
                UAV = 0x023638f8,
                Wallhack = 0x0086C664
            }
            public class AllBytes
            {
                public static byte[] AdvancedUAV_On = { 0x01 };
                public static byte[] AdvancedUAV_Off = { 0x00 };
                public static byte[] NoRecoil_On = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                public static byte[] NoRecoil_Off = new byte[] { 0x4B, 0xA5, 0xA2, 0xB1 };
                public static byte[] Laser_On = { 0x01 };
                public static byte[] Laser_Off = { 0x00 };
                public static byte[] ChromePlayer_On = { 0x01 };
                public static byte[] ChromePlayer_Off = { 0x00 };
                public static byte[] SteadyAim_On = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                public static byte[] SteadyAim_Off = new byte[] { 0x2C, 0x03, 0x00, 0x02 };
                public static byte[] WallHack_On = { 0x01 };
                public static byte[] WallHack_Off = { 0x00 };
                public static byte[] RedBox_On = { 0x10, 0x82, 0x00, 0x0C };
                public static byte[] RedBox_Off = { 0x41, 0x82, 0x00, 0x0C };
                public static byte[] UAV_On = { 0x01 };
                public static byte[] UAV_Off = { 0x00 };
                public static byte[] ThirdPerson_On = { 0x01 };
                public static byte[] ThirdPerson_Off = { 0x00 };
                public static byte[] Color_Index = { 0, 2, 4, 6, 8, 10, 12 };
            }

            public static void NonHost_Modz(NonHoastOffsets Offset, byte[] value)
            {
                PS3.SetMemory((uint)Offset, value);
            }
            public static void PlayerColor_Modz(byte Color)
            {
                PS3.WriteByte((uint)NonHoastOffsets.GlowPlayers, (byte)Color);
            }

            public static string GetName()
            {
                return PS3.ReadString(Name);
            }
            public static string GetClan()
            {
                return PS3.ReadString(ClanTag);
            }
            public static void SetName(string input)
            {
                PS3.WriteString(Name, input);
            }
            public static void SetClanTag(string input)
            {
                PS3.WriteString(ClanTag, input);
            }
        }

        public class LobbyModz
        {
            public enum LobbyModsOffset
            {
                Knockback = 0x01CA2858,
                Timescale = 0x01CB5578,
                FlyMode = 0x5D5DE8,
                MaxFallDamage = 0xDE394,
                PlayerSpeed = 0x22E01E,
                JumpHeight = 0xEC708,
                Gravity = 0x22FE72,
                Invisible = 0x0177EA25,
                MinFallDamage = 0xF905C,
                GodModeAll = 0x23D1E0,
                FullAuto = 0x10EA9C,
                WallBreach = 0x22DFCE
            }
            public class AllBytes
            {
                public static  byte[] GodMod_On = { 0x91 };
                public static  byte[] GodMod_Off = { 0x90 };
                public static  byte[] Gravity_Default = { 0xA0, 0x03, 0x20, 0x83 };
                public static  byte[] Gravity_Low = { 0xA0, 0x00, 0x50, 0x83 };
                public static  byte[] Gravity_High = { 0xA0, 0x05, 0x50, 0x83 };
                public static  byte[] Gravity_VeryHigh = { 0xA0, 0x10, 0x50, 0x83 };

                public enum JumpLevel
                {
                    Normal = 0x42,
                    High = 0x43,
                    SuperHigh = 0x44
                }
                public enum SpeedLevel
                {
                    Normal = 00,
                    Fast = 1,
                    SuperFast = 2
                }
            }

            public static void Lobby_Modz(LobbyModsOffset Offset, byte[] bytes)
            {
                PS3.SetMemory((uint)Offset, bytes);
            }
            public static void LobbyJump(AllBytes.JumpLevel JLevel)
            {
                PS3.WriteByte((uint)LobbyModsOffset.JumpHeight, (byte)JLevel);
                PS3.SetMemory((uint)LobbyModsOffset.JumpHeight + 1, new byte[] { 0x1C });
            }
            public static void SpeedLobby(AllBytes.SpeedLevel SLevel)
            {
                PS3.WriteByte((uint)LobbyModsOffset.PlayerSpeed, (byte)SLevel);
                PS3.SetMemory((uint)LobbyModsOffset.PlayerSpeed, new byte[] { 0xBE });
            }
            public static void Antijoin(bool tru)
            {
                if (tru)
                {
                    Func.MapCommand("set g_password 123");
                }
                else
                {
                    Func.MapCommand("reset g_password");
                }
            }
            public static void TimeLimit(int Time)
            {
                Func.Cbuf_AddText(0, "set scr_war_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_dm_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_sd_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_dom_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_conf_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_sr_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_grind_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_blitz_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_cranked_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_infect_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_sotf_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_dem_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_horde_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_sotf_ffa_timelimit " + Time);
                Func.Cbuf_AddText(0, "set scr_gun_timelimit " + Time);
            }
            public static void ScoreLimit(int Score)
            {
                Func.Cbuf_AddText(0, "set scr_war_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_dm_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_sd_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_dom_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_conf_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_sr_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_grind_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_blitz_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_cranked_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_infect_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_sotf_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_dem_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_horde_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_sotf_ffa_scorelimit " + Score);
                Func.Cbuf_AddText(0, "set scr_gun_scorelimit " + Score);
            }
            public static void LiveNum(int Live)
            {
                Func.Cbuf_AddText(0, "set scr_sd_numlives " + Live);
                Func.Cbuf_AddText(0, "set scr_sr_numlives " + Live);

                Func.Cbuf_AddText(0, "set scr_war_numlives " + Live);
                Func.Cbuf_AddText(0, "set scr_dm_numlives " + Live);
                Func.Cbuf_AddText(0, "set scr_dom_numlives " + Live);
                Func.Cbuf_AddText(0, "set scr_conf_numlives " + Live);
                Func.Cbuf_AddText(0, "set scr_gun_numlives " + Live);
            }
            public static void ScorePerKill(int Score)
            {
                Func.Cbuf_AddText(0, "set scr_war_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_dm_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_sd_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_dom_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_conf_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_sr_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_grind_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_blitz_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_cranked_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_infect_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_sotf_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_dem_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_horde_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_sotf_ffa_score_kill " + Score);
                Func.Cbuf_AddText(0, "set scr_gun_score_kill " + Score);
            }
            public static void ScorePerSuicide(int Suicide)
            {
                Func.Cbuf_AddText(0, "set scr_war_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_dm_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_sd_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_dom_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_conf_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_sr_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_grind_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_blitz_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_cranked_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_infect_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_sotf_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_dem_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_horde_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_sotf_ffa_score_suicide " + Suicide);
                Func.Cbuf_AddText(0, "set scr_gun_score_suicide " + Suicide);
            }
        }

        public class ClassModify
        {
            public enum ClassOffsets
            {
                Class1 = 0x179EABB,
                Class2 = Class1 + 0x80,
                Class3 = Class2 + 0x80,
                Class4 = Class3 + 0x80,
                Class5 = Class4 + 0x80,
                Class6 = Class5 + 0x80,
                Class7 = Class6 + 0x80,
                Class8 = Class7 + 0x80,
                Class9 = Class8 + 0x80,
                Class10 = Class9 + 0x80,
                NextClass = 0x80,
                NextSolider = 0x564
            }

            public static void SetClassName(int Solider, int Class, string newName)
            {
                //PS3.WriteString(((uint)ClassOffsets.Class1 + (uint)ClassOffsets.NextSolider * ((uint)Solider -1 )) + (uint)ClassOffsets.NextClass * ((uint)Class - 1), newName);
                ////PS3.WriteString((uint)ClassOffsets.Class1 + (uint)ClassOffsets.NextClass * (uint)Class, newName);
            }
        }
        public class ServersDetails
        {
            string info;
            public ServersDetails(string gameInfo)
            {
                if (gameInfo != "")
                    info = gameInfo;
            }
            public String getMapName()
            {
                String Map = info.Split('|')[6];
                switch (Map)
                {
                    default: return "Unknown Map";
                    case "mp_prisonbreak": return "Prison Break";
                    case "mp_dart": return "Octane";
                    case "mp_lonestar": return "Tremor";
                    case "mp_frag": return "Freight";
                    case "mp_snow": return "Whiteout";
                    case "mp_fahrenheit": return "Stormfront";
                    case "mp_hasima": return "Siege";
                    case "mp_warhawk": return "Warhawk";
                    case "mp_sovereign": return "Sovereign";
                    case "mp_zebra": return "Overlord";
                    case "mp_skeleton": return "Stonehaven";
                    case "mp_chasm": return "Chasm";
                    case "mp_flooded": return "Flooded";
                    case "mp_strikezone": return "Strikezone";
                    case "mp_descent": return "Free Fall";
                    case "mp_ca_red_river": return "Contaiment";
                    case "mp_ca_rumble": return "BayView";
                    case "mp_swamp": return "Fog";
                    case "mp_boneyard_ns": return "Ignition";
                    case "mp_alien_town": return "Point of Contact";
                    case "mp_alien_armory": return "NightFall";
                    case "mp_favela_iw6": return "Favela";
                    case "mp_pirate": return "Mutiny";
                    case "mp_dig": return "Pharaoh";
                    case "mp_zulu": return "Departed";
                }
            }
            public String getGameMode()
            {
                String GM = info.Split('|')[2];
                switch (GM)
                {
                    default: return "Unknown Gametype";
                    case "war": return "Team Deathmatch";
                    case "dm": return "Free for All";
                    case "sd": return "Search and Destroy";
                    case "dom": return "Domination";
                    case "conf": return "Kill Confirmed";
                    case "sr": return "Search and Rescue";
                    case "grind": return "Grind";
                    case "blitz": return "Blitz";
                    case "cranked": return "Cranked";
                    case "infect": return "Infected";
                    case "sotf": return "Hunted";
                    case "dem": return "Demolition";
                    case "horde": return "Safeguard";
                    case "sotf_ffa": return "Hunted FFA";
                    case "gun": return "Gun Game";
                }
            }

            public String getHardcore()
            {
                String HC = info.Split('|')[4];
                switch (HC)
                {
                    default: return "Unknown Gametype";
                    case "0": return "Hardcore - Off";
                    case "1": return "Hardcore - On";
                }
            }

            public String getHostName()
            {
                String Host = info.Split('|')[18];
                if (Host == "Modern Warfare 3")
                    return "Dedicated Server (No Player is Host)";
                else if (Host == "")
                    return "You are not In-Game";
                else return Host;
            }
        }
    }
}
