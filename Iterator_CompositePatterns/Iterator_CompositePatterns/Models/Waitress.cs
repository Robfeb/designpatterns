using System;
using System.Collections.Generic;

namespace Iterator_CompositePatterns.Models
{
    public class Waitress
    {
        List<IMenu> menus;
        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach (var menu in menus)
            {
                Console.WriteLine($"MENU\n----\n{menu.ToString()}");
                PrintMenu(menu.CreateIterator());
            }
        }
        private void PrintMenu(ITerator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(menuItem.GetName() + ", ");
                Console.WriteLine(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
