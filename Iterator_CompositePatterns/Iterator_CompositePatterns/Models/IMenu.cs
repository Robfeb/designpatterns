using System;
namespace Iterator_CompositePatterns.Models
{
    public interface IMenu
    {
        public ITerator CreateIterator();
    }
}
