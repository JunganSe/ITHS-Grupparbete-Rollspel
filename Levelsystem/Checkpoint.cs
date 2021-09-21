using System.Reflection.Metadata.Ecma335;

namespace Rollspel
{
    internal class Checkpoint : IActiveObject
    {


        public char Symbol { get; set; } = 'o';
        public int X { get; set; }
        public int Y { get; set; }
        public bool Open { get; set; } = false;
        public static int Counter = 0;



        public Checkpoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Step()
        {
            PointCounter();
        }

        public void PointCounter()
        {
            if ((X == Player.X - 1 || X == Player.X + 1) && (Y == Player.Y))
            {
                Counter++;
            }

        }



    }
}