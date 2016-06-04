using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tiplessCashJar.web.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Register()
        {
            return RedirectToAction("Dashboard", "Home");
        }

        [HttpPost]
        public ActionResult Login() {
            return RedirectToAction("Dashboard", "Home");
        }

        public ActionResult Settings() {
            return View();
        }

        [HttpPost]
        [ActionName("Settings")]
        public ActionResult SettingsSave() {
            return View();
        }

        public ActionResult ActivityHistory() {
            return View();
        }
    }
}