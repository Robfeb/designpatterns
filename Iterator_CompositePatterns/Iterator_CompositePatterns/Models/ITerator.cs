using System;
namespace Iterator_CompositePatterns.Models
{
    public interface ITerator
    {
        bool HasNext();
        object Next();
    }
}
