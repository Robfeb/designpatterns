using System;
namespace Iterator_CompositePatterns.Models
{
    public class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;
        IMenu cafeMenu;
        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            ITerator pancakeIterator = pancakeHouseMenu.CreateIterator();
            ITerator dinerIterator = dinerMenu.CreateIterator();
            ITerator cafeIterator = cafeMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nCAFE");
            PrintMenu(cafeIterator);
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
