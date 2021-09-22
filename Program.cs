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
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.ItemList.Add(new Nyckel() { Name = "nyckel" });
            Inventory.ItemList.Add(new Nyckel() { Name = "cyckel" });
            Inventory.ItemList.Add(new Nyckel() { Name = "myckel" });


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
    }
}