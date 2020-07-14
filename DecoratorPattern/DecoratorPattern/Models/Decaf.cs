using System;
namespace DecoratorPattern
{
    public class Decaf: Beverage, IBeverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.6;
        }
    }
}
