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
        public void ShouldReturn80pPrice()
        {
            var sut = new Bread();

            var expected = 0.8m;

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

            var expected = 5;

            Assert.AreEqual(expected, sut.Quantity);
        }

        [Test]
        public void ShouldReturnTotalOf4()
        {
            var sut = new Bread(5);

            var expected = 4m;

            Assert.AreEqual(expected, sut.Total());
        }
    }
}
