using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyProblem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
              

        public ActionResult Calculator()
        {
            ViewBag.Message = "This is calculator Page";

            return View();
        }

        public ActionResult Miscelleneous()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            Response.Cookies.Add(new System.Web.HttpCookie("Nonce", string.Empty)
            {
                Expires = DateTime.Now.AddDays(-1D),
                Secure = true,
                HttpOnly = true
            });

            Response.Cookies.Add(new System.Web.HttpCookie("ARRAffinity", string.Empty)
            {
                Expires = DateTime.Now.AddDays(-1D),
                Secure = true,
                HttpOnly = true
            });

            return Redirect("https://agencyproblem20190411033125.azurewebsites.net/.auth/logout");
        }

        public ActionResult ChartDashBoard()
        {
            return View();
        }
    }
}