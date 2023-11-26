using ImGuiNET;
using ClickableTransparentOverlay;
using System.Numerics;

namespace Testing
{
    public class Program : Overlay
    {
        bool enableOverlay = false;
        Vector2 screenSize = new Vector2(1920, 1080);
        Vector2 drawPosition = new Vector2(300, 300);
        
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
                drawList.AddCircle(drawPosition, 50, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1))); //red
                drawList.AddLine(new Vector2(1000, 1000), drawPosition, ImGui.ColorConvertFloat4ToU32(new Vector4(1, 0, 0, 1)));
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start().Wait();
        }
    }
}
