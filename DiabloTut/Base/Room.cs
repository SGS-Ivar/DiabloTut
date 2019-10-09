using System;
using System.Collections.Generic;

namespace DiabloTut.Base
{
    class Room
    {
        private List<Enemy> myEnemies = new List<Enemy>();
        private List<Item> myLoot = new List<Item>();

        private int myDifficulty = 0;

        public Room(int aDifficulty)
        {
            myDifficulty = aDifficulty;
            Initialize();
        }

        public void Enter()
        {
            bool tempChoosing = true;

            do
            {
                if (myEnemies.Count <= 0 || Player.Get().AccessHealth <= 0)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1. Start over");
                        Console.WriteLine("2. Quit");

                        string tempS = Console.ReadLine();
                        if (tempS == "1")
                        {
                            // Starts a new instance of the program itself
                            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                            Environment.Exit(0);
                        }
                        else if(tempS == "2")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong input!");
                            Console.ReadKey();
                        }

                    } while (true);
                }

                Console.Clear();
                Console.WriteLine("1. Fight enemies");
                Console.WriteLine("2. Show inventory");

                string tempChoice = Console.ReadLine();
                if (tempChoice == "1")
                {
                    //TEMPORARY
                    FightEnemies();
                }
                else if(tempChoice == "2")
                {
                    Player.Get().AccessInventory.ShowInventory();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                    Console.ReadKey();
                }

            } while (tempChoosing);
        }

        private void Initialize()
        {
            Random tempRandom = new Random();
            int tempRand = tempRandom.Next(1, 2 * myDifficulty + 1);

            for (int i = 0; i < tempRand; i++)
            {
                myEnemies.Add(new Enemy(myDifficulty));
            }

            for (int i = 0; i < tempRandom.Next(1, 4); i++)
            {
                myLoot.Add(new HealthPotion("Health potion", 10));
            }
        }

        //TEMPORARY
        private void FightEnemies()
        {
            Console.Clear();
            for (int i = 0; i < myEnemies.Count; i++)
            {
                bool tempChoosing = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Player health: " + Player.Get().AccessHealth);
                    Console.WriteLine("Enemy health: " + myEnemies[i].AccessHealth);

                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Defened");
                    Console.WriteLine("3. Use Item");

                    string tempChoice = Console.ReadLine();
                    if (tempChoice == "1")
                    {
                        myEnemies[i].AccessHealth -= Player.Get().AccessDamage;
                        Player.Get().AccessHealth -= myEnemies[i].AccessDamage;

                        if (myEnemies[i].AccessHealth <= 0)
                        {

                            Console.Clear();
                            Console.WriteLine("Enemy killed!");

                            if (myLoot.Count > 0)
                            {
                                Player.Get().AccessInventory.AccessInventory.Add(myLoot[0]);
                                Console.WriteLine("You found item " + myLoot[0].AccessName);
                                myLoot.RemoveAt(0);
                            }

                            Console.ReadKey();

                            myEnemies.RemoveAt(i);
                            tempChoosing = false;
                            break;
                        }
                    }
                    else if (tempChoice == "2")
                    {

                    }
                    else if(tempChoice == "3")
                    {
                        Player.Get().AccessInventory.UseItem();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                        Console.ReadKey();
                    }

                } while (tempChoosing);
            }
        }
    }
}
