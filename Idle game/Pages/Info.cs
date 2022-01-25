namespace Idle_game.Pages
{
    public class VersionData
    {
        public string Name { get; set; } = "Null";
        public string Version { get; set; } = "1.0";
        public string UpdateState { get; set; } = "Beta";
        public string[] Description { get; set; } = new string[] { "Null" };
    }

    public class CreditData
    {
        public string Name { get; set; } = "Null";
        public string Color { get; set; } = "#ffffff";
        public string Description { get; set; } = "Null";
    }

    public class LayerData
    {
        public string InternalName { get; set; } = "Null";
        public string ExternalName { get; set; } = "Null";
        public string LayerColor { get; set; } = "#ffffff";

        public bool LayerShown { get; set; } = false;

        public NumberClass LayerPoints { get; set; } = new NumberClass(0);

        public DisplayPointsData DisplayPointsData { get; set; } = new DisplayPointsData();
        public TabData LayerTabData { get; set; } = new TabData();
        public PrestigeButtonData PrestigeData { get; set; } = new PrestigeButtonData();
        public UpgradeData[] UpgradesData { get; set; } = Array.Empty<UpgradeData>();
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

    public class UpgradeData
    {
        public string Title { get; set; } = "Null";
        public string Description { get; set; } = "Null";
        public string ColorLocked { get; set; } = "#ffffff";
        public string ColorCan { get; set; } = "#ffffff";
        public string Color { get; set; } = "#ffffff";
        public string TextColor { get; set; } = "#ffffff";
        public string LockedText { get; set; } = "#ffffff";
        public string CanText { get; set; } = "#ffffff";
        public string CostText { get; set; } = "Null";

        public bool Locked { get; set; } = false;
        public bool Shown { get; set; } = true;

        public NumberClass Cost { get; set; } = new NumberClass(0);

        public Func<NumberClass, bool> CanBuy = n => n >= Data.Points;
        public Func<NumberClass> Buy = () => Data.Points;
    }
}
