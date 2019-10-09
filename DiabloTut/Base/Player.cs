using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Player
    {
        public float AccessHealth;
        public float AccessDamage;

        public Inventory AccessInventory;

        //Static
        static Player myInstance;

        public Player(float aHealth, float aDamage)
        {
            myInstance = this;

            AccessHealth = aHealth;
            AccessDamage = aDamage;

            AccessInventory = new Inventory();
        }

        public static Player Get()
        {
            return myInstance;
        }
    }
}
