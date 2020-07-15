using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ChicagoPizza: PizzaClassic
    {
        public ChicagoPizza()
        {
            name = "Chicago Special Pizza";
        }
    }
}
