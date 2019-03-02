using CustomerBasket.Models;
using CustomerBasket.Models.Discount;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.UnitTests.Models.Discount
{
    [TestFixture]
    class PercentageBreadDiscount_UnitTests
    {
        PercentageBreadDiscount sut;

        [SetUp]
        public void SetUp() => sut = new PercentageBreadDiscount(new Butter(2), 50);

        [Test]
        public void ShouldReturnOneHalfPriceBreadDiscount()
        {
            var products = new List<Product>()
            {
                new Milk(4),
                new Butter(2),
                new Bread()
            };

            var expected = new Bread().Price / 2;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnTwoHalfPriceBreadDiscount()
        {
            var products = new List<Product>()
            {
                new Milk(4),
                new Butter(4),
                new Bread()
            };

            var expected = new Bread().Price;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldNotReturnAnyDiscount()
        {
            var products = new List<Product>()
            {
                new Milk(4),
                new Butter(1),
                new Bread()
            };

            var expected = 0;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }
    }
}
