using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class LawnMower : IActiveObject
    {
        public char Symbol { get; set; } = 'G';
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
            CheckPlayerKill();
        }

        private void FollowPlayer()
        {
            if (HorizontalDirection) // Jämför med spelaren och flytta i sidled för att matcha dens x-värde, om platsen är ledig.
            {
                if (X < Player.X)
                {
                    if (CheckFree(X + 1, Y))
                    {
                        X += 1;
                    }
                }
                else if (X > Player.X)
                {
                    if (CheckFree(X - 1, Y))
                    {
                        X -= 1;
                    }
                }
            }
            else // Samma men vertikalt.
            {
                if (Y < Player.Y)
                {
                    if (CheckFree(X, Y + 1))
                    {
                        Y += 1;
                    }
                }
                else if (Y > Player.Y)
                {
                    if (CheckFree(X, Y - 1))
                    {
                        Y -= 1;
                    }
                }
            }
        }

        private void CheckPlayerKill()
        {
            if ((X == Player.X) && (Y == Player.Y))
            {
                // TODO: Någon effekt?
                Player.Kill();
            }
        }

        // Troligtvis temporär, bättre att använda en universell metod.
        private bool CheckFree(int x, int y)
        {
            if (LevelHandler.CurrentLevel.Layout[x, y] == ' ')
            {
                return true;
            }
            return false;
        }
    }
}
