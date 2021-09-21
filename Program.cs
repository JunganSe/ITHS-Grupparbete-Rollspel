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
            var cc = new ConsoleCompanion();

            Console.CursorVisible = false;

            Room.CreateMap(60, 20);
            Room.PrintMap();

            Room.CreateInventorySpace(30, 10);
            Room.PrintInventorySpace();

            Nyckel k = new Nyckel();
            k.Name = "Nyckel till källare";
            Inventory.ItemList.Add(k);
            Inventory.PrintInventory();

            while (true)
            {
                Player.GetInput();
            }
        }
    }
}