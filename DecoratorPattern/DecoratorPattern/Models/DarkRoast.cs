using System;
namespace DecoratorPattern
{
    public class DarkRoast : Beverage, IBeverage
    {
        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double Cost()
        {
            return 1.3;
        }
    }
}
