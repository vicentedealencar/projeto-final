using AttributeRouting.Web.Mvc;
using PF2.Data.Models;
using PF2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PF2.Web.Controllers
{
    public class ItemController : BaseController
    {
        [GET("/Loja/{storeId}/Item/{itemId}")]
        public ActionResult Index(int storeId, int itemId)
        {
            var store = db.Stores.FirstOrDefault(x => x.Id == storeId) ?? new Store();
            var item = store.Items.FirstOrDefault(x => x.Id == itemId);

            if (item == null)
                return View("ItemNotFound");

            return View(new ItemVM(item));
        }

    }
}
