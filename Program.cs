using System;
using System.Collections.Generic;

namespace Rollspel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cc = new ConsoleCompanion();


            Inventory.PrintInventory(Inventory.GetList());

            Potatis potatis = new Potatis("potät");
            Console.WriteLine($"Du har hittat en {potatis.Name}! Vill du plocka upp {potatis.Name}? Tryck 1 för 'Ja' och 2 för 'Nej");
            int input = int.Parse(Console.ReadLine());

            Inventory.AddToInventory(input, potatis);







        }
    }
}