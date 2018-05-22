using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Entities
{
    public class Recipient
    {
        public Recipient(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
