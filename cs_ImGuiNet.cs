using ImGuiNET;
using ClickableTransparentOverlay;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Program
{
    public class Program : Overlay
    {
        private int sliderValue = 0;
        private string inputText = "";
        private int inputText2 = 1;

        protected override void Render()
        {
            ImGui.Begin("ImGuiNet");
            ImGui.Text("By MIH");
            // slide
            ImGui.SliderInt("Slider", ref sliderValue, 0, 10);
            Console.WriteLine(sliderValue.ToString());
            // label
            ImGui.Text(sliderValue.ToString());
            // input string
            ImGui.InputText("Input", ref inputText, 100);
            ImGui.Text(inputText);
            // input int?
            ImGui.InputInt("", ref inputText2, 1);
            ImGui.Text(inputText2.ToString());
            ImGui.End();
        }

        public static void Logic()
        {
            while (true)
            {
                continue;
            }
        }

        public static void Main()
        {
            Program program = new();
            program.Start().Wait();
            Thread T1 = new(Logic) { IsBackground = true };
            T1.Start();
        }
    }
}
