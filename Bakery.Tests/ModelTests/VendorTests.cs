using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Bakery.TestTools
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOf_Vendor()
        {
            Vendor newVendor = new Vendor("bob", "asian");
            
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());

        }
    }
}