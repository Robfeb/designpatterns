using System;
namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;
        const double condimentCost = 0.30;
        const string condimentDescription = " with Mocha";
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            description = _beverage.GetDescription() + condimentDescription;
            size = _beverage.GetSize();
        }
        public override double Cost()
        {
            return _beverage.Cost() + condimentCost;
        }

        public override string GetDescription()
        {
            description = _beverage.GetDescription() + condimentDescription;
            return description;
        }
    }
}
