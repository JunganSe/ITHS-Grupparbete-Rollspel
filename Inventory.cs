using System;
using System.Collections.Generic;
using System.Text;

namespace Rollspel
{
    public static class Inventory
    {
        public static List<Item> ItemList = new List<Item>();

        public static List<Item> GetList()
        {
            return ItemList;
        }


        public static void PrintInventory()
        {

            Console.WriteLine("******************");
            for (int i = 0; i < ItemList.Count; i++)
            {
                int index = i + 1;

                Console.WriteLine($"*{index}. {ItemList[i].Name}");
            }

            Console.WriteLine("******************");

        }

        public static void AddToInventory(int input, Item foundItem)
        {
            switch (input)
            {
                case 1:
                    if (ItemList.Count < 6)
                    {
                        ItemList.Add(foundItem);
                        Console.WriteLine($"Lagt {foundItem.Name} i ryggsäcken!");
                        PrintInventory();
                    }
                    else
                    {
                        Console.WriteLine($"Du har redan {ItemList.Count} saker i din ryggsäck, du kan inte plocka upp fler. Vill du kasta något annat?");
                        int answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            SwitchItemInInventory(answer, foundItem);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Prylen kastas i närmsta dike!");
                            break;
                        }
                    }

                    break;

                case 2:
                    Console.WriteLine("Yeet!");
                    break;

                default:
                    Console.WriteLine("Ange en siffra eller dra :)");
                    break;

            }

        }

        public static void SwitchItemInInventory(int answer, Item newItem)
        {
            Console.WriteLine($"Vilken av sakerna i din ryggsäck vill du kasta? Ange siffra för respektive objekt.");
            int itemToReplace = int.Parse(Console.ReadLine());

            if (itemToReplace > 0)
            {
                Console.WriteLine($"{ItemList[itemToReplace - 1].Name} kastas i närmsta dike!");
                ItemList[itemToReplace - 1] = newItem;
                PrintInventory();
            }
            else
            {
                Console.WriteLine("Du måste ange en siffra mellan 1-6");
            }








        }





    }


}