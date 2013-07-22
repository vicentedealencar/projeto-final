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
        private eBayService eBayService { get; set; }

        public HomeController()
        {
            eBayService = new eBayService();
        }

        [GET("")]
        public ActionResult Index()
        {
            return View();
        }

        [GET("/OfficialeBayTime")]
        public ActionResult OfficialeBayTime()
        {
            return View(eBayService.OfficialTime());
        }

        [GET("/eBayProduct/{productId}")]
        public ActionResult eBayProduct(string productId)
        {
            //g930 -> 110119822551
            //penny -> 110119905920
            return Json(eBayService.FindProduct(productId) ,JsonRequestBehavior.AllowGet);
        }

        [GET("/eBayPurchase/{productId}")]
        public ActionResult eBayPurchase(string productId)
        {
            return Json(eBayService.PurchaseProduct(productId, Request.UserHostAddress), JsonRequestBehavior.AllowGet);
        }

    }
}
