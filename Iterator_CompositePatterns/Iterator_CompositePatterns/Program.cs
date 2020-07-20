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

            //PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            //DinerMenu dinerMenu = new DinerMenu();
            //CafeMenu cafeMenu = new CafeMenu();

            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage",
            false,
            2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            true,
            3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
            "Waffles, with your choice of blueberries or strawberries",
            true,
            3.59));
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(new MenuItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));

            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
           "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the day",
            "A cup of the soup of the day, with a side salad", false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29));
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            dinerMenu.Add(new MenuItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));
            dinerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie",
            "Apple pie with a flakey crust, topped with vanilla icecream", true,
            1.59));
            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}
