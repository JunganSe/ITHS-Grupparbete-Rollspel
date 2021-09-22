using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    internal class Nyckel : Item
    {
        private int startX;
        private int startY;
        private char symbol = 'N';
        private char symbolInvisible = ' ';

        public override char Symbol { get; set; }
        public override int X { get; set; }
        public override int Y { get; set; }
        public override string Name { get; set; } = "Nyckel";
        public bool InInventory { get; set; } = false;

        public Nyckel(int x, int y)
        {
            startX = x;
            startY = y;
            Reset();
        }

        public override void Use()
        {
            // TODO: använd för att låsa upp exit.
        }

        public override void Reset()
        {
            X = startX;
            Y = startY;
            Symbol = symbol;
            InInventory = false;
        }

        public override void Step()
        {
            if ((Player.X == X) && (Player.Y == Y) && (!InInventory))
            {
                PickUp();
            }
        }

        private void PickUp()
        {
            Inventory.AddToInventory(this);
            InInventory = true;
            Symbol = symbolInvisible;
        }
    }
}