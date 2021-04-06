using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KonferansProje.Models;
using KonferansProje.DTO;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace KonferansProje.Controllers
{
    public class FormController : Controller
    {
        DbEntities dbkonferans = new DbEntities();
        ConferenceDto db = new ConferenceDto();
        // GET: Form
        public ActionResult RegistrationForm(int conferenceid)
        {
           
            ViewBag.ConferenceId=conferenceid;
            //List<SelectListItem> konf = (from konferans in dbkonferans.konferans_tbl.ToList()
            //                             select new SelectListItem()
            //                             {
            //                                 Text = konferans.konferansAdi,
            //                                 Value = konferans.id.ToString()
            //                             }).ToList();
            //ViewBag.konferanslar = konf;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrationForm(ConferenceDto conference)
        {

            //var kullanici = dbkonferans.katilimci_tbl&&dbkonferans.konferans_tbl.Where(x => x.katilinankonf == konferans_Tbl.konferansAdi).FirstOrDefault();
           

            var conferencemodel = dbkonferans.konferans_tbl.Where(x => x.id == conference.ConferenceId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                conference.katilimci_Tbl.katilinankonf = conferencemodel.konferansAdi;
                conference.katilimci_Tbl.konferans_tbl = conferencemodel;


                dbkonferans.katilimci_tbl.Add(conference.katilimci_Tbl);
                dbkonferans.SaveChanges();

                ViewBag.Message = "Kayıt Başarılı";
                return RedirectToAction("Index", "Home");
            }
                   

         
                return View();
           





    

        }

    }

}
