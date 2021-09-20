using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    class Exit : IActiveObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; } = false;

        public void Step()
        {
            CheckObjective();
            CheckPlayerPosition();
        }

        private void CheckObjective()
        {
            if (true) // TODO: Kontrollera om banans villkor är uppfyllt.
            {
                Open = true;
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
