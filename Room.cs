using System;

namespace TopDownTest
{
    class Room
    {
        public char[,] Map { get; set; }

        // this player that will interact with the Map propertie
        public Player CurrentPlayer { get; set; }

        public Room(int rows, int columns, Player player)
        {
            // assigns the player to this room
            CurrentPlayer = player;
            // creates the map
            Map = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // create top and bottom edges
                    if (i == 0 || i == Map.GetLength(0) - 1)
                    {
                        Map[i, j] = '=';
                    }
                    // create left and right edges
                    else if (j == 0 || j == Map.GetLength(1) - 1)
                    {
                        Map[i, j] = '|';
                    }
                    // create empty spaces
                    else
                    {
                        Map[i, j] = ' ';
                    }
                }
            }
        }

        public void Print()
        {
            Console.Clear();

            // adds the player to the map
            Map[CurrentPlayer.Row, CurrentPlayer.Column] = '@';
            // prints the map
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Console.Write(Map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
