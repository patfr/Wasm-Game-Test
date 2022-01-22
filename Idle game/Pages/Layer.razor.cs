using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class Layer : ComponentBase
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Parameter] public LayerData Info { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private PointDisplay? Display;

        public void Update() => StateHasChanged();

        public void Tick(double t)
        {
            Info.LayerPoints += Data.Points.Log10().Max(1) * t;

            if (Display != null)
            {
                Display.SetPoints(Info.LayerPoints);
                Display.Update();
            }
    
            Update();
        }

        public void SetShown(bool state) => Info.LayerShown = state;
    }
}
