using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyProblem.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Payment()
        {
            ViewBag.Message = "This is Payment page";
            return View();
        }

        public ActionResult PaymentDone()
        {
            ViewBag.Message = "Payment successful";
            return View();
        }
    }
}