using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using PF2.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PF2.Web.Services
{
    public class eBayService
    {
        public ApiContext ApiContext { get; set; }

        public eBayService()
        {
            this.ApiContext = new ApiContext() 
            {
                SoapApiServerUrl = ConfigurationManager.AppSettings["Environment.ApiServerUrl"],
                Site = eBay.Service.Core.Soap.SiteCodeType.US,
                ApiCredential = new ApiCredential()
                {
                    eBayToken = ConfigurationManager.AppSettings["UserAccount.ApiToken"],
                }
            };
        }

        public DateTime OfficialTime() 
        {
            var officialTimeCall = new GeteBayOfficialTimeCall(this.ApiContext);
            return officialTimeCall.GeteBayOfficialTime();
        }

        public Product FindProduct(string productId)
        {
            var getItemCall = new GetItemCall(this.ApiContext);
            var item = getItemCall.GetItem(productId);

            return new Product()
            {
                Title = item.Title,
                SubTitle = item.SubTitle,
                BuyPrice = item.BuyItNowPrice.Value,
                DepthInCm = NormalizeMeasure(item.ShippingPackageDetails.PackageDepth),
                LengthInCm = NormalizeMeasure(item.ShippingPackageDetails.PackageLength),
                WidthInCm = NormalizeMeasure(item.ShippingPackageDetails.PackageWidth),
                WeightInKg = NormalizeMeasure(item.ShippingPackageDetails.WeightMajor),
            };
        }

        private double NormalizeMeasure(MeasureType measure)
        {
            if (measure == null)
                return -1;

            var unitFactors = new Dictionary<string,double>
            {
                {"cm", 1},
                {"m", 1/100},
                {"kg", 1},
                {"g", 1000},
                {"lbs", 0.453592}
            };

            return (double)measure.Value * unitFactors[measure.unit];
        }

    }
}