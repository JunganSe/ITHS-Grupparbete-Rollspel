using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownTest
{
    class Player
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public char Appereance { get; set; } = '@';
        public Room CurrentRoom { get; set; }         // to get access to the layout of the map

        public Player(int x, int y, Room currentRoom)
        {
            // set players starting position
            PositionX = x;
            PositionY = y;

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
                        if (TryToMove(PositionX - 1, PositionY))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }                       
                    case ConsoleKey.RightArrow:
                        if (TryToMove(PositionX + 1, PositionY))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        if (TryToMove(PositionX, PositionY - 1))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (TryToMove(PositionX, PositionY + 1))
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

        // check if a move can be made
        // arguments to this method should be the potential new position
        // for example for a move up the arguments should be (Column, Row - 1)
        public bool TryToMove(int requestedX, int requestedY)
        {
            switch (CurrentRoom.Map[requestedX, requestedY])
            {
                case ' ':
                    MakeMovement(requestedX, requestedY);
                    return true;
                case 'P':
                    // (Exempel)
                    // en person som man kan prata med, förflyttningen görs inte men dialog alternativ kommer upp
                    // Talk()
                    return false;
                case 'K':
                    // (Exempel)
                    // genomflyttningen görs och spelaren plockar upp saken:
                    // Inventory.Add("key")
                    MakeMovement(requestedX, requestedY);
                    return true;
                default:
                    return false;
            }
        }

        public void MakeMovement(int newX, int newY)
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(" ");
            PositionX = newX;
            PositionY = newY;
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Appereance);
        }
    }
}