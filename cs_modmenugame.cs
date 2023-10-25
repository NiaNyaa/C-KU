using ImGuiNET;
using ClickableTransparentOverlay;
using Swed32;
using System.Net.NetworkInformation;
using System.Net;

namespace pvztrainer
{
    public class Program : Overlay
    {
        bool unlimited = false;
        bool nodelay = false;
        bool money = false;
        bool plantkebal = false;
        bool onehit = false;

        IntPtr moduleBase;
        int CoinAddress = 0x1BA76;
        // no delay address
        int NodelayAddress = 0x87296;
        // plant kebal address
        int PlantKebalAddress = 0x12FCF0;

        Swed swed = new Swed("popcapgame1");
        protected override void Render()
        {
            ImGui.Begin("Plant Vs Zombie Mod Menu");
            ImGui.Text("By Ikhsan");
            ImGui.Checkbox("No Pricing", ref unlimited);
            ImGui.Checkbox("No Delay", ref nodelay);
            ImGui.Checkbox("Unlimited Sun", ref money);
            ImGui.Checkbox("Plant Never Die",ref plantkebal);

        }

        public void HackLogic()
        {
            moduleBase = swed.GetModuleBase(".exe");
            while (true)
            {
                // looping untuk pointer sun nya
                IntPtr AddressSun = swed.ReadPointer(moduleBase, 0x00096BC8, 0x3C, 0x4) + 0x5560;
                
                if (unlimited)
                {
                    swed.WriteBytes(moduleBase, CoinAddress, "90 90 90 90 90 90"); // khusus nop
                }
                else
                {
                    swed.WriteBytes(moduleBase, CoinAddress, "89 B7 60 55 00 00");
                }

                if (nodelay)
                {
                    swed.WriteBytes(moduleBase, NodelayAddress, "90 90");
                }
                else
                {
                    swed.WriteBytes(moduleBase, NodelayAddress, "7E 14");
                }
                if (money)
                {
                    swed.WriteInt(AddressSun, 9999);
                }
                if (plantkebal)
                {
                    swed.WriteBytes(moduleBase, PlantKebalAddress, "90 90 90 90");
                }
                else
                {
                    swed.WriteBytes(moduleBase, PlantKebalAddress, "83 46 40 FC");
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Program program = new Program();
            program.Start().Wait();
            Thread hackThread = new Thread(program.HackLogic) { IsBackground = true};
            hackThread.Start();
        }
    }

}
