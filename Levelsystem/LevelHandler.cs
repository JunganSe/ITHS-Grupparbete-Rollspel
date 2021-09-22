using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelHandler
    {
        public static List<Level> Levels { get; set; } = new List<Level>(); // Lista med alla spelets banor.
        public static Level CurrentLevel { get; set; }
        public static int Width { get; } = 60; // Banans bredd.
        public static int Height { get; } = 20; // Banans höjd.
        public static int AnchorX { get; } = 30; // Sidoförskjutning när banan ritas.
        public static int AnchorY { get; } = 1; // Höjdförskjutning när banan ritas.

        // Körs en gång när spelet startar.
        public static void Initialize()
        {
            // Arbetsvariabler
            string name, message;
            string[] lines;
            int startX, startY;
            List<IActiveObject> activeObjects;

            LevelMaker.Test(out name, out message, out lines, out startX, out startY, out activeObjects); // Skapa data utfrån LevelMaker.
            CreateLevel(name, message, lines, startX, startY, activeObjects); // Skickar datan in i en ny bana.

            LevelMaker.Yard(out name, out message, out lines, out startX, out startY, out activeObjects);
            CreateLevel(name, message, lines, startX, startY, activeObjects);

            LevelMaker.Road(out name, out message, out lines, out startX, out startY, out activeObjects);
            CreateLevel(name, message, lines, startX, startY, activeObjects);

            CurrentLevel = Levels[0];
            Restart();
            DrawLevel(CurrentLevel); // För att undvika tom skärm innan man rört sig första gången.
        }

        // Går till en ny bana.
        public static void NextLevel()
        {
            if (CurrentLevel != Levels[Levels.Count - 1])
            {
                CurrentLevel = Levels[Levels.IndexOf(CurrentLevel) + 1];
                Console.Clear();
                Restart();
            }
            else
            {
                // TODO: Klara spelet!
                Console.SetCursorPosition(LevelHandler.AnchorX, 0); // Temp
                Console.WriteLine("Du klarade spelet!");            //
            }
        }

        public static void Restart()
        {
            PlayerTemp.X = CurrentLevel.StartX;
            PlayerTemp.Y = CurrentLevel.StartY;
            foreach (var item in CurrentLevel.ActiveObjects)
            {
                item.Reset();
            }
        }

        // Anropas varje gång spelaren tar ett steg.
        // Ritar banan och kör aktiva objekt.
        public static void Step()
        {
            // Anropa step-metoden i alla aktiva objekt.
            foreach (var item in CurrentLevel.ActiveObjects)
            {
                item.Step();
            }

            DrawLevel(CurrentLevel);
        }

        // Skapar en ny bana.
        // Returnerar objektet.
        private static Level CreateLevel(string name, string message, string[] lines, int startX, int startY, List<IActiveObject> activeObjects)
        {
            // Omvandlar strängarna till char-array.
            char[,] sendLayout = new char[Width, Height];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    sendLayout[x, y] = lines[y][x];
                }
            }

            // Skapa en ny bana och skicka in datan.
            Level level = new Level {
                Name = name,
                Message = message,
                Layout = sendLayout, 
                StartX = startX, 
                StartY = startY,
                ActiveObjects = new List<IActiveObject>(activeObjects) };

            // Lägg till banan i listan med alla banor.
            Levels.Add(level);
            
            return level;
        }

        // Ritar banan.
        // Utvecklingsmetod, bör uppdateras för slutprodukten.
        // anchorX och anchorY är var på skärmen det ska ritas.
        private static void DrawLevel(Level level)
        {
            // Rita banan.
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(AnchorX, AnchorY + y);
                string line = "";
                for (int x = 0; x < Width; x++)
                {
                    line += level.Layout[x, y];
                }
                Console.Write(line);
            }

            // Rita spelaren.
            Console.SetCursorPosition(AnchorX + PlayerTemp.X, AnchorY + PlayerTemp.Y);
            Console.Write(PlayerTemp.Symbol);

            // Rita aktiva objekt.
            foreach (var item in level.ActiveObjects)
            {
                Console.SetCursorPosition(AnchorX + item.X, AnchorY + item.Y);
                Console.Write(item.Symbol);
            }

            // Rita info om banan.
            Console.SetCursorPosition(49, 0);
            Console.Write($"Bana: {level.Name}    Steg: {level.Steps}");

            // Skriv ut banans meddelande.
            Console.SetCursorPosition(0, AnchorY + Height);
            Console.WriteLine(level.Message);
        }
    }
}
