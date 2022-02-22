using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
    class Weapon : Item
    {
        public Weapon(string name, int attack, int health, int intelligence, int price)
        {
            this.Price = price;
            this.Name = name;
            this.Attack = attack;
            this.Health = health;
            this.Intelligence = intelligence;
        }
        public Weapon(string name, int attack, int price)
        {
            this.Price = price;
            this.Name = name;
            this.Attack = attack;
        }
        public Weapon (string name, int attack, int health, int price)
        {
            this.Price = price;
            this.Name = name;
            this.Attack = attack;
            this.Health = health;
        }
        public Weapon(string name)
        {
            this.Name = name;
            
        }
    }
}
