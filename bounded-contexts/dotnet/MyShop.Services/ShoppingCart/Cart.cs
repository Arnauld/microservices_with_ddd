using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Services.ShoppingCart
{
    public class Cart
    {
        public Cart(IEnumerable<CartItem> items)
        {
            Items = items;
        }

        private IEnumerable<CartItem> Items { get; }

        public IEnumerable<CartItem> GetItems() => Items;
    }
}
