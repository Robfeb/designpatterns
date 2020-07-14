using System;
namespace DecoratorPattern
{
    public class Beverage
    {
        string description = "Unknown Beverage";
        double cost = 1.0;
        bool milk;
        bool soy;
        bool mocha;
        bool whip;

        public void SetDescription(string _description)
        {
            description = _description;
        }
        public string GetDescription()
        {
            string finalDescription = description;
            if (HasMilk())
                finalDescription += " with milk";
            if (HasMocha())
                finalDescription += " with mocha";
            if (HasSoy())
                finalDescription += " with soy";
            if (HasWhip())
                finalDescription += " with whip";
            return finalDescription;
        }
        public double Cost()
        {
            double totalCost = cost;
            if (HasMilk())
                cost += .20;
            if (HasMocha())
                cost += .30;
            if (HasSoy())
                cost += .25;
            if (HasWhip())
                cost += .10;
            return totalCost;
        }
        public void SetCost(double _cost)
        {
            cost = _cost;
        }
        public bool HasMilk() { return milk; }
        public void SetMilk(bool _milk) { milk = _milk; }
        public bool HasSoy() { return soy; }
        public void SetSoy(bool _soy) { soy = _soy; }
        public bool HasMocha() { return mocha; }
        public void SetMocha(bool _mocha) { mocha = _mocha; }
        public bool HasWhip() { return whip; }
        public void SetWhip(bool _whip) { whip = _whip; }
    }
}
