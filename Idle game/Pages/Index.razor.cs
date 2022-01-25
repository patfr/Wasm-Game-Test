using Microsoft.AspNetCore.Components;

namespace Idle_game.Pages
{
    public partial class Index : ComponentBase
    {
        private static PointDisplay? Display;

        public static void OnTabClick(string layer)
        {
            for (int i = 0; i < Layers.Length; i++)
            {
                if (string.Equals(Layers[i].Info.InternalName, layer))
                {
                    Layers[i].SetShown(true);
                    Layers[i].Update();
                }
                else
                {
                    Layers[i].SetShown(false);
                    Layers[i].Update();
                }
            }
        }

        private static void Execute(long time) => Tick(time / 1000d);

        private static void Tick(double t)
        {
            GainPoints(t);
            UpdateDisplay();
            TickLayers(t);
        }

        private static void GainPoints(double t) => Data.GainPoints(t);

        private static void UpdateDisplay()
        {
            if (Display == null) return;
            Display.SetPoints(Data.Points, Data.PPS);
            Display.Update();
        }

        private static void TickLayers(double t)
        {
            for (int i = 0; i < Layers.Length; i++)
            {
                Layers[i].Tick(t);
                
                for (int j = 0; j < Layers[i].Upgrades.Length; j++)
                {
                    Layers[i].Upgrades[j].Update();
                }
            }
        }

        protected override void OnInitialized()
        {
            LastRun = GetTimeMs();

            Timer = new Timer((e) =>
            {
                Execute(DeltaTime);
                LastRun = GetTimeMs();
            }, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(50));
        }

        public static Layer[] Layers = new Layer[Game.LayersData.Length];

        public static long DeltaTime => GetTimeMs() - LastRun;

        private static long GetTimeMs() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        private static long LastRun { get; set; }

        private static Timer? Timer;

        private bool LogsShown { get; set; } = false;
        private bool CreditShown { get; set; } = false;
    }
}
