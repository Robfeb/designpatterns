using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicVeggiePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicVeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style + " Veggie Pizza";
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
