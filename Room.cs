using System;

namespace Rollspel
{
    static class Room
    {
        public static char[,] Map { get; set; }
        public static int MapWidth { get; set; } = 60;
        public static int MapHeight { get; set; } = 20;

        public static char[,] InventorySpace { get; set; }

        public static void CreateMap(int width, int height)
        {
            Map = new char[width, height]; 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // top and bottom edges
                    if (y == 0 || y == height - 1)
                    {
                        Map[x, y] = '─';
                    }
                    // left and right edges
                    else if (x == 0 || x == width - 1)
                    {
                        Map[x, y] = '│';
                    }
                    // empty space
                    else
                    {
                        Map[x, y] = ' ';
                    }
                }
            }
            // corners
            Map[0, 0] = '┌';
            Map[width - 1, 0] = '┐';
            Map[0, height - 1] = '└';
            Map[width - 1, height - 1] = '┘';
        }
        public static void PrintMap()
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                for (int x = 0; x < Map.GetLength(0); x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(Map[x, y]);
                }
            }
            Console.SetCursorPosition(Player.PositionX, Player.PositionY);
            Console.Write(Player.Appereance);
        }

        public static void CreateInventorySpace(int width, int height)
        {
            InventorySpace = new char[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // top and bottom edges
                    if (y == 0 || y == height - 1)
                    {
                        InventorySpace[x, y] = '─';
                    }
                    // left and right edges
                    else if (x == 0 || x == width - 1)
                    {
                        InventorySpace[x, y] = '│';
                    }
                    // empty space
                    else
                    {
                        InventorySpace[x, y] = ' ';
                    }
                }
            }
            // corners
            InventorySpace[0, 0] = '┌';
            InventorySpace[width - 1, 0] = '┐';
            InventorySpace[0, height - 1] = '└';
            InventorySpace[width - 1, height - 1] = '┘';
        }

        public static void PrintInventorySpace()
        {
            for (int y = 0; y < InventorySpace.GetLength(1); y++)
            {
                for (int x = 0; x < InventorySpace.GetLength(0); x++)
                {
                    Console.SetCursorPosition(x, y + MapHeight);
                    Console.Write(InventorySpace[x, y]);
                }
            }
        }
    }
}
