using System;
namespace Iterator_CompositePatterns.Models
{
    public class DinerMenu: IMenu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;
        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can’t add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return menuItems;

        }
        public ITerator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

    }
}
