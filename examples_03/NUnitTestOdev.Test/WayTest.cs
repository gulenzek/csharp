using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class WayTest
    {
        [Test]
        [TestCase(-123)]
        [TestCase(-10)]
        public void Way_ConstructorGiveNegativeValue_ThrowArgumentException(double speedLimit)
        {
            TestDelegate testDelegate = () =>
           {
               Way way = new Way(speedLimit);
           };

            Assert.That(testDelegate, Throws.ArgumentException);
        }

    }
}
