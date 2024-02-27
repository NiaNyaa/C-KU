using ImGuiNET;
using ClickableTransparentOverlay;
using System.Threading.Tasks;

namespace Program
{
    public class Program : Overlay
    {
        private int sliderValue = 0;
        private string inputText = "";
        protected override void Render()
        {
            ImGui.Begin("ImGuiNet");
            ImGui.Text("By Ikhsan");
            ImGui.SliderInt("Slider", ref sliderValue, 0, 10);
            Console.WriteLine(sliderValue.ToString());
            ImGui.Text(sliderValue.ToString());
            ImGui.InputText("Input Field", ref inputText, 100);
            ImGui.Text(inputText);
            ImGui.End();
        }

        public override async Task Run()
        {
  
            while (true)
            {
                await Task.Delay(1000);
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start().Wait();
            program.Run().Wait();
        }
    }
}
