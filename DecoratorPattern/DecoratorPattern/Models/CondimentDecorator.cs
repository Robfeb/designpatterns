using System;
namespace DecoratorPattern
{
    public abstract class CondimentDecorator: Beverage, IBeverage
    {
        public abstract string GetDescription();

        public CondimentDecorator()
        {
        }
    }
}
