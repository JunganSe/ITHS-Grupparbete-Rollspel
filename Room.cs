using System;

namespace TopDownTest
{
    class Room
    {
        public char[,] Map { get; set; }

        // this player that will interact with the Map propertie
        public Player CurrentPlayer { get; set; }

        public Room(int columns, int rows, int playerColumn, int playerRow)
        {
            Console.CursorVisible = false;
            // assigns the player to this room
            CurrentPlayer = new Player(playerColumn, playerRow, this);
            // creates the map
            CreateMap(columns, rows);
        }

        public void CreateMap(int columns, int rows)
        {
            Map = new char[columns, rows]; 
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    // top and bottom edges
                    if (y == 0 || y == rows - 1)
                    {
                        Map[x, y] = '─';
                    }
                    // left and right edges
                    else if (x == 0 || x == columns - 1)
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
            Map[columns - 1, 0] = '┐';
            Map[0, rows - 1] = '└';
            Map[columns - 1, rows - 1] = '┘';
        }
        public void PrintMap()
        {
            for (int y = 0; y < Map.GetLength(1); y++)
            {
                for (int x = 0; x < Map.GetLength(0); x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(Map[x, y]);
                }
            }
            Console.SetCursorPosition(CurrentPlayer.Column, CurrentPlayer.Row);
            Console.Write(CurrentPlayer.Appereance);
        }
    }
}
