using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelHandler
    {
        public static List<Level> Levels { get; set; } = new List<Level>(); // Lista med alla spelets banor.
        public static Level CurrentLevel { get; set; }
        public static int Width { get; set; } = 60; // Banans bredd.
        public static int Height { get; set; } = 20; // Banans höjd.
        public static char[,] Layout { get;} = new char[Width, Height]; // Banlayouten som ska skickas in i en ny bana.

        public static void Initialize()
        {
            // Arbetsvariabler
            string name;
            string[] lines;
            int startX, startY;

            LevelMaker.Test(out name, out lines, out startX, out startY, out List<IActiveObject> activeObjects); // Skapa data utfrån LevelMaker.
            CurrentLevel = CreateLevel(name, lines, startX, startY, activeObjects); // Skickar datan in i en ny bana.
            
            DrawLevel(CurrentLevel, 25, 0); // Temporär
        }

        // Anropas varje gång spelaren tar ett steg.
        // Ritar banan och kör aktiva objekt.
        public static void Step()
        {
            DrawLevel(CurrentLevel, 25, 0);

            // Anropa step-metoden i alla aktiva objekt.
            foreach (var item in CurrentLevel.ActiveObjects)
            {
                item.Step();
            }
        }

        // Skapar en ny bana.
        // Returnerar objektet.
        private static Level CreateLevel(string name, string[] lines, int startX, int startY, List<IActiveObject> activeObjects)
        {
            // Omvandlar strängarna till char-array.
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Layout[x, y] = lines[y][x];
                }
            }

            // Skapa en ny bana och skicka in datan.
            Level level = new Level {
                Name = name,
                Layout = Layout, 
                StartX = startX, 
                StartY = startY,
                ActiveObjects = activeObjects };

            // Lägg till banan i listan med alla banor.
            Levels.Add(level);
            
            return level;
        }

        // Ritar banan.
        // Utvecklingsmetod, bör uppdateras för slutprodukten.
        // anchorX och anchorY är var på skärmen det ska ritas.
        private static void DrawLevel(Level level, int anchorX, int anchorY)
        {
            // Rita banan.
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(anchorX, anchorY + y);
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(level.Layout[x, y]);
                }
            }

            // Rita aktiva objekt.
            foreach (var item in level.ActiveObjects)
            {
                Console.SetCursorPosition(anchorX + item.X, anchorY + item.Y);
                Console.Write(item.Symbol);
            }
            Console.SetCursorPosition(0, anchorY + Height);
            Console.Write($"Level: {level.Name}");
        }
    }
}
