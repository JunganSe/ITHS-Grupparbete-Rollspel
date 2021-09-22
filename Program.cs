using System;

namespace Rollspel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LevelHandler.Initialize();

            while (true)
            {
                PlayerTemp.Move();
                LevelHandler.Step(); // Kanske bättre att anropa denna från Player.Move(), eftersom den bara ska köras om man faktiskt rör på sig.
            }

        }
    }
}