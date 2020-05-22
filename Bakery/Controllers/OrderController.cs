using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;


namespace Bakery.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/order")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }

        [HttpGet("/order/new")]
        public ActionResult New()
        {
            return View();
        }


        [HttpPost("/order")]
        public ActionResult Create(string description, string date, int price, string title)
        {
            Order myOrder = new Order(description, date, price, title);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendor/{vendorId}/order/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Dictionary<string, object> model = new Dictionary<string, object> { };
            Vendor vendor = Vendor.Find(vendorId);
            Order order = Order.Find(orderId);
            model.Add("vendor", vendor);
            model.Add("order", order);
            return View(model);
        }

        [HttpGet("/vendor/{vendorId}/order/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }


    }
}
