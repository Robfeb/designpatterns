using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class ChicagoPizza: Pizza
    {
        public ChicagoPizza()
        {
            name = "Chicago Special Pizza";
        }
    }
}
