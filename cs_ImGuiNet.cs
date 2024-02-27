using ImGuiNET;
using ClickableTransparentOverlay;
using System.Threading.Tasks;

namespace Program
{
    public class Program : Overlay
    {
        protected override void Render()
        {
            ImGui.Begin("ImGuiNet");
            ImGui.Text("By NiaNyaa");
            ImGui.End(); // End the ImGui window
        }

        public override async Task Run()
        {
            // Implement any necessary logic for the Run method
            while (true)
            {
                // Perform operations or wait for events
                await Task.Delay(1000); // For example, wait for 1 second
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start().Wait();
            program.Run().Wait(); // Since Run is now async, we need to await it
        }
    }
}
