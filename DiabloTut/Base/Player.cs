using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    struct Stats
    {
        public int AccessStrength { get; set; }
        public int AccessAgility { get; set; }
        public int AccessConstitution { get; set; }
        public int AccessIntelligence { get; set; }
        public int AccessWisdom { get; set; }
        public int AccessCharisma { get; set; }
    }

    class Player
    {
        public float AccessHealth { get; set; }
        public float AccessDamage { get; set; }
        public float GetMaxHealth { get;  }

        public Inventory AccessInventory { get; set; }
        public Stats AccessStats;

        //Static
        static Player myInstance;

        public Player(float aHealth, float aDamage)
        {
            myInstance = this;

            AccessStats = new Stats();
            AccessInventory = new Inventory();

            GenerateStats();

            AccessHealth = aHealth * AccessStats.AccessConstitution;
            AccessDamage = aDamage * AccessStats.AccessStrength;

            GetMaxHealth = AccessHealth;
        }

        public static Player Get()
        {
            return myInstance;
        }

        private void GenerateStats()
        {
            Random tempRandom = new Random();

            AccessStats.AccessStrength = tempRandom.Next(1, 10 + 1);
            AccessStats.AccessAgility = tempRandom.Next(1, 10 + 1);
            AccessStats.AccessConstitution = tempRandom.Next(1, 10 + 1);

            AccessStats.AccessIntelligence = tempRandom.Next(1, 10 + 1);
            AccessStats.AccessWisdom = tempRandom.Next(1, 10 + 1);
            AccessStats.AccessCharisma = tempRandom.Next(1, 10 + 1);
        }
    }
}
