using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
    class Special : Item
    {
        public Special(string name, int sanity, int price)
        {
            this.Name = name;
            this.Sanity = sanity;
            this.Price = price;
        }
        public Special(string name, int health)
        {
            this.Name = name;
            this.Health = health;
            this.Price = 5;
        }
        
    }
}
