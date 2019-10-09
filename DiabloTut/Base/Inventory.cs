using System;
using System.Collections.Generic;

namespace DiabloTut.Base
{
    class Inventory
    {
        public List<Item> AccessInventory = new List<Item>();

        public Inventory()
        {}

        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("Your inventory");
            for (int i = 0; i < AccessInventory.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + AccessInventory[i].AccessName);
            }

            Console.ReadKey();
        }

        public void UseItem()
        {
            bool tempChoosing = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose an item");
                Console.WriteLine("Press 0 to exit");

                for (int i = 0; i < AccessInventory.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + AccessInventory[i].AccessName);
                }

                string tempChoice = Console.ReadLine();
                if (tempChoice == "0")
                {
                    tempChoosing = false;
                    break;
                }
                
                for (int i = 0; i < AccessInventory.Count; i++)
                {
                    if (tempChoice == (i + 1).ToString())
                    {
                        Console.Clear();
                        AccessInventory[i].Use(Player.Get());

                        Console.WriteLine("You used item " + AccessInventory[i].AccessName);
                        Console.ReadKey();

                        AccessInventory.RemoveAt(i);
                        break;
                    }
                }

            } while (tempChoosing);
        }
    }
}
