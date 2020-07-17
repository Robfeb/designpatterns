using System;
namespace Iterator_CompositePatterns.Models
{
    public class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;
        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            ITerator pancakeIterator = pancakeHouseMenu.CreateIterator();
            ITerator dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
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
