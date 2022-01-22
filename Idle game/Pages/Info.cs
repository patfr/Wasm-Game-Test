namespace Idle_game.Pages
{
    public class LayerData
    {
        public string InternalName { get; set; } = "Null";
        public string ExternalName { get; set; } = "Null";
        public string LayerColor { get; set; } = "#ffffff";
        public string LayerTheme { get; set; } = "#ffffff";

        public bool LayerShown { get; set; } = false;

        public NumberClass LayerPoints { get; set; } = new NumberClass(0);

        public DisplayPointsData DisplayPointsData { get; set; } = new DisplayPointsData();
        public TabData LayerTabData { get; set; } = new TabData();
        public PrestigeButtonData PrestigeData { get; set; } = new PrestigeButtonData();
    }

    public class DisplayPointsData
    {
        public string ExternalName { get; set; } = "Null";
        public string DisplayColor { get; set; } = "#ffffff";

        public bool DisplayShown { get; set; } = true;
        public bool PpsShown { get; set; } = true;

        public NumberClass DisplayPoints { get; set; } = new NumberClass(0);
        public NumberClass DisplayPps { get; set; } = new NumberClass(0);
    }

    public class TabData
    {
        public string ExternalName { get; set; } = "Null";
        public string InternalName { get; set; } = "Null";
        public string DisplayColor { get; set; } = "#ffffff";

        public bool TabShown { get; set; } = true;
    }

    public class PrestigeButtonData
    {
        public string DisplayColor { get; set; } = "#ffffff";
    }
}
