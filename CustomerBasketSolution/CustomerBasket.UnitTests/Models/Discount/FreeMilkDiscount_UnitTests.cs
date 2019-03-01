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
        [Test]
        public void ShouldReturnOneMilkDiscount()
        {
            var sut = new FreeMilkDiscount(4);

            var products = new List<Product>()
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
            var sut = new FreeMilkDiscount(4);

            var products = new List<Product>()
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
            var sut = new FreeMilkDiscount(4);

            var products = new List<Product>()
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
