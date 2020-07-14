using System;
namespace DecoratorPattern
{
    public class Expresso: Beverage
    {
        public Expresso()
        {
            setDescription("Expresso Coffee");

            setCost(1.99);
        }
    }
}
