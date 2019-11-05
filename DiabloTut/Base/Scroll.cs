using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Scroll : Item
    {
        int myRoundCounter;
        string myStat;

        public Scroll(string aName)
            : base(aName)
        {
            myRoundCounter = 5;
            myStat = GetRandomStat();
        }

        public override void Use(Player aPlayer)
        {
            if (myStat == "Strength")
            {
                aPlayer.AccessStats.AccessStrength += 1;
            }
            else if (myStat == "Agility")
            {
                aPlayer.AccessStats.AccessAgility += 1;
            }
            else if (myStat == "Constitution")
            {
                aPlayer.AccessStats.AccessConstitution += 1;
            }
            else if (myStat == "Intelligence")
            {
                aPlayer.AccessStats.AccessIntelligence += 1;
            }
            else if (myStat == "Wisdom")
            {
                aPlayer.AccessStats.AccessWisdom += 1;
            }
            else if (myStat == "Charisma")
            {
                aPlayer.AccessStats.AccessCharisma += 1;
            }

            base.Use(aPlayer);
        }

        public override void Update()
        {
            myRoundCounter--;
            if (myRoundCounter <= 0)
            {
                Unuse();
            }

            base.Update();
        }

        private void Unuse() 
        {
            Player tempPlayer = Player.Get();

            if (myStat == "Strength")
            {
                tempPlayer.AccessStats.AccessStrength -= 1;
            }
            else if (myStat == "Agility")
            {
                tempPlayer.AccessStats.AccessAgility -= 1;
            }
            else if (myStat == "Constitution")
            {
                tempPlayer.AccessStats.AccessConstitution -= 1;
            }
            else if (myStat == "Intelligence")
            {
                tempPlayer.AccessStats.AccessIntelligence -= 1;
            }
            else if (myStat == "Wisdom")
            {
                tempPlayer.AccessStats.AccessWisdom -= 1;
            }
            else if (myStat == "Charisma")
            {
                tempPlayer.AccessStats.AccessCharisma -= 1;
            }
        }

        private string GetRandomStat()
        {
            Random tempRandom = new Random();
            int tempNum = tempRandom.Next(1, 6 + 1);

            if (tempNum == 1)
            {
                return "Strength";
            }
            else if (tempNum == 2)
            {
                return "Agility";
            }
            else if (tempNum == 3)
            {
                return "Constitution";
            }
            else if (tempNum == 4)
            {
                return "Intelligence";
            }
            else if (tempNum == 5)
            {
                return "Wisdom";
            }
            else if (tempNum == 6)
            {
                return "Charisma";
            }

            return "";
        }
    }
}
