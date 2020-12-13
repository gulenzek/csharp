using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class OrderTest
    {

        private Order _order;
        private IDictionary<int, Product> _products;


        [SetUp]
        public void SetUp()
        {
            _products = new Dictionary<int, Product>();

            _products.Add(1, new Product { Id = 1, Name = "Lenovo Kulaklık", UnitPrice = 30, StockAmount = 10 });
            _products.Add(2, new Product { Id = 2, Name = "Logitech M185 Mouse", UnitPrice = 100, StockAmount = 10 });
            _products.Add(3, new Product { Id = 3, Name = "Sony AUX Girişi", UnitPrice = 30, StockAmount = 10 });
            _products.Add(4, new Product { Id = 4, Name = "Hp Kablosuz Mouse", UnitPrice = 60, StockAmount = 10 });


            Cart cart = new Cart();
            _order = new Order(cart);
        }

        [Test]
        public void IsFreeCargo_AddSomeProducts_IsTrue()
        {
            _order.Cart.AddProduct(_products[1], 9);

            bool expected = true;
            bool actual = _order.IsFreeCargo;

            Assert.That(expected, Is.EqualTo(actual));
        }

        









    }
}
