using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost_RTM_By_BISOON
{
    class JetPack
    {
         static uint findPS(int client)
        {
            return 0xF449a4 + ((uint)client * 0x3700);
        }
         static bool[] True = new bool[12];
        public static void JetPackClient(int client, bool Tru)
        {
            if (PS3.API.GetCurrentAPI() == PS3Lib.SelectAPI.TargetManager)
            {
                PS3.Connect();
            }
            True[client] = Tru;
            while (True[client] == true)
            {
                if (Buttonz.ButtonPressed((uint)client, Buttonz.Buttons.X))
                {
                    float jH = PS3.API.Extension.ReadFloat(findPS(client));
                    jH += 100;
                    PS3.API.Extension.WriteFloat(findPS(client), jH);
                }
            }
            
        }
    }
}
