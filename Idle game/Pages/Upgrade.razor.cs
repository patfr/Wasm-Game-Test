using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class Upgrade : ComponentBase
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Parameter] public UpgradeData Info { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private string BackgroundColor => Info.Locked ? Info.ColorLocked : Info.CanBuy(Info.Cost) ? Info.ColorCan : Info.Color;
        private string TextColor => Info.Locked ? Info.LockedText : Info.CanBuy(Info.Cost) ? Info.CanText : Info.TextColor;
        private string Animation => Info.CanBuy(Info.Cost) ? "can" : "";

        public void Update() => StateHasChanged();
    }
}
