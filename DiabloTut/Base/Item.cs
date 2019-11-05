using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloTut.Base
{
    class Item
    {
        public string AccessName;

        public Item(string aName)
        {
            AccessName = aName;
        }

        public virtual void Use(Player aPlayer) { }
        public virtual void Update() { }
    }
}
