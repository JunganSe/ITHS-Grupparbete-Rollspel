using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelMaker
    {
        // Denna metod används ej, är bara en mall.
        private static void Template(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            // Kopiera denna metod och döp om till banans namn. Gör public.
            // Använd detta format för att designa en bana.
            // Se till att antalet tecken per rad stämmer med (LevelHandler.Width), och att antal rader stämmer med (LevelHandler.Height).

            name = "Namnlös bana";
            message = "Den här texten kommer upp på skärmen när man går in i banan.";

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

            startX = 29; // Spelarens startposition
            startY = 18; //

            // Lägg till alla aktiva objekt i denna lista.
            activeObjects = new List<IActiveObject>(); // Lista med objekt som kör egen kod (på denna bana).
            activeObjects.Add(new Exit(1, 1));
        }

        public static void Test(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Test";
            message = "Detta är bara en testbana.";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║X                   ÖVRE RADEN                            ║";
            lines[02] = @"║ 1,1                                                      ║";
            lines[03] = @"║                                                          ║";
            lines[04] = @"║                                                          ║";
            lines[05] = @"║V                                                         ║";
            lines[06] = @"║Ä                                                        H║";
            lines[07] = @"║N                                                        Ö║";
            lines[08] = @"║S                                                        G║";
            lines[09] = @"║T                                                        E║";
            lines[10] = @"║E                                                        R║";
            lines[11] = @"║R                                           ¤ ¤          K║";
            lines[12] = @"║K                                           ¤ ¤          A║";
            lines[13] = @"║A                                                        N║";
            lines[14] = @"║N                                                        T║";
            lines[15] = @"║T                                                         ║";
            lines[16] = @"║                                                          ║";
            lines[17] = @"║                                                   58,18  ║";
            lines[18] = @"║                       NEDRE RADEN                       X║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 5;
            startY = 10;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(58, 2));
            activeObjects.Add(new Nyckel(30, 10));
            activeObjects.Add(new Potatis(20, 10));
        }

        public static void Yard(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Trädgård";
            message = "Du kommer ut ur huset och sätter fötterna på gräsmattan. Flera av grannskapets gräsklippare verkar ha samlats just här.\n" +
                "De verkar samtala med varandra med ett dovt tomgångsljud. Tvåtaktarna verkar lite upprörda, kanske är det bara åldern\n" +
                "som gör dem vresiga. Gräsklipparna verkar uppmärksamma att du är här, och närmar sig för att blockera din väg...";

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
            lines[09] = @"║                       DENNA BANA                         ║";
            lines[10] = @"║                       ÄR EJ KLAR                         ║";
            lines[11] = @"║                                                          ║";
            lines[12] = @"║                                                          ║";
            lines[13] = @"║                                                          ║";
            lines[14] = @"║                                                          ║";
            lines[15] = @"║                                                          ║";
            lines[16] = @"║                                                          ║";
            lines[17] = @"║                                                          ║";
            lines[18] = @"║                                                          ║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 29;
            startY = 18;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(58, 1));
            activeObjects.Add(new LawnMower(35, 12, true));
            activeObjects.Add(new LawnMower(35, 14, true));
            activeObjects.Add(new LawnMower(35, 16, true));
            activeObjects.Add(new LawnMower(15, 10, false));
            activeObjects.Add(new LawnMower(18, 10, false));
            activeObjects.Add(new LawnMower(21, 10, false));
        }

        public static void Road(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Väg";
            message = "Du står vid en väg som är hårt trafikerad av katter.\n" +
                "Det finns inga övergångsställen eller trafikljus i närheten,\n" +
                "så du får försöka ta dig över utan att bli påsprungen.\n" +
                "Eftersom du är lite rädd för väglinjer så känner du att du måste gå mellan dem.";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║                                                          ║";
            lines[02] = @"║                                                          ║";
            lines[03] = @"║                                                          ║";
            lines[04] = @"║                                                          ║";
            lines[05] = @"║                                                          ║";
            lines[06] = @"║── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ─║";
            lines[07] = @"║                                                          ║";
            lines[08] = @"║                                                          ║";
            lines[09] = @"║- - - - - - - - - - - - - - - - - - - - - - - - - - - - - ║";
            lines[10] = @"║                                                          ║";
            lines[11] = @"║                                                          ║";
            lines[12] = @"║── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ─║";
            lines[13] = @"║                                                          ║";
            lines[14] = @"║                                                          ║";
            lines[15] = @"║                                                          ║";
            lines[16] = @"║                                                          ║";
            lines[17] = @"║                                                          ║";
            lines[18] = @"║                                                          ║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 29;
            startY = 18;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(29, 1));

            activeObjects.Add(new CatCar(16, 7, -2)); activeObjects.Add(new CatCar(17, 7, -2));
            activeObjects.Add(new CatCar(26, 7, -2)); activeObjects.Add(new CatCar(27, 7, -2));
            activeObjects.Add(new CatCar(33, 7, -2)); activeObjects.Add(new CatCar(34, 7, -2));
            activeObjects.Add(new CatCar(46, 7, -2)); activeObjects.Add(new CatCar(47, 7, -2));
            activeObjects.Add(new CatCar(56, 7, -2)); activeObjects.Add(new CatCar(57, 7, -2));
            activeObjects.Add(new CatCar(15, 8, -3)); activeObjects.Add(new CatCar(16, 8, -3)); activeObjects.Add(new CatCar(17, 8, -3));
            activeObjects.Add(new CatCar(25, 8, -3)); activeObjects.Add(new CatCar(26, 8, -3)); activeObjects.Add(new CatCar(27, 8, -3));
            activeObjects.Add(new CatCar(55, 8, -3)); activeObjects.Add(new CatCar(56, 8, -3)); activeObjects.Add(new CatCar(57, 8, -3));
            activeObjects.Add(new CatCar(2, 10, 3)); activeObjects.Add(new CatCar(3, 10, 3)); activeObjects.Add(new CatCar(4, 10, 3));
            activeObjects.Add(new CatCar(22, 10, 3)); activeObjects.Add(new CatCar(23, 10, 3)); activeObjects.Add(new CatCar(24, 10, 3));
            activeObjects.Add(new CatCar(39, 10, 3)); activeObjects.Add(new CatCar(40, 10, 3)); activeObjects.Add(new CatCar(41, 10, 3));
            activeObjects.Add(new CatCar(2, 11, 2)); activeObjects.Add(new CatCar(3, 11, 2));
            activeObjects.Add(new CatCar(22, 11, 2)); activeObjects.Add(new CatCar(23, 11, 2));
            activeObjects.Add(new CatCar(37, 11, 2)); activeObjects.Add(new CatCar(38, 11, 2));
            activeObjects.Add(new CatCar(42, 11, 2)); activeObjects.Add(new CatCar(43, 11, 2));
            activeObjects.Add(new CatCar(52, 11, 2)); activeObjects.Add(new CatCar(53, 11, 2));
        }
        public static void LeoTest(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Test";
            message = "Detta är bara en testbana.";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║ E      |                       T           T           N ║";
            lines[02] = @"║        D                             m                   ║";
            lines[03] = @"║        |                       . m       m .             ║";
            lines[04] = @"║---------                     m       m       m           ║";
            lines[05] = @"║                                  m       m               ║";
            lines[06] = @"║                              m .     m     . m           ║";
            lines[07] = @"║            m m m m               m       m               ║";
            lines[08] = @"║           m m m m m          m       m       m           ║";
            lines[09] = @"║           m       m              m       m               ║";
            lines[10] = @"║          m    m    m         m .     m     . m           ║";
            lines[11] = @"║           m   m   m              m       m               ║";
            lines[12] = @"║          m    m    m         m       m       m           ║";
            lines[13] = @"║-----------    m                  m       m               ║";
            lines[14] = @"║               m              m       m       m           ║";
            lines[15] = @"║               |                . m       m .             ║";
            lines[16] = @"║               |              m       m       m           ║";
            lines[17] = @"║               |                  m       m               ║";
            lines[18] = @"║  //start      |                      m                   ║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";

            startX = 5;
            startY = 10;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(1, 1));
            activeObjects.Add(new Nyckel(60, 1));
            activeObjects.Add(new Potatis(20, 10));
        }
    }
}
