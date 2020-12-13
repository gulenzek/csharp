using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Entity
{
    class ProductFactory
    {
        public static Product Create(String name, double unitPrice, int stockAmount)
        {
            return new Product
            {
                Name = name,
                UnitPrice = unitPrice,
                StockAmount = stockAmount
            };
        }
    }
}
