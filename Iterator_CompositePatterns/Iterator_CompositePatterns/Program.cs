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
            //PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            //List<MenuItem> breakfastItems = pancakeHouseMenu.GetMenuItems();

            //DinerMenu dinerMenu = new DinerMenu();
            //MenuItem[] lunchItems = dinerMenu.GetMenuItems();
            //Console.WriteLine("------------------Pancake House MENU ------------");

            //for (int i = 0; i < breakfastItems.Count; i++)
            //{
            //    MenuItem menuItem = breakfastItems[i];
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}
            //Console.WriteLine("------------------DINER MENU ------------");
            //for (int i = 0; i < lunchItems.Length; i++)
            //{
            //    MenuItem menuItem = lunchItems[i];
            //    if (menuItem == null) continue;
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}

            //foreach (var menuItem in breakfastItems)
            //{
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}
            //foreach (var menuItem in lunchItems)
            //{
            //    if (menuItem == null) continue;
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}
            //IEnumerator<MenuItem> iterator = breakfastItems.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    MenuItem menuItem = iterator.Current;
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}

            //IEnumerator<MenuItem> iterator2 = (IEnumerator<MenuItem>)lunchItems.GetEnumerator();
            //while (iterator2.MoveNext())
            //{
            //    MenuItem menuItem = iterator.Current;
            //    if (menuItem == null) continue;
            //    Console.WriteLine(menuItem.GetName() + " ");
            //    Console.WriteLine(menuItem.GetPrice() + " ");
            //    Console.WriteLine(menuItem.GetDescription());
            //}

            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();
            Waitress waitress = new Waitress(new List<IMenu> { pancakeHouseMenu, dinerMenu, cafeMenu });
            waitress.PrintMenu();
        }
    }
}
