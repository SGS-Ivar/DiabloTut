using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class HealthPotion : Item
    {
        private float AccessHealthAdd;

        public HealthPotion(string aName, float aHealth) : base(aName)
        {
            AccessHealthAdd = aHealth;
        }

        public override void Use(Player aPlayer)
        {
            if (aPlayer.AccessHealth < aPlayer.GetMaxHealth)
            {
                aPlayer.AccessHealth += AccessHealthAdd;

                if (aPlayer.AccessHealth > aPlayer.GetMaxHealth)
                {
                    aPlayer.AccessHealth = aPlayer.GetMaxHealth;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You already have max health!");
                Console.ReadKey();
            }
            base.Use(aPlayer);
        }
    }
}
