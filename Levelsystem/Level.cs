using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class Level
    {
        public char[,] Layout { get; set; } // Hur kartan/banan ser ut.
        public bool CanAdvance { get; set; } = false; // Om vi kan gå till nästa level.
        public int StartX { get; set; } // Startposition för spelaren.
        public int StartY { get; set; } // Startposition för spelaren.
        public List<IActiveObject> ActiveObjects { get; set; } = new List<IActiveObject>(); // Lista med objekt som kör egen kod (på denna bana).

    }
}
