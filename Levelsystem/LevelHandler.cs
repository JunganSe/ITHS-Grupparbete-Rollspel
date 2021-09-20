﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelHandler
    {
        public static List<Level> Levels { get; set; } = new List<Level>(); // Lista med alla spelets banor.
        public static int Width { get; set; } = 60; // Banans bredd.
        public static int Height { get; set; } = 20; // Banans höjd.
        public static char[,] SendLayout { get;} = new char[Width, Height]; // Banlayouten som ska skickas in i en ny bana.

        public static void Initialize()
        {
            Level level = CreateLevel(LevelMaker.Test(), 5, 1);
            level.Layout[20, 15] = 'K'; // Testrad, stoppar in ett tecken i efterhand.

            DrawLevel(level, 25, 0); // Temporär
        }

        // Fyller layouten med mellanslag. Överflödig?
        private static void ClearLayout()
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
        // Ställer vald startposition för spelaren på denna bana.
        // Returnerar objektet.
        private static Level CreateLevel(string[] lines, int startX, int startY)
        {
            ClearLayout(); // Överflödig?

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    SendLayout[x, y] = lines[y][x];
                }
            }
            Level level = new Level { 
                Layout = SendLayout, 
                StartX = startX, 
                StartY = startY };
            Levels.Add(level);
            return level;
        }

        private static bool CheckLevel(Level level)
        {


            return false;
        }

        // Ritar banan.
        // Utvecklingsmetod, bör uppdateras för slutprodukten.
        // anchorX och anchorY är var på skärmen det ska ritas.
        private static void DrawLevel(Level level, int anchorX, int anchorY)
        {
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(anchorX, anchorY + y);
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(level.Layout[x, y]);
                }
            }
        }
    }
}
