using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Enemy
    {
        public float AccessHealth;
        public float AccessDamage;

        private int myDifficulty;

        public Enemy(int aDifficulty)
        {
            myDifficulty = aDifficulty;
            Initialize();
        }

        private void Initialize()
        {
            //Change to random
            AccessHealth = 3 * myDifficulty + 20;
            AccessDamage = myDifficulty + 5;
        }
    }
}
