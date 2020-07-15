using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicCheesePizza: Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style + " Cheese Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing the {name} !...");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}
