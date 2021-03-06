﻿using System;
namespace Iterator_CompositePatterns.Models
{
    public class DinerMenuIterator : ITerator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
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
