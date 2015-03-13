using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopModel.BuisnessFacade;
using ShopModel.Domain;
using ShopModel;
using Moq;

namespace ShopModelTests
{
    [TestClass()]
    public class ShopModelTests
    {
        [TestMethod()]
        [ExpectedException(typeof(NoProductException))]
        public void IfNotProductsThenThrowExceptionSendReportsTest()
        {
            var build = new Mock<IProductBuilder>();
            build.Setup(m => m.AddProducts()).Returns(new List<Product>());

            var calc = new Mock<IValueCalculator>();
            
            var cart = new ShoppingCart(calc.Object, build.Object);

            cart.CalculateProductTotal();
        }





        public void TestMethod1()
        {
        }
    }
}
