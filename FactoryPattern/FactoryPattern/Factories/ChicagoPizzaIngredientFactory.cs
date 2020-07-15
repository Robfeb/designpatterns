using System;
using System.Collections.Generic;
using FactoryPattern.Interfaces;
using FactoryPattern.Models.Ingredients;

namespace FactoryPattern.Stores
{
    public class ChicagoPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public string Style { get; set; }

        public ChicagoPizzaIngredientFactory()
        {
            Style="Chicago Style";
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>{ new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public IClams CreateClam()
        {
            return new FreshClams();
        }
    }

   
}
