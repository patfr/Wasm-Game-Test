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
                LayerTheme = "#00ff00",
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
                }
            }
        };
    }
}
