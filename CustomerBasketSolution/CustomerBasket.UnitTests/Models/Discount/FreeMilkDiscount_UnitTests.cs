using CustomerBasket.Interfaces;
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
    class FreeMilkDiscount_UnitTests
    {
        FreeMilkDiscount sut;

        [SetUp]
        public void SetUp() => sut = new FreeMilkDiscount(new Milk(4));

        [Test]
        public void ShouldReturnOneMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                new Milk(4),
                new Bread()
            };

            var expected = new Milk().Price;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldReturnTwoMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                new Milk(8),
                new Bread()
            };

            var expected = new Milk().Price * 2;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldNotReturnMilkDiscount()
        {
            var products = new List<IProduct>()
            {
                new Milk(3),
                new Bread()
            };

            var expected = 0;

            var result = sut.Calculate(products);

            Assert.AreEqual(expected, result);
        }
    }
}
