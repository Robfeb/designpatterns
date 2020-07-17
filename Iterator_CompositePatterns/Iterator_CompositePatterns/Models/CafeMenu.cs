using System;
using System.Collections.Generic;

namespace Iterator_CompositePatterns.Models
{
    public class CafeMenu: IMenu
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();
        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            AddItem("Soup of the day",
            "A cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.GetName(), menuItem);
        }

        public ITerator CreateIterator()
        {
            var list = new List<MenuItem>();
            foreach (var item in menuItems)
            {
                list.Add(item.Value);
            }
            return new PancakeHouseIterator(list);
        }

        public Dictionary<string, MenuItem> GetItems()
        {
            return menuItems;
        }
    }
}
