using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class PointDisplay : ComponentBase
    {
#pragma warning disable CS8618
        [Parameter] public DisplayPointsData Info { get; set; }
#pragma warning restore CS8618

        public void Update() => StateHasChanged();

        public void SetPoints(NumberClass? p = null, NumberClass? pps = null)
        {
            if (p is not null) Info.DisplayPoints = p;
            if (pps is not null) Info.DisplayPps = pps;
        }
    }
}
