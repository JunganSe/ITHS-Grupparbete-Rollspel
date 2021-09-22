using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Rollspel
{
    public class Potatis : Item, IEdible, IKickable
    {
        private int startX;
        private int startY;
        private char symbol = 'O';
        private char symbolInvisible = ' ';

        public override char Symbol { get; set; } = 'O';
        public override int X { get; set; }
        public override int Y { get; set; }
        public override string Name { get; set; } = "Potatis";
        public bool InInventory { get; set; } = false;

        public Potatis(int x, int y)
        {
            startX = x;
            startY = y;
            Reset();
        }

        public override void Use()
        {
            Console.WriteLine("Kastar saken!");
            bool canPlace = false;
            while (!canPlace)
            {
                switch (Console.ReadKey(true).Key)
                {
                case ConsoleKey.UpArrow:
                    if (CheckFree(Player.X, Player.Y - 1))
                    {
                        canPlace = true;
                        X = Player.X;
                        Y = Player.Y - 1;
                        Symbol = symbol;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (CheckFree(Player.X, Player.Y + 1))
                    {
                        canPlace = true;
                        X = Player.X;
                        Y = Player.Y + 1;
                        Symbol = symbol;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (CheckFree(Player.X - 1, Player.Y))
                    {
                        canPlace = true;
                        X = Player.X - 1;
                        Y = Player.Y;
                        Symbol = symbol;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (CheckFree(Player.X + 1, Player.Y))
                    {
                        canPlace = true;
                        X = Player.X + 1;
                        Y = Player.Y;
                        Symbol = symbol;
                    }
                    break;
                case ConsoleKey.Escape:
                    // avbryt
                    return;
                }
            }
        }

        private bool CheckFree(int x, int y)
        {
            if (LevelHandler.CurrentLevel.Layout[x, y] == ' ')
            {
                return true;
            }
            return false;
        }

        private void PickUp()
        {
            Inventory.AddToInventory(this);
            InInventory = true;
            Symbol = symbolInvisible;
        }

        public override void Step()
        {
            if ((Player.X == X) && (Player.Y == Y) && (!InInventory))
            {
                PickUp();
            }
        }

        public override void Reset()
        {
            X = startX;
            Y = startY;
            InInventory = false;
        }
    }
}