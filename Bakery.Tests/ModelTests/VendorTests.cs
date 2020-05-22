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

        [TestMethod]
        public void VendorConstructor_AddsVendorsTo_VendorList()
        {
            Vendor newVendor1 = new Vendor("Bob", "asian");
            Vendor newVendor2 = new Vendor("Rob", "american");
            List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};

            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

    }
}