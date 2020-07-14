using System;
namespace DecoratorPattern
{
    public class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            setDescription("DarkRoast Coffee");

            setCost(1.3);
        }
    }
}
