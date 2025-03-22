using EczaneWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EczaneWebSitesi.Controllers
{
    public class CustomerController : Controller
    {
        EczaneDBEntities db = new EczaneDBEntities();
        [HttpGet]
        
        public ActionResult ListCustomers()
        {
            List<Customer> musteriler = db.Customers.ToList();
            return View(musteriler);
        }
    }
}