
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost_RTM_By_BISOON
{
    class Func
    {
        public enum Address
        {
            Function_Address = 0x4A0700,
            PlayerCmd_ClonePlayer = 0x2F19CC,
            G_Spawn = 0x290E58,
            G_SetModel = 0x28FA4C,
            G_TempEntity = 0x2916AC,
            G_EffectIndex = 0x2E8AE8,
            G_SpawnTurret = 0x2A2A40,
            G_Entity = 0xE04980,
            G_client = 0xF44980,
            Cbuf_AddText = 0x2B1C14,
            SV_GameSendServerCommand = 0x672444,
            G_GivePlayerWeapon = 0x2947FC,
            Add_Ammo = 0x24879C,
            SetClientViewAngles = 0x231450,
            SV_LinkEntity = 0x32C420,
            SV_UnlinkEntity = 0x32C3A0,
            SV_SetBrushModel = 0x5ECF94,
            SP_Script_Model = 0x286710,
            //G_GivePlayerWeapon = 0x2A8364,
            G_InitializeAmmo = 0x1E6838,
            Key_IsDown = 0x018EEB8,
            Dvar_GetBool = 0x04CE50C,
            Get_ServerDetails = 0x1072868,
            Disabled_CharCheck = 0x378620
        }

        public class Sv
        {
            public static void SV_GameSendServerCommand(int client, string text, int type = 0)
            {
                RPC.Call((uint)Address.SV_GameSendServerCommand, client, 0, (text));
            }
            public static void iPrintlnCenter(int client, string input)
            {
                SV_GameSendServerCommand(client, "c \"" + input + "\"");
            }
            public static void iPrintln(int client, string input)
            {
                SV_GameSendServerCommand(client, "e \"" + input + "\"");
            }
            public static void Vision(int client, string input)
            {
                SV_GameSendServerCommand(client, "J \"" + input + "\"");
            }
            public static void NoGun(int client)
            {
                SV_GameSendServerCommand(client, "a 0");
            }
            public static void PlaySound(int client, string input)
            {
                SV_GameSendServerCommand(client, "n \"" + input + "\"");
            }
            public static void KickWithError(int client, string input)
            {
                SV_GameSendServerCommand((int)client, "r \"" + input + "\"");
            }
            public static void Fov(int client, int input)
            {
                SV_GameSendServerCommand(client, "q \"13 \"" + input + "\"");
            }
            public static void CompassSize(int client, String input)
            {
                SV_GameSendServerCommand((int)client, "q \"23 \"" + input + "\"");
            }
            public static void SendClientDvar(int clientNumber, string input)
            {
                SV_GameSendServerCommand(clientNumber, "q " + input + "");
            }

            public class UnlockTrophy
            {
                public static void UnlockAllTrophies()
                {
                    string[] Achievements = new string[91];
                    Achievements[0] = "3 LEVEL_1";
                    Achievements[1] = "3 LEVEL_1A";
                    Achievements[2] = "3 LEVEL_2";
                    Achievements[3] = "3 LEVEL_2A";
                    Achievements[4] = "3 LEVEL_3";
                    Achievements[5] = "3 LEVEL_3A";
                    Achievements[6] = "3 LEVEL_4";
                    Achievements[7] = "3 LEVEL_4A";
                    Achievements[8] = "3 LEVEL_5";
                    Achievements[9] = "3 LEVEL_5A";
                    Achievements[10] = "3 LEVEL_6";
                    Achievements[11] = "3 LEVEL_6A";
                    Achievements[12] = "3 LEVEL_7";
                    Achievements[13] = "3 LEVEL_7A";
                    Achievements[14] = "3 LEVEL_7B";
                    Achievements[15] = "3 LEVEL_8";
                    Achievements[16] = "3 LEVEL_8A";
                    Achievements[17] = "3 LEVEL_9";
                    Achievements[18] = "3 LEVEL_9A";
                    Achievements[19] = "3 LEVEL_10";
                    Achievements[20] = "3 LEVEL_10A";
                    Achievements[21] = "3 LEVEL_11";
                    Achievements[22] = "3 LEVEL_11A";
                    Achievements[23] = "3 LEVEL_11B";
                    Achievements[24] = "3 LEVEL_12";
                    Achievements[25] = "3 LEVEL_12A";
                    Achievements[26] = "3 LEVEL_13";
                    Achievements[27] = "3 LEVEL_13A";
                    Achievements[28] = "3 LEVEL_14";
                    Achievements[29] = "3 LEVEL_14A";
                    Achievements[30] = "3 LEVEL_15";
                    Achievements[31] = "3 LEVEL_15A";
                    Achievements[32] = "3 LEVEL_16";
                    Achievements[33] = "3 LEVEL_16A";
                    Achievements[34] = "3 LEVEL_17";
                    Achievements[35] = "3 LEVEL_17A";
                    Achievements[36] = "3 LEVEL_18";
                    Achievements[37] = "3 LEVEL_18A";
                    Achievements[38] = "3 EXT_1";
                    Achievements[39] = "3 ESCAPE_ALL_PLAYERS";
                    Achievements[40] = "3 ESCAPE_IN_TIME";
                    Achievements[41] = "3 ESCAPE_1ST_TIME";
                    Achievements[42] = "3 ESCAPE_ALL_CHALLENGE";
                    Achievements[43] = "3 REACH_CABIN";
                    Achievements[44] = "3 REACH_CITY";
                    Achievements[45] = "3 KILL_WITH_TRAP";
                    Achievements[46] = "3 SCAVENGE_ITEM";
                    Achievements[47] = "3 ESCAPE_WITH_NERF_ON";
                    Achievements[48] = "3 EXTRA1";
                    Achievements[49] = "3 EXTRA2";
                    Achievements[50] = "3 REACH_COMPOUND";
                    Achievements[51] = "3 REACH_FACILITY";
                    Achievements[52] = "3 KILLBOSS_1ST_TIME";
                    Achievements[53] = "3 KILLBOSS_IN_TIME";
                    Achievements[54] = "3 KILL_WITH_SWEAPON";
                    Achievements[55] = "3 COMPLETE_ALL_CHALLENGE";
                    Achievements[56] = "3 KILLBOSS_WITH_RELIC";
                    Achievements[57] = "3 KILL_PHANTOMS";
                    Achievements[58] = "3 KILL_RHINO_PISTOL";
                    Achievements[59] = "3 FOUND_ALL_INTELS";
                    Achievements[60] = "3 GOT_THEEGGSTRA_XP";
                    Achievements[61] = "3 REACH_CARGO";
                    Achievements[62] = "3 REACH_DECK";
                    Achievements[63] = "3 KILL_KRAKEN_1ST_TIME";
                    Achievements[64] = "3 KILL_KRAKEN_WITH_RELIC";
                    Achievements[65] = "3 KILL_KRAKEN_AND_ALL_CHALLENGES";
                    Achievements[66] = "3 FOUND_ALL_INTELS_MAYDAY";
                    Achievements[67] = "3 KILL_SEEDER_TURRETS";
                    Achievements[68] = "3 HYPNO_TRAP_RHINO";
                    Achievements[69] = "3 GOT_THEEGGSTRA_XP_DLC2";
                    Achievements[70] = "3 CRAFT_ALL_ITEMS";
                    Achievements[71] = "3 FINISH_GATE";
                    Achievements[72] = "3 EXTEND_THE_BRIDGE";
                    Achievements[73] = "3 AWAKENING_ESCAPE";
                    Achievements[74] = "3 AWAKENING_RELIC_ESCAPE";
                    Achievements[75] = "3 AWAKENING_ALL_CHALLENGES_ESCAPE";
                    Achievements[76] = "3 AWAKENING_ALL_INTEL";
                    Achievements[77] = "3 KILL_GARG_WITH_VANGUARD";
                    Achievements[78] = "3 GOT_THEEGGSTRA_XP_DLC3";
                    Achievements[79] = "3 LIKE_A_GLOVE";
                    Achievements[80] = "3 AWAKENING_4_CLASS_ESCAPE";
                    Achievements[81] = "3 LAST_COMPLETED";
                    Achievements[82] = "3 LAST_RELIC_COMPLETED";
                    Achievements[83] = "3 LAST_ALL_CHALLENGES_COMPLETED";
                    Achievements[84] = "3 LAST_ALL_INTEL";
                    Achievements[85] = "3 LAST_COMPLETE_AN_OUTPOST";
                    Achievements[86] = "3 GOT_THEEGGSTRA_XP_DLC4";
                    Achievements[87] = "3 TIMING_IS_EVERYTHING";
                    Achievements[88] = "3 YOU_WISH";
                    Achievements[89] = "3 ALWAYS_HARD";
                    Achievements[90] = "3 HAT_TRICK";

                    for (int i = 0; i < 91; i++)
                    {
                        RPC.Call((uint)Address.SV_GameSendServerCommand, -1, 1, Achievements[i]);
                        System.Threading.Thread.Sleep(25);
                        RPC.Call((uint)Address.SV_GameSendServerCommand, -1, 1, Achievements[i]);
                    }
                }
            }
        }
        public static void Cbuf_AddText(UInt32 Client, String Command)
        {
            RPC.Call((uint)Address.Cbuf_AddText, Client, Command);
        }
        public static void MapCommand(String Command)
        {
            RPC.Call((uint)Address.Cbuf_AddText, Command);
        }
        public static void GiveWeapon(int client, int weapon)
        {
            RPC.Call(0x2947fc, Convert.ToUInt32(0xf44980 + (client * 0x3700)), weapon, 0, 0);
            RPC.Call(0x24879c, Convert.ToUInt32(0xf44980 + (client * 0x3700)), weapon, 0, 9999999, 1);
        }
        //public static void SetModel(int client, string model)
        //{
        //    RPC.Call(Address.G_SetModel, Address.G_Entity + (client * 0x280), model);
        //    /*Exmple:
        //    SetModel(0,"mp_fullbody_juggernaut_heavy_black")
        //  Will give Juggernaut Model to client 0*/
        //}
        private static UInt32 G_Client(Int32 clientIndex)
        {
            return (0xF44980 + ((UInt32)(0x3700 * clientIndex)));
        }
        private static UInt32 G_Entity(Int32 clientIndex)
        {
            return (0xE04980 + ((UInt32)(0x280 * clientIndex)));
        }
        public static Int32 SpawnTurret(string Type, string ModelName, int Client)
        {
            float[] Angles = ReadSingle(G_Entity((Int32)Client) + 0x144, 3);
            float[] Pos = ReadSingle(G_Client((Int32)Client) + 0x1C, 3);
            int Ent = RPC.Call(0x290E58);
            WriteSingle((uint)Ent + 0x138, new float[] { Pos[0], Pos[1], Pos[2] });
            WriteSingle((uint)Ent + 0x144, new float[] { Angles[0], Angles[1], Angles[2] });
            RPC.Call(0x28FA4C, Ent, ModelName);// G_SetModel Ghosts
            RPC.Call(0x2A2A40, Ent, Type);//G_SpawnTurret Ghosts
            return Ent;
        }
        public static Int32 Spawn(string ModelName, int Client)
        {
            int Ent = RPC.Call(0x290E58);
            float[] Angles = ReadSingle(G_Entity((Int32)Client) + 0x144, 3);
            float[] Pos = ReadSingle(G_Client((Int32)Client) + 0x1C, 3);
            WriteSingle((uint)Ent + 0x138, new float[] { Pos[0], Pos[1], Pos[2] });
            WriteSingle((uint)Ent + 0x144, new float[] { Angles[0], Angles[1], Angles[2] });
            RPC.Call(0x28FA4C, Ent, ModelName);// G_SetModel Ghosts
            RPC.Call(0x286710, new object[] { Ent });
            return Ent;
        }
        private static void WriteSingle(UInt32 address, float[] input)
        {
            Int32 length = input.Length;
            Byte[] array = new Byte[length * 4];
            for (Int32 i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (Int32)(i * 4));
            }
            PS3.SetMemory(address, array);
        }
        private static float[] ReadSingle(UInt32 address, Int32 length)
        {
            byte[] memory = PS3.ReadBytes(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length];
            for (Int32 i = 0; i < length; i++)
            {
                numArray[i] = BitConverter.ToSingle(memory, ((length - 1) - i) * 4);
            }
            return numArray;
        }
        private static byte[] ReverseBytes(byte[] input)
        {
            Array.Reverse(input);
            return input;
        }

    }
}
    
