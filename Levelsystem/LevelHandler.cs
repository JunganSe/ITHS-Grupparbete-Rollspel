using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelHandler
    {
        public static List<Level> Levels = new List<Level>(); // Lista med alla spelets banor.
        public static int Width { get; set; } = 60; // Banans bredd.
        public static int Height { get; set; } = 20; // Banans höjd.
        public static char[,] SendLayout { get; set; } = new char[Width, Height]; // Banlayouten som ska skickas in i en ny bana.
        public static string[] Lines { get; set; } = new string[Height]; // Strängar som används vid bandesignen.

        public static void InitializeLevels()
        {
            // Se till att antalet tecken per rad stämmer med Width, och att antal rader stämmer med Height.
            Lines[0] =  " ---------------------------------------------------------- ";
            Lines[1] =  "|                    ÖVRE RADEN                            |";
            Lines[2] =  "|                                                          |";
            Lines[3] =  "|                                                          |";
            Lines[4] =  "|                                                          |";
            Lines[5] =  "|V                                                         |";
            Lines[6] =  "|Ä                                                        H|";
            Lines[7] =  "|N                                                        Ö|";
            Lines[8] =  "|S                                                        G|";
            Lines[9] =  "|T                       MITTTEN                          E|";
            Lines[10] = "|E                                                        R|";
            Lines[11] = "|R                                                        K|";
            Lines[12] = "|K                                                        A|";
            Lines[13] = "|A                                                        N|";
            Lines[14] = "|N                                                        T|";
            Lines[15] = "|T           TEST TEST TEST TEST TEST TEST                 |";
            Lines[16] = "|                                                          |";
            Lines[17] = "|                                                          |";
            Lines[18] = "|                       NEDRE RADEN                        |";
            Lines[19] = " ---------------------------------------------------------- ";
            Level level = CreateLevel(Lines, 5, 1);

            DrawLevel(level, 0, 0);
        }

        // Fyller layouten med mellanslag. Överflödig?
        public static void ClearLayout()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    SendLayout[x, y] = ' ';
                }
            }
        }

        // Omvandlar strängarna till en char-array.
        // Skapar ett nytt level-objekt med layouten.
        // Ställer vald startposition för banan.
        // Returnerar objektet.
        public static Level CreateLevel(string[] lines, int startX, int startY)
        {
            ClearLayout();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    SendLayout[x, y] = lines[y][x];
                }
            }
            Level level = new Level { Layout = SendLayout, StartX = startX, StartY = startY };
            Levels.Add(level);
            return level;
        }

        // Utvecklingsmetod, bör uppdateras för slutprodukten.
        // anchorX och anchorY är var på skärmen det ska ritas.
        public static void DrawLevel(Level level, int anchorX, int anchorY)
        {
            Console.SetCursorPosition(anchorX, anchorY);
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(level.Layout[x, y]);
                }
                Console.SetCursorPosition(anchorX, anchorY + y + 1);
            }
        }

        // Utvecklingsmetod, andvänds inte i slutprodukten.
        public static void DrawLayout() // TODO: ta bort?
        {
            ClearLayout();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    SendLayout[x, y] = Lines[y][x];
                }
            }
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(SendLayout[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
