using EczaneWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EczaneWebSitesi.Controllers
{
    public class PrescriptionController : Controller
    {
        EczaneDBEntities db = new EczaneDBEntities();

        [HttpGet]
        public ActionResult ListPrescriptions()
        {
            List<Prescription> receteler = db.Prescriptions.ToList();
            return View(receteler);
        }
    }
}