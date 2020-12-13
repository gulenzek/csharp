using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestOdev
{
    public class Cart
    {
        private List<CartItem> _cartItems;

        public CartItem this[int index]
        {
            get
            {
                return _cartItems[index];
            }
        }


        public Cart()
        {
            _cartItems = new List<CartItem>();
        }

        public int CartItemsCount
        {
            get
            {
                return _cartItems.Count;
            }
        }

       

        public double TotalPrice
        {

            get
            {
                double result = 0;
                foreach (CartItem cartItem in _cartItems)
                {
                    result += cartItem.Product.UnitPrice * cartItem.Amount;
                }

                return result;
            }
            
        }

        public void AddProduct(Product product, int amount)
        {
            if (amount < 1)
                throw new ArgumentException("Amount must be positive number");

            if (product.StockAmount < amount)
                throw new ArgumentException("insufficient stock amount");
                

            CartItem cartItem = GetCartItem(product);

            
            product.StockAmount -= amount;

            if(cartItem == null)
            {
                cartItem = new CartItem
                {
                    Product = product,
                    Amount = amount
                };
                _cartItems.Add(cartItem);
            }
            else
            {
                cartItem.Amount += amount;
            }
        }

        private CartItem GetCartItem(Product product)
        {
            return  _cartItems.Where(item => item.Product.Id == product.Id).FirstOrDefault();
        }



    }
}
