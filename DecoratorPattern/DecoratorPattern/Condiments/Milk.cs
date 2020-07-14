using System;
namespace DecoratorPattern.Condiments
{
    public class Milk : CondimentDecorator
    {
        Beverage _beverage;
        const double condimentCost = 0.15;
        const string condimentDescription = " with Milk";
        public Milk(Beverage beverage)
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
            
            return description;
        }
    }
}
