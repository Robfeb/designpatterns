using System;
namespace DecoratorPattern
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            setDescription("HouseBlend Coffee");
            setCost(1.1);
        }
    }
}
