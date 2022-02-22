using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
   public class Character : IInventoryable
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Intelligence { get; set; }
        public int Sanity { get; set; }
        public int wallet { get; set; }
        public Character ( int attack, int defense, int health, int intelligence)
        {
            this.wallet = 50;
            this.Sanity = 10;
            this.Attack = attack;
            this.Defense = defense;
            this.Health = health;
            this.Intelligence = intelligence;
        }
        public Character(string name)
        {
            this.Name = name;
           

        }
       
    }
}
