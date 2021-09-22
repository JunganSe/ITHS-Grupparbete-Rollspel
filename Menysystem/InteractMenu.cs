using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Enum
{
    public class InteractiveMenu
    {
        public enum Uses
        {
            Inventory,
            Eat,
            Kick,
            Nothing
        }

        public string Message { get; set; }
        public Uses Do { get; set; }

        public InteractiveMenu(string message, Uses use)
        {
            Message = message;
            Do = use;
        }

        public void PrintChoices(Dictionary<string, Uses> choices)
        {
            while (true)
            {
                int counter = 0;
                foreach (var item in choices)
                {
                    counter++;
                    Console.WriteLine(counter + ". " + item.Key + " " + item.Value);
                }

                Regex rx = new Regex(@"[1-3]");
                string userChoice = Console.ReadLine();
                bool isNumber = rx.IsMatch(userChoice);
                int userChoiceInt = 0;
                if (isNumber)
                {
                    userChoiceInt = Convert.ToInt32(userChoice);
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning! Välj mellan 1 och 3.");
                    continue;
                }

                switch (choices.ElementAt(userChoiceInt - 1).Value)
                {
                    case Uses.Nothing:
                        Console.WriteLine($"Du kan inte {choices.ElementAt(userChoiceInt - 1).Key.ToLower()} här.");
                        continue;


                    case Uses.Eat:
                        // Kod för att äta
                        break;

                    case Uses.Inventory:
                        // Kod för att lägga till i inventory
                        break;

                    case Uses.Kick:
                        // Kod för att sparka
                        break;
                }
            }

        }
    }
}