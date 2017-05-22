using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceTool.Models2;
using WebServiceTool.ViewModels;

namespace WebServiceTool.Services
{
    public static class APIServices
    {
        public static SelectWebServiceVM GetSelectWebServiceVM()
        {
            SelectWebServiceVM newVM = new SelectWebServiceVM()
            {
                Credentials = new Credentials(),
                AvailableWebServices = GetAvailableWebServices()
            };

            return newVM;
        }

        public static IEnumerable<SelectListItem> GetAvailableWebServices()
        {
            List<WebService> availableWS = new List<WebService>
            {
                new WebService() { Name = "Driver Log", ControllerAction = "DriverLogs/RequestForm"},
                new WebService() { Name = "Driver Log Details", ControllerAction = "DriverLogs/DetailsForm"}
            };

            IEnumerable<SelectListItem> returnList = availableWS.Select(x => 
                                                                new SelectListItem()
                                                                {
                                                                    Text = x.Name,
                                                                    Value = x.ControllerAction
                                                                }).ToList();

            return returnList;
        }
    }
}
