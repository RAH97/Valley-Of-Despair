using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
    class NonPlayerCharacter : Character, IInventoryable
    {
        
       

        public NonPlayerCharacter(string name) : base (name)
        {
            
        }

        public void Speak(string message)
        {
            Console.WriteLine(message);
        }

        public void TownShopDialogue()
        {
            Special sQAle = new Special("SQ-Ale", 3, 1);
            Weapon readMesBane = new Weapon("READ_ME's Bane", 5, 10);
            Armor helmOfSyntax = new Armor("Helm of Syntax", 3);
            Weapon mergeErrorMutilator = new Weapon("Merge Error Mutilator", 10, 30);
            IInventoryable.StockShop(sQAle, "SQ-Ale");
            IInventoryable.StockShop(readMesBane, readMesBane.Name );
            IInventoryable.StockShop(helmOfSyntax, helmOfSyntax.Name);
            IInventoryable.StockShop(mergeErrorMutilator, mergeErrorMutilator.Name);
            string userInput;
            do {
              // Inventory npcInventory = new Inventory();
              // Special sQAle = new Special();
              // sQAle.Intelligence = -1;
              // sQAle.Sanity = 3;
              // sQAle.Price = 1;
              // Weapon readMesBane = new Weapon("READ_MEs Bane");
              // readMesBane.Price = 10;
              // readMesBane.Attack = 5;
              // Armor helmOfSyntax = new Armor
              //Inventory.inventory["SQ-Ale"] = sQAle;

               
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    IInventoryable.BuyItem(10, sQAle);

                }
            }
            while(userInput != "5");
            

            




        }

























    }
}
