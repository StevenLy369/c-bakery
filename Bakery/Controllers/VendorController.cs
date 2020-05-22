using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;



namespace Bakery.Controllers
{
    public class VenderController : Controller
    {

        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendor = Vendor.GetAll();
            return View(allVendor);
        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
        public ActionResult Create(string name, string description)
        {
            Vendor myItem = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendor/{vendorid}")]
        public ActionResult Show(int vendorId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor vendor = Vendor.Find(vendorId);
            List<Order> vendorOrders = vendor.Orders;
            model.Add("vendor", vendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
    }
}