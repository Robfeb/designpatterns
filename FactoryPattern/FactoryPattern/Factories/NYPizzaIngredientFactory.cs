using System.Collections.Generic;
using FactoryPattern.Interfaces;
using FactoryPattern.Models.Ingredients;

namespace FactoryPattern.Stores
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public string Style { get; set; }

        public NYPizzaIngredientFactory()
        {
            Style = "NY Style";
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }
        public ISauce CreateSauce()
        {
            return new CarbonaraSauce();
        }
        public ICheese CreateCheese()
        {
            return new HollandCheese();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SpicedPepperoni();
        }
        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>{ new Olives(), new GreenPepper(), new Ham(), new Tuna() };
            return veggies;
        }
        public IClams CreateClam()
        {
            return new Calamari();
        }
    }

    
}
