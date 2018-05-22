using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Entities
{
    public interface IItem : IHasWeight
    {
        ItemId ItemId { get; }
    }
}
