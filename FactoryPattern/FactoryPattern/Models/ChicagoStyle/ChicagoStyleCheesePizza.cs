using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ChicagoStyleCheesePizza : PizzaClassic
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            //dough = "Extra Thick Crust";
            //sauce = "Plum Tomato";
            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }

    }
}
