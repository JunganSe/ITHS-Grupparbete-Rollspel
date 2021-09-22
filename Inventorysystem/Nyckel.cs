using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    internal class Nyckel : Item
    {
        private int startX;
        private int startY;

        public override char Symbol { get; set; } = 'N';
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
            
        }

        public override void Step()
        {
            if ((Player.X == X) && (Player.Y == Y))
            {
                PickUp();
            }
        }

        private void PickUp()
        {
            Inventory.AddToInventory(this);
            InInventory = true;
        }

        public override void Reset()
        {
            X = startX;
            Y = startY;
            InInventory = false;
        }
    }
}