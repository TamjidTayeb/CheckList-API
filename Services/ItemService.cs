using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{

    public class ItemService : IItemService
    {
        private readonly Dictionary<int, Item> items;

        public ItemService()
        {
            items = new Dictionary<int, Item>();
        }
        public Item AddItem(Item item)
        {
            items.Add(item.id,item);
            return item;
        }

        public Dictionary<int,Item> GetItems()
        {
            return items;
        }
    }
}
