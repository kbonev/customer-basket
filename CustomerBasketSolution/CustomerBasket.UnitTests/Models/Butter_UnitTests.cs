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
        public void ShouldReturn100pPrice()
        {
            var sut = new Butter();

            var expected = 1.0m;

            Assert.AreEqual(expected, sut.Price);
        }
    }
}
