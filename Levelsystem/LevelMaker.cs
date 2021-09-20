using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelMaker
    {
        // Denna metod används ej, är bara en mall.
        private static void Template(out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            // Kopiera denna metod och döp om till banans namn.
            // Använd detta format för att designa en bana.
            // Se till att antalet tecken per rad stämmer med (LevelHandler.Width), och att antal rader stämmer med (LevelHandler.Height).
            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║                                                          ║";
            lines[02] = @"║                                                          ║";
            lines[03] = @"║                                                          ║";
            lines[04] = @"║                                                          ║";
            lines[05] = @"║                                                          ║";
            lines[06] = @"║                                                          ║";
            lines[07] = @"║                                                          ║";
            lines[08] = @"║                                                          ║";
            lines[09] = @"║                                                          ║";
            lines[10] = @"║                                                          ║";
            lines[11] = @"║                                                          ║";
            lines[12] = @"║                                                          ║";
            lines[13] = @"║                                                          ║";
            lines[14] = @"║                                                          ║";
            lines[15] = @"║                                                          ║";
            lines[16] = @"║                                                          ║";
            lines[17] = @"║                                                          ║";
            lines[18] = @"║                                                          ║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 1;
            startY = 1;

            // Lägg till alla aktiva objekt i denna lista.
            activeObjects = new List<IActiveObject>(); // Lista med objekt som kör egen kod (på denna bana).
            activeObjects.Add(new Exit(1, 1));
        }

        public static void Test(out string name, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Test";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║X                   ÖVRE RADEN                            ║";
            lines[02] = @"║ 1,1           \                                          ║";
            lines[03] = @"║                                                          ║";
            lines[04] = @"║                                                          ║";
            lines[05] = @"║V                _  ,/|                    Q              ║";
            lines[06] = @"║Ä               '\`o.O'   _                              H║";
            lines[07] = @"║N                =(_*_)= (                               Ö║";
            lines[08] = @"║S                  )U(  _)                               G║";
            lines[09] = @"║T                 /   \(                                 E║";
            lines[10] = @"║E                (/`-'\)                                 R║";
            lines[11] = @"║R                                           ¤ ¤          K║";
            lines[12] = @"║K                        ¤                  ¤ ¤          A║";
            lines[13] = @"║A             \n                                         N║";
            lines[14] = @"║N        \e                                              T║";
            lines[15] = @"║T             \t                                          ║";
            lines[16] = @"║                                                          ║";
            lines[17] = @"║                                                   58,18  ║";
            lines[18] = @"║                       NEDRE RADEN                       X║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 5;  // Spelarens startposition
            startY = 10; //

            activeObjects = new List<IActiveObject>(); // Lista med objekt som kör egen kod (på denna bana).
            activeObjects.Add(new Exit(58, 2));
            activeObjects.Add(new LawnMower(35, 12, true));
        }
    }
}
