using System;
using System.Collections.Generic;

namespace pj09_3
{
    public class Player
    {
        private List<Item> items;

        public Player()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UseItems()
        {
            foreach (var item in items)
            {
                item.Use();
            }
        }
    }
}
