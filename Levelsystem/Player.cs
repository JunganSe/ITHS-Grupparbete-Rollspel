using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class Player
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Bonks { get; set; } = 0; // Hur många gånger man gått in i en vägg.

        public static void Kill() // TODO: Implementera
        {
            // Kod som körs när spelaren dör.
        }
    }
}
