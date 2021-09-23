using System.Collections.Generic;

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
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

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
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

            startX = 5;
            startY = 10;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(58, 2));
            activeObjects.Add(new Nyckel(30, 8));
            activeObjects.Add(new Potatis(16, 10));
            activeObjects.Add(new Potatis(18, 10));
            activeObjects.Add(new Potatis(20, 10));
            activeObjects.Add(new Potatis(22, 10));
            activeObjects.Add(new Potatis(24, 10));
            activeObjects.Add(new Potatis(26, 10));
            activeObjects.Add(new Potatis(28, 10));
            activeObjects.Add(new Potatis(30, 10));
        }

        public static void Yard(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Trädgård";
            message = "Du kommer ut ur huset och sätter fötterna på gräsmattan. Flera av grannskapets gräsklippare verkar ha samlats just här.\n" +
                "De verkar samtala med varandra med ett dovt tomgångsljud. Tvåtaktarna verkar lite upprörda, kanske är det bara åldern\n" +
                "som gör dem vresiga. Gräsklipparna verkar uppmärksamma att du är här, och närmar sig för att blockera din väg...";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║               ____             #                         ║";
            lines[02] = @"║            __/    \_           #                         ║";
            lines[03] = @"║           '-Ö----Ö-'           #                         ║";
            lines[04] = @"║                                #                         ║";
            lines[05] = @"║      __                        #                         ║";
            lines[06] = @"║   ||/  \                       #                         ║";
            lines[07] = @"║   |/    \                                                ║";
            lines[08] = @"║   /   _  \                                               ║";
            lines[09] = @"║   |  |_| |                     #           ________      ║";
            lines[10] = @"║   |      |                     #          /|__| | |\     ║";
            lines[11] = @"║###|______|###                  #         |      |_| \___.║";
            lines[12] = @"║                                #         '-----Ö----'    ║";
            lines[13] = @"║                                #                         ║";
            lines[14] = @"║                                #                         ║";
            lines[15] = @"║                                #                         ║";
            lines[16] = @"║                                #                         ║";
            lines[17] = @"║                                #                         ║";
            lines[18] = @"║                                #                         ║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

            startX = 15;
            startY = 18;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(45, 1));
            activeObjects.Add(new Potatis(6, 13));
            activeObjects.Add(new Potatis(3, 4));
            activeObjects.Add(new Potatis(40, 12));
            activeObjects.Add(new Potatis(48, 17));
            activeObjects.Add(new Potatis(55, 18));
            activeObjects.Add(new LawnMower(28, 10, true));
            activeObjects.Add(new LawnMower(35, 17, false));
            activeObjects.Add(new LawnMower(57, 3, true));
            activeObjects.Add(new LawnMower(50, 4, true));
            activeObjects.Add(new LawnMower(42, 16, true));
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
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

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

        public static void Labyrint(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            name = "Labyrint";
            message = "Samla 3 poäng genom att ringa på dörrklockorna, och gå sen till utgången.\n" + "Låt bli att gå in i väggarna, och undvik att gå vilse!";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║##########################################################║";
            lines[02] = @"║       ### ######                 ##############     #####║";
            lines[03] = @"║###### ##    #### ############### ########       ### #####║";
            lines[04] = @"║###### ## ## ####       ######### ######## ######### ###  ║";
            lines[05] = @"║###### ##### ########## ######### ##### ## #########     #║";
            lines[06] = @"║###### ###      ####### ######### ##### ## ########## ####║";
            lines[07] = @"║###### ### #### ####### ######### ##### ## ########## ####║";
            lines[08] = @"║###### ######## #####         ###       ##       #### ####║";
            lines[09] = @"║######             ##         ############# ####      ####║";
            lines[10] = @"║################## ##         ############# #### #########║";
            lines[11] = @"║################## ###### #################    # #########║";
            lines[12] = @"║###           #### ######               ###### # #########║";
            lines[13] = @"║### ######### #### ####################             ######║";
            lines[14] = @"║### #########      #################### ##### ##### ######║";
            lines[15] = @"║### ############## #################### ##### #####       ║";
            lines[16] = @"║###         ######                      ##### ############║";
            lines[17] = @"║########### #################################          ###║";
            lines[18] = @"║########### ##############################################║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

            startX = 26;
            startY = 10;

            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Checkpoint(58, 4));
            activeObjects.Add(new Checkpoint(58, 15));
            activeObjects.Add(new Checkpoint(1, 2));
            activeObjects.Add(new Exit(25, 9));
        }


        public static void Minor(out string name, out string message, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            // Kopiera denna metod och döp om till banans namn. Gör public.
            // Använd detta format för att designa en bana.
            // Se till att antalet tecken per rad stämmer med (LevelHandler.Width), och att antal rader stämmer med (LevelHandler.Height).

            name = "Minfält";
            message = "Det ligger ett antal minor på detta fält. Korsa det om du kan! :)";

            lines = new string[LevelHandler.Height];
            lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            lines[01] = @"║▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║";
            lines[02] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[03] = @"║░░░░░░░░░░▒░░░░░░░░░░░░░░░░░▒░░░░░░░░░▒▒░░░░░░░░▒░░░░░░░░░║";
            lines[04] = @"║░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[05] = @"║░▒░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░║";
            lines[06] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[07] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░║";
            lines[08] = @"║░░░░░░▒░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░║";
            lines[09] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[10] = @"║░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[11] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[12] = @"║░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░▒░░░░░░░░▒░░░░░░░░░░░░░▒░░║";
            lines[13] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[14] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[15] = @"║░░░░▒░░░░░░░░░░░░░░░▒░░░░░░░▒░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░║";
            lines[16] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[17] = @"║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║";
            lines[18] = @"║▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║";
            lines[19] = @"╚══════════════════════════════════════════════════════════╝";
            //             |        |         |         |         |         |       |
            //             1        10        20        30        40        50      58

            startX = 29;
            startY = 18;


            activeObjects = new List<IActiveObject>();
            activeObjects.Add(new Exit(29, 2));
            activeObjects.Add(new Boom(10, 16));
            activeObjects.Add(new Boom(28, 12));
            activeObjects.Add(new Boom(4, 12));
            activeObjects.Add(new Boom(10, 12));
            activeObjects.Add(new Boom(11, 14));
            activeObjects.Add(new Boom(1, 7));
            activeObjects.Add(new Boom(45, 12));
            activeObjects.Add(new Boom(52, 16));
            activeObjects.Add(new Boom(48, 2));
            activeObjects.Add(new Boom(41, 17));
            activeObjects.Add(new Boom(36, 7));
            activeObjects.Add(new Boom(32, 8));
            activeObjects.Add(new Boom(30, 9));
            activeObjects.Add(new Boom(31, 5));
            activeObjects.Add(new Boom(12, 12));
            activeObjects.Add(new Boom(32, 16));
            activeObjects.Add(new Boom(42, 4));
            activeObjects.Add(new Boom(47, 10));
            activeObjects.Add(new Boom(16, 10));
            activeObjects.Add(new Boom(15, 9));
            activeObjects.Add(new Boom(18, 11));
            activeObjects.Add(new Boom(3, 16));
            activeObjects.Add(new Boom(6, 18));
            activeObjects.Add(new Boom(8, 9));
            activeObjects.Add(new Boom(10, 11));
            activeObjects.Add(new Boom(14, 8));
            activeObjects.Add(new Boom(25, 6));
            activeObjects.Add(new Boom(27, 4));
            activeObjects.Add(new Boom(28, 3));

        }








    }
}