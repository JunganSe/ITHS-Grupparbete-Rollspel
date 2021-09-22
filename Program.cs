using System;
using System.Collections.Generic;

=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Rollspel
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ConsoleCompanion();
          
            LevelHandler.Initialize();
            while (true)
            {
                Player.Move();
                LevelHandler.Step(); // Kanske bättre att anropa denna från Player.Move(), eftersom den bara ska köras om man faktiskt rör på sig.
            }


        }
    }
}