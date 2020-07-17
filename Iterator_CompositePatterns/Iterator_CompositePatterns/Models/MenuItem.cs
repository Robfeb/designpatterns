using System;
namespace Iterator_CompositePatterns.Models
{
    public class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian; this.price = price;
        }
        public string GetName()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }
        public double GetPrice()
        {
            return price;
        }
        public bool IsVegetarian()
        {
            return vegetarian;
        }
    }
}
