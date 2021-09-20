using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class Level
    {
        public char[,] Layout { get; set; } // Hur kartan ser ut när man först kommer dit.
        public bool CanAdvance { get; set; } = false; // Om vi kan gå till nästa level.
        public int StartX { get; set; } // Startposition för spelaren.
        public int StartY { get; set; } // Startposition för spelaren.
    }
}
