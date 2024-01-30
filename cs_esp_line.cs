using ImGuiNET;
using ClickableTransparentOverlay;
using System.Numerics;
using Swed32;
using System.Runtime.InteropServices;

namespace Testing
{
    public class Program : Overlay
    {
        bool enableOverlay = false;
        Vector2 screenSize = new Vector2(1920, 1080);
        Vector2 drawPosition = new Vector2(300, 300);
        Swed swed = new Swed("popcapgame1");
       


        protected override void Render()
        {
            DrawMenu();
            DrawOverlay();
        }

        void DrawMenu()
        {
            

            ImGui.Begin("Main Menu");
            ImGui.Checkbox("Overlay", ref enableOverlay);
            ImGui.End();
        }

        void DrawOverlay()
        {
            if (enableOverlay)
            {
                ImGui.SetNextWindowSize(screenSize);
                ImGui.SetNextWindowPos(new Vector2(0, 0));
                ImGui.Begin("Overlay", ImGuiWindowFlags.NoDecoration
                    | ImGuiWindowFlags.NoBackground
                    | ImGuiWindowFlags.NoBringToFrontOnFocus
                    | ImGuiWindowFlags.NoMove
                    | ImGuiWindowFlags.NoInputs
                    | ImGuiWindowFlags.NoCollapse
                    | ImGuiWindowFlags.NoScrollbar
                    | ImGuiWindowFlags.NoScrollWithMouse
                   );

                ImDrawListPtr drawList = ImGui.GetWindowDrawList();
                //drawList.AddCircle(drawPosition, 50, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1))); //red
                //drawList.AddLine(new Vector2(1000, 1000), drawPosition, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)));
                ImDrawListPtr drawList2 = ImGui.GetWindowDrawList();
                IntPtr moduleBase = swed.GetModuleBase("popcapgame1.exe");
                IntPtr Address = swed.ReadPointer(moduleBase, 0x00096BC8, 0x3C) + 0x8;
                IntPtr Address2 = swed.ReadPointer(moduleBase, 0x00096BC8, 0x3C) + 0xC;
                int ammo = swed.ReadInt(Address);
                int ammo2 = swed.ReadInt(Address2);
                Console.WriteLine($"{ammo} {ammo2}");
                Vector2 drawPosition2 = new Vector2(ammo+40, ammo2+50);
                if(ammo2 > 49)
                {
                    drawList2.AddLine(new Vector2(1000, 1000), drawPosition2, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)), 3.0f);
                }
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start().Wait();
        }
    }
}
