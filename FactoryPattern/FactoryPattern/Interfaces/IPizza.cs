using System;
using System.Collections.Generic;

namespace FactoryPattern.Interfaces
{
    public interface IPizza
    {
        public void Prepare();
        public void Bake();
        public void Cut();
        public void Box();
    }
}
