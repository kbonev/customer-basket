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
    public class Milk_UnitTests
    {
        [Test]
        public void ShouldReturn115pPrice()
        {
            var sut = new Milk();

            var expected = 1.15m;

            Assert.AreEqual(expected, sut.Price);
        }

        [Test]
        public void ShouldReturnDefaultQuantity1()
        {
            var sut = new Milk();

            var expected = 1;

            Assert.AreEqual(expected, sut.Quantity);
        }
    }
}
