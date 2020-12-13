using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class CartTest
    {
        private Cart _cart;

        private IDictionary<int, Product> _products;

        [SetUp]
        public void SetUp()
        {
            _cart = new Cart();

            _products = new Dictionary<int, Product>();

            _products.Add(1, new Product { Id = 1, Name = "Lenovo Kulaklık", UnitPrice = 30, StockAmount = 10 });
            _products.Add(2, new Product { Id = 2, Name = "Logitech M185 Mouse", UnitPrice = 100, StockAmount = 10 });
            _products.Add(3, new Product { Id = 3, Name = "Sony AUX Girişi", UnitPrice = 30, StockAmount = 10 });
            _products.Add(4, new Product { Id = 4, Name = "Hp Kablosuz Mouse", UnitPrice = 60, StockAmount = 10 });
            
        }

        [Test]
        public void AddProduct_SameProducts_IsEqualCartItemsCount()
        {
            _cart.AddProduct(_products[1], 5);
            _cart.AddProduct(_products[1], 5);

            int actual = _cart.CartItemsCount;
            int expected = 1;

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void AddProduct_DifferentSomeProducts_IsEqualCartItemsCount()
        {
            _cart.AddProduct(_products[1], 5);
            _cart.AddProduct(_products[2], 5);

            int actual = _cart.CartItemsCount;
            int expected = 2;

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void AddProduct_SameSomeProducts_IsEqualCartItemAmount()
        {
            _cart.AddProduct(_products[1], 5);
            _cart.AddProduct(_products[1], 5);

            int actual = _cart[0].Amount;
            int expected = 10;


            Assert.That(expected, Is.EqualTo(actual));
           
        }

        [Test]
        public void AddProduct_OverProductStockAmount_ThrowsArgumentException()
        {
            _cart.AddProduct(_products[1], 5);

            TestDelegate testDelegate = () =>
            {
                _cart.AddProduct(_products[1], 6);
            };

            Assert.That(testDelegate, Throws.ArgumentException);
        }


        [Test]
        public void TotalPrice_AddSomeProducts_IsEqualTotalPrice()
        {
            _cart.AddProduct(_products[1], 5); // 5 * 30 = 150 
            _cart.AddProduct(_products[2], 5); // 5 * 100 == 500

            int actual = (int)_cart.TotalPrice;
            int expected = 650;

            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(-23)]
        public void AddProduct_WrongArgument_ThrowsArgumentException(int wrongArgument)
        {
            TestDelegate testDelegate =() => _cart.AddProduct(_products[1], wrongArgument);

            Assert.That(testDelegate, Throws.ArgumentException);
        }
    }
}
