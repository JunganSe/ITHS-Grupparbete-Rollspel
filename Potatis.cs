using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class Potatis : Item, IsEdible, IsKickable
    {

        public Potatis()
        {

        }

        public Potatis(string name)
        {
            Name = name;
        }


    }




}