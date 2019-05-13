using AgencyProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biz = AgencyBusinessLayer.BClasses;

namespace AgencyProblem.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Products()
        {
            ViewBag.Message = "This is Products Page";
            List<BaseModel> m = new List<BaseModel>();
            Biz.Products biz = new Biz.Products();
            var vm = biz.GetProducts();
            foreach (var item in vm)
            {
                BaseModel m0 = new BaseModel();
                m0.InsuranceCode = item.InsuranceCode;
                m0.InsuranceDescription = item.InsuranceDescription;
                m0.InsuranceDuration = item.InsuranceDuration;
                m0.InsuranceName = item.InsuranceName;
                m0.InsurancePrice = item.InsurancePrice;
                m0.InsuranceType = item.InsuranceType;
                m.Add(m0);
            }

            return View(m);
        }
    }
}