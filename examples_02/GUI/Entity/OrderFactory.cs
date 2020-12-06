using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Entity
{
    class OrderFactory
    {
        public static Order Create(Product product, Person person, int amount)
        {
            return new Order
            {
                Product = product,
                Person = person,
                Amount = amount
            };
        }
    }
}
