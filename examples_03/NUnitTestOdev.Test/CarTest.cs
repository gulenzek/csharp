using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestOdev.Test
{
    [TestFixture]
    public class CarTest
    {
        private Car _car;
        [SetUp]
        public void SetUp()
        {
            Way way = new Way(65);
            _car = new Car(300, way);

        }
        
        [Test]
        [TestCase(290, 20)]
        public void IncreaseSpeed_OverMaxSpeed_ThrowsArgumentException(double currentSpeed, double increaseSpeed)
        {
            _car.IncreaseSpeed(currentSpeed);

            

            Assert.That(() => _car.IncreaseSpeed(increaseSpeed), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-30)]
        public void IncreaseSpeed_WrongArgument_ThrowsArgumentException(double wrongArgument)
        {

            Assert.That(() => _car.IncreaseSpeed(wrongArgument), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-30)]
        public void ReduceSpeed_WrongArgument_ThrowsArgumentException(double wrongArgument)
        {
            _car.IncreaseSpeed(50);
            Assert.That(() => _car.ReduceSpeed(wrongArgument), Throws.ArgumentException);
        }

        [Test]
        [TestCase(50, 60)]
        [TestCase(60, 60)]
        public void ReduceSpeed_BellowMinSpeed_ThrowsArgumentException(double currentSpeed, double reduceSpeed)
        {
            _car.IncreaseSpeed(currentSpeed);
            Assert.That(() => _car.ReduceSpeed(reduceSpeed), Throws.ArgumentException);
        }

        [Test]
        [TestCase(65, 10, 50)]
        [TestCase(65, 20, 100)]
        [TestCase(64, 1, 0)]
        [TestCase(65, 20, 20)]
        public void IncreaseSpeed_OverWayLimit_TruePenaltyPoint(double currentSpeed, double increaseSpeed, int excepted)
        {
            _car.IncreaseSpeed(currentSpeed);
            _car.IncreaseSpeed(increaseSpeed);

            int actual = _car.PenaltyPoint;

            Assert.That(actual, Is.EqualTo(excepted));
        }


    }
}
