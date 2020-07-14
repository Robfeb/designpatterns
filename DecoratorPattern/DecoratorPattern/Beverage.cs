using System;
namespace DecoratorPattern
{
    public class Beverage
    {
        string description = "Unknown Beverage";
        double cost = 1.0;
        Boolean milk;
        Boolean soy;
        Boolean mocha;
        Boolean whip;

        public void setDescription(string _description)
        {
             description= _description;
        }
        public string GetDescription()
        {
            return description;
        }
        public double Cost()
        {
            return cost;
        }
        public void setCost(double _cost)
        {
            cost=_cost;
        }
        public bool hasMilk() { return milk; }
        public void setMilk(bool _milk) { milk = _milk; }
        public bool hasSoy() { return soy; }
        public void setSoy(bool _soy) { soy = _soy; }
        public bool hasMocha() { return mocha; }
        public void setMocha(bool _mocha) { mocha = _mocha; }
        public bool hasWhip() { return whip; }
        public void setWhip(bool _whip) { whip = _whip; }
    }
}
