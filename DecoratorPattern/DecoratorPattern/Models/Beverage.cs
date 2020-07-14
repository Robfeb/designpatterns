using System;
using DecoratorPattern.Models;

namespace DecoratorPattern
{
    public abstract class Beverage : IBeverage
    {
        public string description = "Unknown Beverage";
        public Size size = Size.Normal;
        public string GetDescription()
        {
            return description;
        }
        public abstract double Cost();

        public void SetSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return this.size;
        }
    }
}
