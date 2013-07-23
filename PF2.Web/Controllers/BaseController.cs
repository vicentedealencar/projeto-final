using PF2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class BaseController : Controller
    {
        public MyContext db { get; set; }

        public BaseController()
        {
            db = new MyContext();
        }
    }
}
