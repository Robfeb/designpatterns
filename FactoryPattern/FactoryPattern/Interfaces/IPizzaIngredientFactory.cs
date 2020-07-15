using System.Collections.Generic;
using FactoryPattern.Models.Ingredients;

namespace FactoryPattern.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        public string Style { get; set; }
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public List<IVeggies> CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClams CreateClam();
    }
}
