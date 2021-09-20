using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelMaker
    {
        public static string[] Lines { get; set; } = new string[LevelHandler.Height]; // Strängar som används vid bandesignen.

        // Används ej, bara en mall.
        private static string[] Template()
        {
            // Kopiera denna metod och döp om.
            // Använd detta format för att designa en bana.
            // Se till att antalet tecken per rad stämmer med Width, och att antal rader stämmer med Height (i LevelHandler).
            Lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            Lines[01] = @"║                                                          ║";
            Lines[02] = @"║                                                          ║";
            Lines[03] = @"║                                                          ║";
            Lines[04] = @"║                                                          ║";
            Lines[05] = @"║                                                          ║";
            Lines[06] = @"║                                                          ║";
            Lines[07] = @"║                                                          ║";
            Lines[08] = @"║                                                          ║";
            Lines[09] = @"║                                                          ║";
            Lines[10] = @"║                                                          ║";
            Lines[11] = @"║                                                          ║";
            Lines[12] = @"║                                                          ║";
            Lines[13] = @"║                                                          ║";
            Lines[14] = @"║                                                          ║";
            Lines[15] = @"║                                                          ║";
            Lines[16] = @"║                                                          ║";
            Lines[17] = @"║                                                          ║";
            Lines[18] = @"║                                                          ║";
            Lines[19] = @"╚══════════════════════════════════════════════════════════╝";
            return Lines;
        }

        public static string[] Test()
        {
            // Testlevel 1
            Lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            Lines[01] = @"║X                   ÖVRE RADEN                            ║";
            Lines[02] = @"║ 1,1           \                                          ║";
            Lines[03] = @"║                                                          ║";
            Lines[04] = @"║              X                                           ║";
            Lines[05] = @"║V                _  ,/|                    Q              ║";
            Lines[06] = @"║Ä               '\`o.O'   _                              H║";
            Lines[07] = @"║N                =(_*_)= (                               Ö║";
            Lines[08] = @"║S                  )U(  _)                               G║";
            Lines[09] = @"║T                 /   \(                                 E║";
            Lines[10] = @"║E                (/`-'\)                                 R║";
            Lines[11] = @"║R                                           ¤ ¤          K║";
            Lines[12] = @"║K                                           ¤ ¤          A║";
            Lines[13] = @"║A             \n                                         N║";
            Lines[14] = @"║N                                                        T║";
            Lines[15] = @"║T             \t                                          ║";
            Lines[16] = @"║                                                          ║";
            Lines[17] = @"║                                                   58,18  ║";
            Lines[18] = @"║                       NEDRE RADEN                       X║";
            Lines[19] = @"╚══════════════════════════════════════════════════════════╝";
            return Lines;
        }
    }
}
