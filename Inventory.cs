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

        public static void PrintInventory(List<Item> ItemList)
        {

        }

        public static void PrintInventory()
        {

            Console.WriteLine("******************");
            foreach (Item i in ItemList)
            {
                Console.WriteLine($"* {i.Name}");
            }
            Console.WriteLine("******************");

        }

        public static void AddToInventory(int input, Item item)
        {
            switch (input)
            {
                case 1:
                    if (ItemList.Count < 6)
                    {
                        ItemList.Add(item);
                        Console.WriteLine($"Lagt till {item.Name} i Inventory!");
                        PrintInventory();
                    }
                    else
                    {
                        Console.WriteLine($"Du har redan {ItemList.Count} saker i din ryggsäck, du kan inte plocka upp fler. Vill du kasta något annat?");
                        int answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            SwitchInventory(answer);
                        }
                        else
                        {
                            Console.WriteLine("Prylen kastas i närmsta dike!");
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

        public static void SwitchInventory(int answer)
        {

        }


    }


}