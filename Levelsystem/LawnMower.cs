using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class LawnMower : IActiveObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool HorizontalDirection { get; set; }

        public LawnMower(int x, int y, bool horizontalDirection)
        {
            X = x;
            Y = y;
            HorizontalDirection = horizontalDirection;
        }

        public void Step()
        {
            FollowPlayer();
            KillPlayer();
        }

        private void FollowPlayer()
        {
            if (HorizontalDirection) // Jämför med spelaren och flytta i sidled för att matcha dens x-värde, om platsen är ledig.
            {
                if (X < Player.X)
                {
                    if (true) // TODO: Kolla om (x+1, y) är tom.
                    {
                        X += 1;
                    }
                }
                else if (X > Player.X)
                {
                    if (true) // TODO: Kolla om (x-1, y) är tom.
                    {
                        X -= 1;
                    }
                }
            }
            else // Samma men vertikalt.
            {
                if (Y < Player.Y) // TODO: Kolla om (x, y+1) är tom.
                {
                    if (true)
                    {
                        Y += 1;
                    }
                }
                else if (Y > Player.Y)
                {
                    if (true) // TODO: Kolla om (x, y-1) är tom.
                    {
                        Y -= 1;
                    }
                }
            }
        }

        private void KillPlayer() // TODO: Gör färdigt, alternativt hantera detta i spelarklassen.
        {
            if ((X == Player.X) && (Y == Player.Y))
            {
                // Kod som tar död på spelaren och börjar om banan.
            }
        }
    }
}
