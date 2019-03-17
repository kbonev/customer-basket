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

        //[SetUp]
        //public void SetUp()
        //{
        //    discounts = new List<IDiscount>()
        //    {
        //        new FreeMilkDiscount(new Milk(4)),
        //        new PercentageBreadDiscount(new Butter(2), 50)
        //    };
        //}

        //[Test]
        //public void ShouldTotal295p()
        //{
        //    var prods = new List<IProduct>()
        //    {
        //        new Butter(),
        //        new Bread(),
        //        new Milk()
        //    };

        //    var sut = new CustomerBasket(prods, discounts);

        //    var result = sut.Total();

        //    var expected = 2.95m;

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void ShouldTotal310p()
        //{
        //    var prods = new List<IProduct>()
        //    {
        //        new Butter(2),
        //        new Bread(2),
        //    };

        //    var sut = new CustomerBasket(prods, discounts);

        //    var result = sut.Total();

        //    var expected = 3.10m;

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void ShouldTotal345p()
        //{
        //    var prods = new List<IProduct>()
        //    {
        //        new Milk(4)
        //    };

        //    var sut = new CustomerBasket(prods, discounts);

        //    var result = sut.Total();

        //    var expected = 3.45m;

        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void ShouldTotal900p()
        //{
        //    var prods = new List<IProduct>()
        //    {
        //        new Milk(8),
        //        new Bread(),
        //        new Butter(2)
        //    };

        //    var sut = new CustomerBasket(prods, discounts);

        //    var result = sut.Total();

        //    var expected = 9m;

        //    Assert.AreEqual(expected, result);
        //}
    }
}
