using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestOdev
{
    public class Order
    {
        public Cart Cart { get; }
        public Status Status { get; set; }
        public Customer Customer { get; set; }


        public Order(Cart cart)
        {
            Cart = cart;
        }

        public bool IsFreeCargo
        {
            get
            {
                bool result = false;
                if (Cart.TotalPrice >= 250 && Cart.TotalPrice <= 500)
                    result = true;
                return result;
            }
        }

    }
}
