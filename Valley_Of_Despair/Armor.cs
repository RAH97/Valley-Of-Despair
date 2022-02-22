using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
    public class Armor : Item
    {

        public Armor (string name, int defense)
        {
            this.Name = name;
            this.Defense = defense;
        }
       
    }
}
