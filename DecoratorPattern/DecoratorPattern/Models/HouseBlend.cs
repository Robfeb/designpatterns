using System;
namespace DecoratorPattern
{
    public class HouseBlend : Beverage, IBeverage
    {
        public HouseBlend()
        {
            description = "HouseBlend Coffee";
        }
        public override double Cost()
        {
            return 1.1;
        }
    }
}
