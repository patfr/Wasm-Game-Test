namespace Idle_game.Pages
{
    public class Data
    {
        public static string Title = "Incremental";
        public static string Version = "0.01c Beta";

        public static VersionData[] ChangeLog = new VersionData[]
        {
            new()
            {
                Name = "Styling update",
                Version = "0.01c",
                Description = new string[]
                {
                    "- Added changelog.", "- Added credits.", "- Changed styling on some elements.", "(This is part 1 of the styling update)"
                },
            },
            new()
            {
                Name = "Framework",
                Version = "0.01b",
                Description = new string[]
                {
                    "- Rewritten the framework.", "- Created an unfinished upgrade framework."
                },
            },
            new()
            {
                Name = "Github",
                Version = "0.01",
                Description = new string[] 
                { 
                    "- Released to github pages.", "- Created a basic framework." 
                },
            }
        };

        public static CreditData[] Credits = new CreditData[]
        {
            new()
            {
                Name = "Hmm#8047",
                Color = "#00ffff",
                Description = "Game",
            },
            new()
            {
                Name = "SW_CreeperKing#5787",
                Color = "#99ebf7",
                Description = "Number library",
            }
        };

        public static NumberClass Points = 0;
        public static NumberClass PPS = 0;

        public static void GainPoints(double t)
        {
            NumberClass Amount = 0;

            if (CanGainPoints())
                Amount = PointGain();

            Points += t * Amount;
            PPS = Amount;
        }

        private static NumberClass PointGain()
        {
            return Points.Log2().Max(1);
        }

        private static bool CanGainPoints()
        {
            return true;
        }

        public static string Format(NumberClass n, bool nd = false) =>
            nd && n.exponent < 2 ? n.mantissa.ToString("0") :
            n.exponent < 1 ? n.mantissa.ToString("0.00") :
            n.exponent < 2 ? (n.mantissa * 10).ToString("0.0") :
            n.exponent < 3 ? (n.mantissa * 100).ToString("0") :
            n.exponent < 4 ? (n.mantissa * 1e3).ToString("0,000") :
            n.exponent < 5 ? (n.mantissa * 1e4).ToString("00,000") :
            n.exponent < 6 ? (n.mantissa * 1e5).ToString("000,000") :
            n.exponent < 7 ? (n.mantissa * 1e6).ToString("0,000,000") :
            n.exponent < 8 ? (n.mantissa * 1e7).ToString("00,000,000") :
            n.exponent < 9 ? (n.mantissa * 1e8).ToString("000,000,000") :
            n.exponent < 308 ? $"{n.mantissa:0.00}e{Format(n.exponent, true)}" :
            "error";
    }
}
