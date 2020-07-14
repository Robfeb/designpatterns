using System;
namespace DecoratorPattern
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            SetDescription("HouseBlend Coffee");
            SetCost(1.1);
        }
    }
}
