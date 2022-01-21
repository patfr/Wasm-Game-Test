using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class Layer : ComponentBase
    {
        [Parameter] public string Name { get; set; } = "Null";
        [Parameter] public bool Shown { get; set; } = false;
        [Parameter] public string Color { get; set; } = "#ffffff";

        public double Points = 0;

        private string Display => Shown ? "initial" : "none";
        private PointDisplay? text;

        public void Update() => this.StateHasChanged();

        public void Tick(double time)
        {
            Points += Math.Max(Math.Log10(Data.Points), 1) * time;

            if (text != null)
            {
                text.points = Points;
                text.Update();
            }
    
            Update();
        }
    }
}
