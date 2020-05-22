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

        [HttpGet("/vendor/{id}")]
        public ActionResult Show(int id)
        {
            Vendor vendor = Vendor.Find(id);
            List<Order> order = vendor.Orders;
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("vendor", vendor);
            model.Add("order", order);

            return View(model);
        }
    }
}