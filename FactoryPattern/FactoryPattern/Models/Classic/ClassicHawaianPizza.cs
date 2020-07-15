using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicHawaianPizza:Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicHawaianPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style + " Hawaian Pizza";
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
