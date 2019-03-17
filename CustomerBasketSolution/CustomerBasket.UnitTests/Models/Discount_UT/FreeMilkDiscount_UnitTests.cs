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
    class FreeMilkDiscount_UnitTests
    {
        StaticPriceDiscount sut;

        [SetUp]
        public void SetUp()
        {
            var product = ProductFactory.Get("milk", 4);
            sut = new StaticPriceDiscount(product, product.Price);
        }

        [Test]
        public void ShouldReturnOneMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4),
                ProductFactory.Get("bread", 1)
            };

            var expected = 1.15;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnTwoMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 8),
                ProductFactory.Get("bread", 1)
            };

            var expected = 2.3;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldNotReturnMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                ProductFactory.Get("milk", 3),
                ProductFactory.Get("bread", 1)
            };

            var expected = 0;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }
    }
}
