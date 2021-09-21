using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace TopDownTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a room with a player
            Room room = new Room(60, 20, 5, 5);
            Player.CurrentRoom = room;

            room.PrintMap();
            while (true)
            {
                Player.GetInput();
            }
        }
    }
}