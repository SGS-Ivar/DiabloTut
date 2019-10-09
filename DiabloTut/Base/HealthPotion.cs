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
            aPlayer.AccessHealth += AccessHealthAdd;
            base.Use(aPlayer);
        }
    }
}
