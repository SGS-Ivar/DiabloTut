using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Player
    {
        private float myHealth;
        private float myDamage;

        //TEMPORARY
        public void SetHealth(float aHealth) { myHealth = aHealth; }
        public void SetDamage(float aDamage) { myDamage = aDamage; }

        public float GetHealth() { return myHealth; }
        public float GetDamage() { return myDamage; }

        //Static
        static Player myInstance;

        public Player(float aHealth, float aDamage)
        {
            myInstance = this;

            myHealth = aHealth;
            myDamage = aDamage;
        }

        public static Player Get()
        {
            return myInstance;
        }
    }
}
