using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KonferansProje.DTO;
using KonferansProje.Models;


namespace KonferansProje.Controllers
{
    public class HomeController : Controller
    {
        DbEntities db = new DbEntities();
        public ActionResult Index()

        {
            var model = db.konferans_tbl.ToList();

            return View(model);
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Admin's page.";
            return View(new admin_tbl());
        }

        [HttpPost]
        public ActionResult Login(admin_tbl data)
        {

            var kullanici = db.admin_tbl.Where(x => x.username == data.username && x.password == data.password).FirstOrDefault();

  
            if (kullanici!= null)
            {
                return RedirectToAction("Index", "AdminPanel");
            }
            else
            {
                ViewBag.Message = "Hatalı veri Girişi";
                return View(new admin_tbl());
            }
            
        }
        [HttpGet]
        public ActionResult Konferanslar()
        {

            var model = db.konferans_tbl.ToList();

            return View(model);
        }
        [HttpPost]
        public ActionResult Konferanslar(ConferenceDto conferenceDto )
        {

   
              return RedirectToAction("FormController", "RegistrationForm");
      

  }

       
    }

}