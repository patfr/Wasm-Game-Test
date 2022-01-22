using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class PrestigeButton : ComponentBase
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Parameter] public PrestigeButtonData Info { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
