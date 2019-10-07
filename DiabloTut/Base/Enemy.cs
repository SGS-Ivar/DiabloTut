using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Enemy
    {
        private float myHealth;
        private float myDamage;

        //TEMPORARY
        public void SetHealth(float aHealth) { myHealth = aHealth; }
        public void SetDamage(float aDamage) { myDamage = aDamage; }

        public float GetHealth() { return myHealth; }
        public float GetDamage() { return myDamage; }

        private int myDifficulty;

        public Enemy(int aDifficulty)
        {
            myDifficulty = aDifficulty;
            Initialize();
        }

        private void Initialize()
        {
            //Change to random
            myHealth = 3 * myDifficulty + 20;
            myDamage = myDifficulty + 5;
        }
    }
}
