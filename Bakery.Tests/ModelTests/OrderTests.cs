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
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOf_Order()
        {
            Order newOrder = new Order("asian", "3/4/3", 9, "wow");
            
            Assert.AreEqual(typeof(Order), newOrder.GetType());

        }
        [TestMethod]
        public void OrderConstructor_AddsOrdersTo_OrderList()
        {
             Order newOrder1 = new Order("asian", "3/4/3", 9, "wow");
            Order newOrder2 = new Order("asian", "3/4/3", 9, "wow");
            List<Order> newList = new List<Order> {newOrder1, newOrder2};

            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        

    }
}