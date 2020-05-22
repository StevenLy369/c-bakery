using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace Bakery.TestTools
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOf_Order()
        {
            Order newOrder = new Order("asian", "3/4/3", 9, "wow");
            
            Assert.AreEqual(typeof(Order), newOrder.GetType());

        }

        

    }
}