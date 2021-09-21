using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    internal class Nyckel : Item
    {








        public Nyckel()
        {

        }

        public Nyckel(string name)
        {
            Name = name;
        }

        public override void Use()
        {
            Console.WriteLine("Kastar saken!");
        }
    }
}