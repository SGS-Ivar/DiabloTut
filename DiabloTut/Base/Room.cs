using System;
using System.Collections.Generic;

namespace DiabloTut.Base
{
    class Room
    {
        private List<Enemy> myEnemies = new List<Enemy>();
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
                    Console.WriteLine("Player health: " + Player.Get().GetHealth());
                    Console.WriteLine("Enemy health: " + myEnemies[i].GetHealth());

                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Defened");

                    string tempChoice = Console.ReadLine();
                    if (tempChoice == "1")
                    {
                        myEnemies[i].SetHealth(myEnemies[i].GetHealth() - Player.Get().GetDamage());
                        Player.Get().SetHealth(Player.Get().GetHealth() - myEnemies[i].GetDamage());

                        if (myEnemies[i].GetHealth() <= 0)
                        {
                            tempChoosing = false;
                            break;
                        }
                    }
                    else if (tempChoice == "2")
                    {

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
