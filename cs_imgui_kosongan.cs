using ImGuiNET;
using ClickableTransparentOverlay;
using Swed32;
using System.Net.NetworkInformation;
using System.Net;

namespace Program
{
    public class Program : Overlay
    {
        IntPtr moduleBase;
        Swed swed = new Swed("popcapgame1");
        bool nilai = false;

        protected override void Render()
        {
            ImGui.Begin("Test");
            ImGui.Text("By NiaNyaa");
            ImGui.Checkbox("Klik", ref nilai);
        }

        public void HackLogic()
        {
            moduleBase = swed.GetModuleBase(".exe");
            while (true)
            {
                Console.WriteLine(nilai);
               
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Program program = new Program();
            program.Start().Wait();
            Thread hackThread = new Thread(program.HackLogic) { IsBackground = true };
            hackThread.Start();
        }
    }

}
