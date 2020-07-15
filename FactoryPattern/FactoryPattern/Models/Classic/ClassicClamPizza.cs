using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;

            name = this.ingredientFactory.Style +  " Clam Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing the {name} !...");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            clam = ingredientFactory.CreateClam();
        }
    }
}
