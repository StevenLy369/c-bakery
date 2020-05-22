using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;



namespace Bakery.Controllers
{
    public class VenderController : Controller
    {

       [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendor = Vendor.GetAll();
            return View(allVendor);
        }

      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }
    }
}