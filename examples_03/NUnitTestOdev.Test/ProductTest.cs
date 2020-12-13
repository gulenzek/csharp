
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class ProductTest
    {
        private Product _product;

        [SetUp]
        public void SetUp()
        {
            _product = new Product();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-3)]
        [TestCase(-31)]
        public void StockAmount_GiveNegativeAmount_ThrowArgumenException(int value)
        {
            TestDelegate testDelegate = () =>
            {
                _product.StockAmount = value;
            };

            Assert.That(testDelegate, Throws.ArgumentException);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-3)]
        [TestCase(-31)]
        [TestCase(0)]
        public void UnitPrice_GiveNegativeOrZeroAmount_ThrowsArgumentException(int value)
        {
            TestDelegate testDelegate = () =>
            {
                _product.UnitPrice = value;
            };


            Assert.That(testDelegate, Throws.ArgumentException);
        }

    }
}
