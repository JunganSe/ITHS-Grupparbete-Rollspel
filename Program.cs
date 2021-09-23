using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Rollspel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Inventory.ItemList.Add(new Nyckel() { Name = "nyckel" });
            //Inventory.ItemList.Add(new Nyckel() { Name = "syckel" });
            //Inventory.ItemList.Add(new Nyckel() { Name = "myckel" });


            Inventory.PrintInventory();

            // Console.CursorVisible = false;
            var cc = new ConsoleCompanion();

            LevelHandler.Initialize();
            while (true)
            {
                Player.GetInput();
                LevelHandler.Step(); // TODO: Gör så att denna bara körs om spelaren flyttar sig.
            }


        }

        public static void DrawFrame(int x, int y, int width, int height)
        {
            char cornerTL = '╔', cornerTR = '╗', cornerBL = '╚', cornerBR = '╝', hor = '═', ver = '║';
            string line = "";

            line += cornerTL;
            for (int i = 0; i < width - 2; i++)
            {
                line += hor;
            }
            line += cornerTR;
            Console.SetCursorPosition(x, y);
            Console.Write(line);

            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(ver);
                Console.SetCursorPosition(x + width - 1, y + i);
                Console.Write(ver);
            }

            line = "";
            line += cornerBL;
            for (int i = 0; i < width - 2; i++)
            {
                line += hor;
            }
            line += cornerBR;
            Console.SetCursorPosition(x, y + height - 1);
            Console.Write(line);
        }
    }
}