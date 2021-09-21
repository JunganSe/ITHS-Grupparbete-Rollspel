using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class LevelMaker
    {
        // Denna metod används ej, är bara en mall.
        private static void Template(out string name, out string[] lines, out int startX, out int startY, out List<IActiveObject> activeObjects)
        {
            // Kopiera denna metod och döp om till banans namn.
            // Använd detta format för att designa en bana.
            // Se till att antalet tecken per rad stämmer med (LevelHandler.Width), och att antal rader stämmer med (LevelHandler.Height).

            name = "Unnamed";

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
            name = "Labyrinten";

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

            // "Samla 3 poäng genom att ringa på dörrklockorna. Låt bli att gå in i väggarna, och undvik att gå vilse!"


            //Mallen

            //lines[00] = @"╔══════════════════════════════════════════════════════════╗";
            //lines[01] = @"║                                                          ║";
            //lines[02] = @"║                                                          ║";
            //lines[03] = @"║                                                          ║";
            //lines[04] = @"║                                                          ║";
            //lines[05] = @"║                                                          ║";
            //lines[06] = @"║                                                          ║";
            //lines[07] = @"║                                                          ║";
            //lines[08] = @"║                                                          ║";
            //lines[09] = @"║                                                          ║";
            //lines[10] = @"║                                                          ║";
            //lines[11] = @"║                                                          ║";
            //lines[12] = @"║                                                          ║";
            //lines[13] = @"║                                                          ║";
            //lines[14] = @"║                                                          ║";
            //lines[15] = @"║                                                          ║";
            //lines[16] = @"║                                                          ║";
            //lines[17] = @"║                                                          ║";
            //lines[18] = @"║                                                          ║";
            //lines[19] = @"╚══════════════════════════════════════════════════════════╝";


            //Har lagt kartan med bara själva gången nedan, ifall den skulle behövas!

            //lines[00] = @"+----------------------------------------------------------+";
            //lines[01] = @"¦##########################################################¦";
            //lines[02] = @"¦       #########################################     #####¦";
            //lines[03] = @"¦###### ###################################       ### #####¦";
            //lines[04] = @"¦###### ################################### ######### ###  ¦";
            //lines[05] = @"¦###### ################################### #########     #¦";
            //lines[06] = @"¦###### ################################### ###############¦";
            //lines[07] = @"¦###### ##############         ############ ###############¦";
            //lines[08] = @"¦###### ##############         ############       #########¦";
            //lines[09] = @"¦######             ##         ################## #########¦";
            //lines[10] = @"¦################## ##         ################## #########¦";
            //lines[11] = @"¦################## ###### ###################### #########¦";
            //lines[12] = @"¦################## ######               ######## #########¦";
            //lines[13] = @"¦################## ####################             ######¦";
            //lines[14] = @"¦################## #################### ########### ######¦";
            //lines[15] = @"¦################## #################### ###########       ¦";
            //lines[16] = @"¦##################                      ##################¦";
            //lines[17] = @"¦##########################################################¦";
            //lines[18] = @"¦##########################################################¦";
            //lines[19] = @"+----------------------------------------------------------+";

            startX = 26;  // Spelarens startposition
            startY = 10;  //

            activeObjects = new List<IActiveObject>(); // Lista med objekt som kör egen kod (på denna bana).
            activeObjects.Add(new Checkpoint(59, 4));
            activeObjects.Add(new Checkpoint(59, 15));
            activeObjects.Add(new Checkpoint(0, 2));
            activeObjects.Add(new Exit(25, 9));

        }
    }
}