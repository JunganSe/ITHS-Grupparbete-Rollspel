using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    class Exit : IActiveObject
    {
        public char Symbol { get; set; } = 'E';
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; } = false;

        public Exit(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Step()
        {
            CheckObjective();
            CheckPlayerPosition();
        }

        private void CheckObjective()
        {
            if (true) // TODO: Kontrollera om banans villkor är uppfyllt. Men hur? Kanske: if (LevelHandler.CurrentLevel.Name == "namn på bana") osv...
            {
                Open = true;
                Symbol = 'F';
            }
        }

        private void CheckPlayerPosition()
        {
            if ((Open) && (X == Player.X) && (Y == Player.Y))
            {
                // TODO: Gå till nästa bana.
            }
        }
    }
}
