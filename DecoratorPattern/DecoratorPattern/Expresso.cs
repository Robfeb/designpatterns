using System;
namespace DecoratorPattern
{
    public class Expresso: Beverage
    {
        public Expresso()
        {
            SetDescription("Expresso Coffee");

            SetCost(1.99);
        }
    }
}
