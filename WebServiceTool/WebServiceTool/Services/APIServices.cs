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

        public static List<WebService> GetAvailableWebServices()
        {
            List<WebService> availableWS = new List<WebService>
            {
                new WebService() { Name = "Driver Log", ControllerAction = "DriverLog/Index"}
            };

            return availableWS;
        }
    }
}
