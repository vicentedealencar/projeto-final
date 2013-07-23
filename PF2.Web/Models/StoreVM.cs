using PF2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PF2.Web.Models
{
    public class StoreVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemVM> Items { get; set; }

        public StoreVM(Store store)
        {
            this.Id = store.Id;
            this.Name = store.Name;
            this.Items = store.Items.Select(x => new ItemVM(x)).ToList();
        }
    }
}