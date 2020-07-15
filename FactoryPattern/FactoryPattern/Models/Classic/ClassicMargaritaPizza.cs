using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicMargaritaPizza: Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicMargaritaPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style + " Margarita Pizza";
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
