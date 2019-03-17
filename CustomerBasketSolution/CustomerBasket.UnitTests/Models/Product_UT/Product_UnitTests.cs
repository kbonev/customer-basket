using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerBasket.Models;
using CustomerBasket.Factory;

namespace CustomerBasket.UnitTests.Models.Product_UT
{
    [TestFixture]
    public class Product_UnitTests
    {
        [Test]
        public void ShouldReturnQuantity3()
        {
            var sut = ProductFactory.Get("butter");

            sut.AddQuantity(2);

            Assert.AreEqual(3, sut.Quantity);
        } 

        [TestCase("bread", 4, 4)]
        [TestCase("butter", 6, 4.8)]
        [TestCase("milk", 3, 3.45)]
        public void ShouldTotal(string type, int quantity, decimal expected)
        {
            var sut = ProductFactory.Get(type, quantity);

            var result = sut.Total();

            Assert.AreEqual(expected, result);
        }        
    }
}
