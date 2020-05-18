using Newtonsoft.Json;
using SSR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSR.Controllers
{
    public class HomeController : Controller
    {
        private SSR01_dbEntities db = new SSR01_dbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Bicycle()
        {
            return View();
        }
        public ActionResult Game()
        {
            return View();
        }
        public ActionResult Game2()
        {
            return View();
        }
        public ActionResult Learning()
        {
            return View();
        }
        public ActionResult Login(KeyModel key)
        {
            if (string.IsNullOrEmpty(key.KeyValue))
            {
                ModelState.AddModelError("KeyValue", "Required");
            }
            if (key.KeyValue != "GoodMorning")
            {
                ModelState.AddModelError("KeyValue", "Wrong!");
            }
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Pedestrain()
        {
            return View();
        }
        public ActionResult Road()
        {
            return View();
        }
        public ActionResult Safe_pro()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        public ActionResult Checklist()
        {
            return View();
        }
        public ActionResult Power()
        {
            return View();
        }
        public ActionResult School_Statistic()
        {
            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            try
            {
                ViewBag.DataPoints = JsonConvert.SerializeObject(db.Road.ToList(), _jsonSetting);

                return View();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return View("Error");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return View("Error");
            }
        }
    }
}