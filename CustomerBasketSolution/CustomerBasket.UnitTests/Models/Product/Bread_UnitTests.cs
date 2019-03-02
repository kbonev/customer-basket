using CustomerBasket.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.UnitTests.Models
{
    [TestFixture]
    class Bread_UnitTests
    {
        [Test]
        public void ShouldReturn100pPrice()
        {
            var sut = new Bread();

            var expected = 1m;

            Assert.AreEqual(expected, sut.Price);
        }

        [Test]
        public void ShouldInitialiseBreadWithQuantity5()
        {
            var sut = new Bread(5);

            var expected = 5;

            Assert.AreEqual(expected, sut.Quantity);
        }

        [Test]
        public void ShouldUpdateQuantity()
        {
            var sut = new Bread();
            sut.AddQuantity(5);

            var expected = 6;

            Assert.AreEqual(expected, sut.Quantity);
        }

        [Test]
        public void ShouldReturnTotalOf5()
        {
            var sut = new Bread(5);

            var expected = 5m;

            Assert.AreEqual(expected, sut.Total());
        }
    }
}
