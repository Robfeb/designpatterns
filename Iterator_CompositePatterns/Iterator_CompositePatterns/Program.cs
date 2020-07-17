using System;
using System.Collections.Generic;
using Iterator_CompositePatterns.Models;

namespace Iterator_CompositePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterator and Composite Pattern project!");
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            List<MenuItem> breakfastItems = pancakeHouseMenu.GetMenuItems();

            DinerMenu dinerMenu = new DinerMenu();
            MenuItem[] lunchItems = dinerMenu.GetMenuItems();
            Console.WriteLine("------------------Pancake House MENU ------------");

            for (int i = 0; i < breakfastItems.Count; i++)
            {
                MenuItem menuItem = breakfastItems[i];
                Console.WriteLine(menuItem.GetName() + " ");
                Console.WriteLine(menuItem.GetPrice() + " ");
                Console.WriteLine(menuItem.GetDescription());
            }
            Console.WriteLine("------------------DINER MENU ------------");
            for (int i = 0; i < lunchItems.Length; i++)
            {
                MenuItem menuItem = lunchItems[i];
                if (menuItem == null) continue;
                Console.WriteLine(menuItem.GetName() + " ");
                Console.WriteLine(menuItem.GetPrice() + " ");
                Console.WriteLine(menuItem.GetDescription());
            }

        }
    }
}
