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
                LevelHandler.Step();
            }

            Console.ReadLine();
        }
    }
}