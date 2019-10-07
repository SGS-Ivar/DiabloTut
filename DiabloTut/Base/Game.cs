using System;

namespace DiabloTut.Base
{
    class Game
    {
        private Player myPlayer;
        private int myDifficulty = 1;

        public Game()
        {
            myPlayer = new Player(100f, 10f);
        }

        public void Run()
        {
            bool tempChoosing = true;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Enter new room");
                Console.WriteLine("2. Show Inventory");
                Console.WriteLine("3. Quit");

                string tempChoice = Console.ReadLine();
                if (tempChoice == "1")
                {
                    Room tempRoom = new Room(myDifficulty);
                    tempRoom.Enter();
                }
                else if (tempChoice == "2")
                {

                }
                else if(tempChoice == "3")
                {
                    tempChoosing = false;
                    break;
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
