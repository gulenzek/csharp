using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class CartItemTest
    {
        private CartItem _cartItem;

        [SetUp]
        public void SetUp()
        {
            _cartItem = new CartItem();
        }

        [Test]
        public void Amount_NegativeValue_ThrowsArgumenException()
        {
            TestDelegate testDelegate = () =>
            {

                _cartItem.Amount = -10;
            };

            Assert.That(testDelegate, Throws.ArgumentException);
        }


    }
}
