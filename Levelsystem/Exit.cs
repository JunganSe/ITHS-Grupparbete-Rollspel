using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    internal class Exit : IActiveObject
    {
        public char Symbol { get; set; } = ' ';
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
            if (Checkpoint.Counter == 3)
            {
                Open = true;
                Symbol = '»';
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