using System;
namespace DecoratorPattern
{
    public class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            SetDescription("DarkRoast Coffee");

            SetCost(1.3);
        }
    }
}
