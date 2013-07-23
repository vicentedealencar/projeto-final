using PF2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PF2.Web.Models
{
    public class ItemVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ItemVM(Item item)
        {
            this.Id = item.Id;
            this.Title = item.Title;
            this.SubTitle = item.SubTitle;
            this.Description = item.Description;
            this.Price = item.Price;
        }
    }
}