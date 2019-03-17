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

namespace CustomerBasket.UnitTests
{
    [TestFixture]
    class CustomerBasket_UnitTests
    {
        List<IDiscount> discounts = new List<IDiscount>();

        [SetUp]
        public void SetUp()
        {
            var milk = ProductFactory.Get("milk", 4);
            var butter = ProductFactory.Get("butter", 2);
            var bread = ProductFactory.Get("bread", 1);

            discounts = new List<IDiscount>()
            {
                new StaticPriceDiscount(milk, milk.Price),
                new PercentagePriceDiscount(butter, bread, 50)
            };
        }

        [Test]
        public void ShouldTotal295p()
        {
            var prods = new List<IProduct>()
            {
                ProductFactory.Get("milk", 1),
                ProductFactory.Get("butter", 1),
                ProductFactory.Get("bread", 1)
            };

            var sut = new CustomerBasket(prods, discounts);

            var result = sut.Total();

            var expected = 2.95m;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldTotal310p()
        {
            var prods = new List<IProduct>()
            {
                ProductFactory.Get("butter", 2),
                ProductFactory.Get("bread", 2)
            };

            var sut = new CustomerBasket(prods, discounts);

            var result = sut.Total();

            var expected = 3.10m;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldTotal345p()
        {
            var prods = new List<IProduct>()
            {
                ProductFactory.Get("milk", 4)
            };

            var sut = new CustomerBasket(prods, discounts);

            var result = sut.Total();

            var expected = 3.45m;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldTotal900p()
        {
            var prods = new List<IProduct>()
            {
                ProductFactory.Get("milk", 8),
                ProductFactory.Get("butter", 2),
                ProductFactory.Get("bread", 1)
            };

            var sut = new CustomerBasket(prods, discounts);

            var result = sut.Total();

            var expected = 9m;

            Assert.AreEqual(expected, result);
        }
    }
}
