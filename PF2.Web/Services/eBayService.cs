using eBay.Service.Call;
using eBay.Service.Core.Sdk;
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
    }
}