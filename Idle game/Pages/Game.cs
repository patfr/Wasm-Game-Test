namespace Idle_game.Pages
{
    public class Game
    {
        public static DisplayPointsData MainPoints = new DisplayPointsData()
        {
            ExternalName = "Information",
        };

        public static LayerData[] LayersData = new LayerData[]
        {
            new()
            {
                ExternalName = "Data",
                InternalName = "d",
                LayerColor = "#00aa00",
                LayerShown = true,

                DisplayPointsData = new()
                {
                    ExternalName = "Data",
                    DisplayColor = "#00aa00",
                    PpsShown = false,
                },

                LayerTabData = new()
                {
                    ExternalName = "Data",
                    InternalName = "d",
                    DisplayColor = "#00ff00",
                },

                PrestigeData = new()
                {
                    DisplayColor = "#00aa00",
                },

                UpgradesData = new UpgradeData[]
                {
                    new()
                    {
                        Title = "Matrix",
                        Description = "Does nothing",
                        ColorLocked = "#aa0000",
                        ColorCan = "#00aa00",
                        Color = "#202020",
                        TextColor = "#ffffff",
                        LockedText = "#ffffff",
                        CanText = "#000000",
                        CostText = "Data",
                        Locked = false,
                        Shown = true,
                        Cost = new(50),
                        CanBuy = n => n <= Index.Layers[0].Info.LayerPoints,
                    }
                },
            }
        };
    }
}
