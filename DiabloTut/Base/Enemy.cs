using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Enemy
    {
        public float AccessHealth { get; set; }
        public float AccessDamage { get; set; }

        public Stats AccessStats;

        private int myDifficulty;

        public Enemy(int aDifficulty)
        {
            myDifficulty = aDifficulty;
            Initialize();
        }

        private void Initialize()
        {
            AccessStats = new Stats();
            GenerateStats();

            AccessHealth = (3 * myDifficulty + 20) * AccessStats.AccessConstitution;
            AccessDamage = (myDifficulty + 5) * AccessStats.AccessStrength;
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
