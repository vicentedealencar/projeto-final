using AttributeRouting.Web.Mvc;
using PF2.Data;
using PF2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class StoreController : Controller
    {
        public MyContext db { get; set; }

        public StoreController()
        {
            db = new MyContext();
        }

        [GET("/Lojas")]
        public ActionResult Index()
        {
            var stores = db.Stores.Select(x => new StoreVM(x)).ToList();

            return View(stores);
        }

        [GET("/Loja/{storeId}")]
        public ActionResult Show(int storeId)
        {
            var store = db.Stores.FirstOrDefault(x => x.Id == storeId);

            if (store == null)
                return View("StoreNotFound");

            return View(new StoreVM(store));
        }
    }
}
