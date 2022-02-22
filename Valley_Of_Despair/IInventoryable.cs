using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
   public interface IInventoryable
    {
        
        public static Dictionary<string, Item> npcInventory = new Dictionary<string, Item>();
        public static Dictionary<string, Item> playerInventory = new Dictionary<string, Item>();
        public static void StockShop(Item item, string name)
        {
            npcInventory[name] = item;
        }
        public static void BuyItem (int price, Item item)
        {
           
            npcInventory.Remove(item.Name);
            playerInventory[item.Name] = item;

        }
    }
}
