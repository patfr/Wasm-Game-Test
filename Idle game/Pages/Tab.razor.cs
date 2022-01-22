using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class Tab : ComponentBase
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [Parameter] public TabData Info { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private void Clicked() => Index.OnTabClick(Info.InternalName);
    }
}
