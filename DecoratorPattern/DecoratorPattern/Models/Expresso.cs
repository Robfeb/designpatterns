using System;
namespace DecoratorPattern
{
    public class Expresso: Beverage, IBeverage
    {
        public Expresso()
        {
            description="Expresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
