using MyShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Services.ShoppingCart
{
    public class CartItem
    {
        public CartItem(ItemId itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
        }

        public ItemId ItemId { get; }
        public int Quantity { get; }
    }
}
