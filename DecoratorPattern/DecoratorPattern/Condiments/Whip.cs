using System;
namespace DecoratorPattern.Condiments
{
    public class Whip: CondimentDecorator
    {
        Beverage _beverage;
        const double condimentCost = 0.20;
        const string condimentDescription = " with Whip";
        public Whip(Beverage beverage)
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
            description= _beverage.GetDescription() + condimentDescription;
            return description;
        }
    }
}
