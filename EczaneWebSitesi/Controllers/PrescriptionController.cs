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

            // burada ilaçların adlarını bulacağız
            foreach (var recete in receteler)
            {
                // ilaç id'Lerini DrugsID'den aldım ve split yaptım. split virgüle göre ayırır.
                var splitted = recete.DrugsID.Split(',');
                foreach (var ilac_id in splitted)
                {
                    string ilac_adi = db.Drugs.Find(Convert.ToInt32(ilac_id)).Name;
                    recete.DrugNames.Add(ilac_adi);
                }
            }
            return View(receteler);
        }

        [HttpGet]
        public ActionResult AddPrescription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPrescription(Prescription recete)
        {
            if (ModelState.IsValid)
            {
                recete.PrescriptionDate = DateTime.Now;

                db.Prescriptions.Add(recete);
                db.SaveChanges();

                return View();
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeletePrescription(int id)
        {
            // id'sine göre secili olan reçeteyi buldum
            Prescription secili_recete = db.Prescriptions.Find(id);

            db.Prescriptions.Remove(secili_recete);
            db.SaveChanges();

            return RedirectToAction("ListPrescriptions");
        }
    }
}