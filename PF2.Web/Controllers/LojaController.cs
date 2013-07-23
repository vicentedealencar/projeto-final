using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class LojaController : Controller
    {
        [GET("/Lojas")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
