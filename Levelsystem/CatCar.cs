﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    class CatCar : IActiveObject
    {
        public char Symbol { get; set; } = 'K';
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; } // Positivt = höger, negativt = vänster.
        public bool GoRight { get; set; }

        public CatCar(int x, int y, int speed)
        {
            X = x;
            Y = y;
            Speed = speed;
        }

        public void Step()
        {
            Move();
            CheckPlayerKill();
        }

        private void Move()
        {
            for (int i = 0; i < Math.Abs(Speed); i++)
            {
                if (X < 2)
                {
                    X = LevelHandler.Width - 3;
                }
                else if (X > LevelHandler.Width - 3)
                {
                    X = 2;
                }
                else
                {
                    X += Math.Sign(Speed);
                }
            }
        }

        private void CheckPlayerKill()
        {
            if ((X == Player.X) && (Y == Player.Y))
            {
                // TODO: Någon visuell effekt?
                Player.Kill();
            }
        }
    }
}
