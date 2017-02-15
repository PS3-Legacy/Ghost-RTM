using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace Ghost_RTM_By_BISOON
{
    class PS3
    {
        public static PS3API API = new PS3API();

        public static bool Connect()
        {
           return API.ConnectTarget();
        }
        public static bool Attach()
        {
            return API.AttachProcess();
        }
        public static void CCAPI()
        {
            API.ChangeAPI(SelectAPI.ControlConsole);
        }
        public static void TMAPI()
        {
            API.ChangeAPI(SelectAPI.TargetManager);
        }
        public static void SetMemory(uint Offset, byte[] _byte)
        {
            API.SetMemory(Offset, _byte);
        }
        //public static string ReadString(uint Offset)
        //{
        //    return API.Extension.ReadString(Offset);
        //}
        public static void WriteBytes(uint Offset, byte[] On_Or_Off)
        {
            API.Extension.WriteBytes(Offset, On_Or_Off);
        }
        public static void WriteInt32(uint Offset, short input)
        {
            API.Extension.WriteInt16(Offset, input);
        }
        public static byte[] GetMemory(uint offset, int length)
        {
            byte[] buffer = new byte[length];
            API.GetMemory(offset, buffer);
            return buffer;
        }
        public static byte[] ReadBytes(uint offset, int length)
        {
            return API.GetBytes(offset, length);
        }
        public static string ReadString(uint offset)
        {
            int length = 40;
            int num2 = 0;
            string source = "";
            do
            {
                byte[] bytes = ReadBytes(offset + ((uint)num2), length);
                source = source + Encoding.UTF8.GetString(bytes);
                num2 += length;
            }
            while (!source.Contains<char>('\0'));
            int index = source.IndexOf('\0');
            string str2 = source.Substring(0, index);
            source = string.Empty;
            return str2;
        }
        public static void WriteByte(uint offset, byte input)
        {
            byte[] buffer = new byte[] { input };
            API.SetMemory(offset, buffer);
        }
        public static void Write2Byte(uint offset, byte input)
        {
            byte[] buffer = new byte[2];
            API.SetMemory(offset, buffer);
        }
        public static void WriteInt16(uint offset, short input)
        {
            byte[] array = new byte[2];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 2);
            API.SetMemory(offset, array);
        }
        public static void WriteString(uint offset, string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            API.SetMemory(offset, bytes);
        }
        public static void WriteUInt32(uint Offset, uint input)
        {
            API.Extension.WriteUInt32(Offset, input);
        }
        public static uint ReadUInt32(uint Offset)
        {
           return API.Extension.ReadUInt32(Offset);
        }
        public static Int32 ReadInt32(uint Offset)
        {
            return API.Extension.ReadInt32(Offset);
        }
        public static byte[] GetBytes(uint Offset, int Length)
        {
            return API.GetBytes(Offset, Length);
        }
    }
}
