using CustomerBasket.Factory;
using CustomerBasket.Interfaces;
using CustomerBasket.Models;
using CustomerBasket.Models.Discount;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBasket.UnitTests.Models.Discount_UT
{
    [TestFixture]
    class PercentageBreadDiscount_UnitTests
    {
        PercentagePriceDiscount sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            var product = ProductFactory.Get("butter", 2);
            var target = ProductFactory.Get("bread", 1);
            sut = new PercentagePriceDiscount(product, target, 50);
        }

        [Test]
        public void ShouldReturnOneHalfPriceBreadDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("butter", 2),
                ProductFactory.Get("bread", 1)
            };

            var expected = 0.5;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnFiveHalfPriceBreadsDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("butter", 10),
                ProductFactory.Get("bread", 7)
            };

            var expected = 2.5;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnSixHalfPriceBreadsDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("butter", 12),
                ProductFactory.Get("bread", 15)
            };

            var expected = 3;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnTwoHalfPriceBreadDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("butter", 4),
                ProductFactory.Get("bread", 2)
            };

            var expected = 1;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldNotReturnAnyDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("butter", 1),
                ProductFactory.Get("bread", 1)
            };

            var expected = 0;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldNotReturnAnyDiscountWhenNoBread()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 1),
                ProductFactory.Get("butter", 2)
            };

            var expected = 0;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }
    }
}
