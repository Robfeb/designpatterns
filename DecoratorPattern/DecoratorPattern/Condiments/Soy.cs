using System;
namespace DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;
        const double condimentCost = 0.25;
        const string condimentDescription = " with Soy";
        public Soy(Beverage beverage)
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
