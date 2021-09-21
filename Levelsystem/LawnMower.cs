using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public class LawnMower : IActiveObject
    {
        private int startX;
        private int startY;
        private int nextMove = 0;

        public char Symbol { get; set; } = 'G';
        public int X { get; set; }
        public int Y { get; set; }
        public bool Horizontal { get; set; }

        public LawnMower(int x, int y, bool horizontal)
        {
            startX = x;
            startY = y;
            Horizontal = horizontal;
            Reset();
        }

        public void Reset()
        {
            X = startX;
            Y = startY;
            nextMove = 0;
        }

        public void Step()
        {
            CheckPlayerKill();
            FollowPlayer();
            CheckPlayerKill();
        }

        // Ställer sig på samma höjd eller bredd som spelaren, med ett stegs eftersläpning.
        private void FollowPlayer()
        {
            if (nextMove != 0)
            {
                if (Horizontal)
                {
                    X += nextMove;
                }
                else
                {
                    Y += nextMove;
                }
            }
            if (((Horizontal) && (X < Player.X) && (CheckFree(X + 1, Y)))
                || ((!Horizontal) && (Y < Player.Y) && (CheckFree(Y + 1, Y))))
            {
                nextMove = 1;
            }
            else if (((Horizontal) && (X > Player.X) && (CheckFree(X - 1, Y)))
                || ((!Horizontal) && (Y > Player.Y) && (CheckFree(Y - 1, Y))))
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
