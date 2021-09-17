using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leo testing prototypes of class Player and Class Room


            // a Player object keeps track of the player marker position and can take input from user
            Player playerAtBegining = new Player(2, 2);

            // a Room object has a char[,] (the map) which it can also print 
            Room startingRoom = new Room(10, 10, playerAtBegining);

            // The Player class needs a Room object because it needs to ha access to the char[,] (the map) 
            playerAtBegining.CurrentRoom = startingRoom;

            // Testing a obstacle, a point in the char[,] that cant be occupied by the player
            startingRoom.Map[7, 7] = '+';

            while (true)
            {
                startingRoom.Print();
                playerAtBegining.Input();
            }
        }
    }
}