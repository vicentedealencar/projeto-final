using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class PayPalController : BaseController
    {
        [POST("/PayPal/Success")]
        public ActionResult Success()
        {
            return Json(new{Form = Request.Form}, JsonRequestBehavior.AllowGet);
        }

        [GET("/PayPal/Cancel")]
        public ActionResult Cancel()
        {
            return View();
        }
    }
}
