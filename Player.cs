using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownTest
{
    class Player
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public char Appereance { get; set; } = '@';
        public Room CurrentRoom { get; set; }

        public Player(int startingColumn, int startingRow, Room currentRoom)
        {
            // set players starting position
            Column = startingColumn;
            Row = startingRow;

            // attach room to player
            CurrentRoom = currentRoom;
        }

        public void GetInput()
        {
            // Look for input until legal input is provided
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (TryToMove(Column - 1, Row))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }                       
                    case ConsoleKey.RightArrow:
                        if (TryToMove(Column + 1, Row))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        if (TryToMove(Column, Row - 1))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (TryToMove(Column, Row + 1))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                }
            }
        }

        // check if a move is legal before performing it
        // arguments to this method should be the potential new position
        // for example for a move up the arguments should be (Column, Row - 1)
        public bool TryToMove(int requestedColumn, int requestedRow)
        {
            if (CurrentRoom.Map[requestedColumn, requestedRow] == ' ')
            {
                MakeMovement(requestedColumn, requestedRow);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MakeMovement(int newColumn, int newRow)
        {
            Console.SetCursorPosition(Column, Row);
            Console.Write(" ");
            Column = newColumn;
            Row = newRow;
            Console.SetCursorPosition(Column, Row);
            Console.Write(Appereance);
        }
    }
}