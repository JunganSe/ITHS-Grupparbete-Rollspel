using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class LawnMower : IActiveObject
    {
        private int nextMove = 0;
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

        // Ställer sig på samma höjd eller bredd som spelaren, med ett stegs eftersläpning.
        private void FollowPlayer()
        {
            if (nextMove != 0)
            {
                if (HorizontalDirection)
                {
                    X += nextMove;
                }
                else
                {
                    Y += nextMove;
                }
            }
            if (((HorizontalDirection) && (X < Player.X) && (CheckFree(X + 1, Y)))
                || ((!HorizontalDirection) && (Y < Player.Y) && (CheckFree(Y + 1, Y))))
            {
                nextMove = 1;
            }
            else if (((HorizontalDirection) && (X > Player.X) && (CheckFree(X - 1, Y)))
                || ((!HorizontalDirection) && (Y > Player.Y) && (CheckFree(Y - 1, Y))))
            {
                nextMove = -1;
            }
            else
            {
                nextMove = 0;
            }
        }

        private void CheckPlayerKill()
        {
            if ((X == Player.X) && (Y == Player.Y))
            {
                // TODO: Någon visuell effekt?
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
