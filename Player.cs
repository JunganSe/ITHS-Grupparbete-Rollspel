using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownTest
{
    class Player
    {
        // the players position to be used on (char[,] Map) from the Room object
        public int Row { get; set; }
        public int Column { get; set; }

        // Tracks which Room object this player is related to (mainly to get access to the Map propertie)
        public Room CurrentRoom { get; set; }

        public Player(int row, int column)
        {
            // sets the players starting position
            Row = row;
            Column = column;
        }

        public void Input()
        {
            // get user inputs until legal input is provided
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                // up
                if (input.Key == ConsoleKey.UpArrow && MoveIsLegal(Row - 1, Column))
                {
                    CurrentRoom.Map[Row, Column] = ' ';
                    Row--;
                    return;
                }
                // down
                else if (input.Key == ConsoleKey.DownArrow && MoveIsLegal(Row + 1, Column))
                {
                    CurrentRoom.Map[Row, Column] = ' ';
                    Row++;
                    return;
                }
                // left
                else if (input.Key == ConsoleKey.LeftArrow && MoveIsLegal(Row, Column - 1))
                {
                    CurrentRoom.Map[Row, Column] = ' ';
                    Column--;
                    return;
                }
                // right
                else if (input.Key == ConsoleKey.RightArrow && MoveIsLegal(Row, Column + 1))
                {
                    CurrentRoom.Map[Row, Column] = ' ';
                    Column++;
                    return;
                }
            }
        }

        // check if a move is legal before performing it
        // arguments to this method should be the potential new position
        // for example for a move up the arguments should be (Row - 1, Column)
        public bool MoveIsLegal(int row, int column)
        {
            if (CurrentRoom.Map[row, column] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}