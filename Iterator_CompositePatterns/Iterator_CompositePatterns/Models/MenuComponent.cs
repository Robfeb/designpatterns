using System;
namespace Iterator_CompositePatterns.Models
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent) { throw new UnsupportedOperationException(); }
        public virtual void Remove(MenuComponent menuComponent) { throw new UnsupportedOperationException(); }
        public virtual MenuComponent GetChild(int i)
        {
            throw new UnsupportedOperationException();
        }

        public virtual string GetName()
        {
            throw new UnsupportedOperationException();
        }
        public virtual string GetDescription()
        {
            throw new UnsupportedOperationException();
        }
        public virtual double GetPrice()
        {
            throw new UnsupportedOperationException();
        }

        public virtual bool IsVegetarian()
        {
            throw new UnsupportedOperationException();
        }
        public virtual void Print()
        {
            throw new UnsupportedOperationException();
        }

    }
}
