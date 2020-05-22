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
            Order myOrder = new Order(description, date,price,title);
            return RedirectToAction("Index");
        }
    }
}
