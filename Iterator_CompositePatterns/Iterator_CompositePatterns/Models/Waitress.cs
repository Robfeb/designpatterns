using System;
using System.Collections.Generic;

namespace Iterator_CompositePatterns.Models
{
    public class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent menus)
        {
            this.allMenus = menus;
        }

        public void PrintMenu()
        {
            allMenus.Print();

            //foreach (var menu in allMenus)
            //{
            //    Console.WriteLine($"MENU\n----\n{menu.ToString()}");
            //    menu.
            //    PrintMenu(menu.CreateIterator());
            //}
        }

        //private void PrintMenu(ITerator iterator)
        //{
        //    while (iterator.HasNext())
        //    {
        //        MenuItem menuItem = (MenuItem)iterator.Next();
        //        Console.WriteLine(menuItem.GetName() + ", ");
        //        Console.WriteLine(menuItem.GetPrice() + " -- ");
        //        Console.WriteLine(menuItem.GetDescription());
        //    }
        //}
    }
}
