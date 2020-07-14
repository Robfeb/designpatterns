using System;
namespace DecoratorPattern
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            SetDescription("Decaf Coffee");

            SetCost(1.60);
        }
    }
}
