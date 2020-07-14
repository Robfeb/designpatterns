using System;
using DecoratorPattern.Models;

namespace DecoratorPattern
{
    public interface IBeverage
    {
        public string GetDescription();
        public Size GetSize();
        public abstract double Cost();
    }
}
