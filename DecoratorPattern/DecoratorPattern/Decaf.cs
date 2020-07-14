using System;
namespace DecoratorPattern
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            setDescription("Decaf Coffee");

            setCost(1.60);
        }
    }
}
