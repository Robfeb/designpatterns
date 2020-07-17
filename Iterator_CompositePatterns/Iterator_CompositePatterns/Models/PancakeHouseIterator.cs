using System;
using System.Collections.Generic;

namespace Iterator_CompositePatterns.Models
{
    public class PancakeHouseIterator : ITerator
    {
        List<MenuItem> items;
        int position = 0;
        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
