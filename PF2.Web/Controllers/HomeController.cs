using AttributeRouting.Web.Mvc;
using PF2.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class HomeController : Controller
    {
        [GET("")]
        public ActionResult Index()
        {
            return View();
        }

        [GET("/OfficialeBayTime")]
        public ActionResult OfficialeBayTime()
        {
            var eBayService = new eBayService();

            return View(eBayService.OfficialTime());
        }

        [GET("/eBayProduct/{productId}")]
        public ActionResult eBayProduct(string productId)
        {
            //g930 -> 110119822551
            var eBayService = new eBayService();

            return Json(eBayService.FindProduct(productId) ,JsonRequestBehavior.AllowGet);
        }

    }
}
