using System;
using System.Collections.Generic;

namespace Rollspel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cc = new ConsoleCompanion();


            Inventory.PrintInventory();
            bool play = true;

            //Skapa objekt för test, helt irrelevant för slutprodukt

            var matlista = new List<Item>();
            Potatis potat1s = new Potatis("Potatis1");
            Potatis potat2s = new Potatis("Potatis2");
            Potatis potat3s = new Potatis("Potatis3");
            Potatis potat4s = new Potatis("Potatis4");
            Potatis potat5s = new Potatis("Potatis5");
            Nyckel nyckel1 = new Nyckel("Nyckel1");
            Nyckel nyckel2 = new Nyckel("Nyckel2");
            Nyckel nyckel3 = new Nyckel("Nyckel3");
            Nyckel nyckel4 = new Nyckel("Nyckel4");
            Nyckel nyckel5 = new Nyckel("Nyckel5");
            matlista.Add(potat5s);
            matlista.Add(potat4s);
            matlista.Add(potat3s);
            matlista.Add(potat2s);
            matlista.Add(potat1s);
            matlista.Add(nyckel1);
            matlista.Add(nyckel2);
            matlista.Add(nyckel3);
            matlista.Add(nyckel4);
            matlista.Add(nyckel5);

            do
            {
                var random = new Random();
                int randomindex = random.Next(matlista.Count);

                Console.WriteLine($"Du har hittat en {matlista[randomindex].Name}! Vill du plocka upp {matlista[randomindex].Name}? Tryck 1 för 'Ja' och 2 för 'Nej");
                int input = int.Parse(Console.ReadLine());

                Inventory.AddToInventory(input, matlista[randomindex]);



            }
            while (play);









        }
    }
}