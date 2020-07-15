using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ClassicPepperoniPizza: Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClassicPepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            name = this.ingredientFactory.Style +  " Pepperoni Pizza";
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
