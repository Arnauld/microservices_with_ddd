using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Entities
{
    public class Book : IItem
    {
        public ItemId ItemId => null;

        public double Weight => default(double);
    }
}
