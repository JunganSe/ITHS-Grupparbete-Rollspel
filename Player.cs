using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownTest
{
    static class Player
    {
        public static int PositionX { get; set; }
        public static int PositionY { get; set; }

        public static char Appereance { get; set; } = '@';
        public static Room CurrentRoom { get; set; } // this gives Player access to the map (this might not be the best way?)
        public static int HeadInjuries { get; set; } = 0; // how many times the Player walked into the wall

        public static void GetInput()
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
                // waits until keys are available again before leaving the method
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
        }

        // check if a move can be made
        // arguments to this method should be the potential new position
        // for example for a move up the arguments should be (Column, Row - 1)
        public static bool TryToMove(int requestedX, int requestedY)
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

        public static void MakeMovement(int newX, int newY)
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(" ");
            PositionX = newX;
            PositionY = newY;
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Appereance);
        }

        public static void ResetPlayer()
        {
            PositionX = 3;
            PositionY = 3;
        }
    }
}