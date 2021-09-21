using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Rollspel
{
    public class Potatis : Item, IEdible, IKickable
    {

        public Potatis()
        {

        }

        public Potatis(string name)
        {
            Name = name;
        }

        public override void Use()
        {
            Console.WriteLine("Äter saken!");
        }


    }




}