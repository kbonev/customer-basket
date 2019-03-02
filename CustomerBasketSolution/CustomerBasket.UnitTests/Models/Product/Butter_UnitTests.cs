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
    class Butter_UnitTests
    {
        [Test]
        public void ShouldReturn80pPrice()
        {
            var sut = new Butter();

            var expected = 0.8m;

            Assert.AreEqual(expected, sut.Price);
        }
    }
}
