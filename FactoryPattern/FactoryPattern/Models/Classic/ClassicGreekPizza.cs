using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicGreekPizza: Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicGreekPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style + " Greek Pizza";
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
