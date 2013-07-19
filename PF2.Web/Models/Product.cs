using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PF2.Web.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public double BuyPrice { get; set; }
        public double DepthInCm { get; set; }
        public double LengthInCm { get; set; }
        public double WidthInCm { get; set; }
        public double WeightInKg { get; set; }
    }
}