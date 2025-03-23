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




        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            // eklediğiniz öğenin classına yazdığınız şartları kontrol eder. şartlara uyuyorsa çalışır.
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return View();
            }
            else
            {
                return View();
            }
          
        }
    }
}