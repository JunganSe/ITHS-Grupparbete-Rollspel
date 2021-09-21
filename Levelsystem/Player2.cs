//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Rollspel
//{
//    public static class Player
//    {
//        public static char Symbol { get; set; } = '@';
//        public static int X { get; set; } = 30;
//        public static int Y { get; set; } = 10;
//        public static int Bonks { get; set; } = 0; // Hur många gånger man gått in i en vägg.

//        public static void Move() // Temporär för utveckling.
//        {
//            switch (Console.ReadKey(true).Key)
//            {
//            case ConsoleKey.LeftArrow:
//                X -= 1;
//                break;
//            case ConsoleKey.RightArrow:
//                X += 1;
//                break;
//            case ConsoleKey.UpArrow:
//                Y -= 1;
//                break;
//            case ConsoleKey.DownArrow:
//                Y += 1;
//                break;
//            }
//            while (Console.KeyAvailable)
//            {
//                Console.ReadKey(true);
//            }
//        }

//        public static void Kill() // TODO: Implementera
//        {
//            // Kod som körs när spelaren dör.
//        }
//    }
//}
