using System;
using System.Collections.Generic;
using System.Text;


namespace Rollspel
{
    public class Boom : IActiveObject
    {
        private char symbol = '*';

        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Boom(int x, int y)
        {
            X = x;
            Y = y;
            Reset();
        }

        public void Reset()
        {
            Symbol = symbol;

        }

        public void Step()
        {
            CheckPlayerKill();
        }


        private void CheckPlayerKill()
        {
            if ((X == Player.X) && (Y == Player.Y))
            {
                Player.Kill();
            }
        }



    }
}