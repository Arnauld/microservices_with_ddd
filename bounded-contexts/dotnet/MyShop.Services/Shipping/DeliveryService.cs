using MyShop.Services.ShoppingCart;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Services.Shipping
{
    public class DeliveryService
    {
        public DeliveryService(CatalogService catalogService)
        {
            CatalogService = catalogService;
        }

        public CatalogService CatalogService { get; }

        public double CalculateOrderWeight(Cart cart)
        {
            return cart.GetItems()
                .Sum(item => item.Quantity * CatalogService.LoadItem(item.ItemId).Weight);
        }
    }
}
