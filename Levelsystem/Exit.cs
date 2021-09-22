using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    class Exit : IActiveObject
    {
        private char symbolOpen = 'E';
        private char symbolClosed = 'e';

        private int startX;
        private int startY;

        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; }

        public Exit(int x, int y)
        {
            startX = x;
            startY = y;
            Reset();
        }

        public void Reset()
        {
            X = startX;
            Y = startY;
            Open = false;
            Symbol = symbolClosed;
        }

        public void Step()
        {
            CheckObjective();
            CheckPlayerPosition();
        }

        private void CheckObjective()
        {
            if (true) // TODO: Kontrollera om banans villkor är uppfyllt. Men hur? Kanske med: if (LevelHandler.CurrentLevel.Name == "namn på bana") osv...
            {
                Open = true;
                Symbol = symbolOpen;
            }
        }

        private void CheckPlayerPosition()
        {
            if ((Open) && (X == PlayerTemp.X) && (Y == PlayerTemp.Y))
            {
                LevelHandler.NextLevel();
            }
        }
    }
}
