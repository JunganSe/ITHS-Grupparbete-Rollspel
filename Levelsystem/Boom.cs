using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    internal class Boom : IActiveObject
    {
        public char SymbolActive { get; set; } = 'o';
        public char Symbol { get; set; } = 'x';
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; } = false;


        private static Random rnd = new Random();


        public Boom(int x, int y)
        {
            X = x;
            Y = y;

        }


        public void Step()
        {
            PickRandom();
            CheckPlayerPosition();
        }

        public void CreateBoom(int x, int y)
        {

            Symbol = SymbolActive;

        }


        public void PickRandom()
        {
            int r = rnd.Next(LevelHandler.CurrentLevel.ActiveObjects.Count);
            var currentBoom = LevelHandler.CurrentLevel.ActiveObjects[r];
            if (currentBoom.X == ' ' && currentBoom.Y == 'x')
            {
                CreateBoom(currentBoom.X, currentBoom.Y);
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