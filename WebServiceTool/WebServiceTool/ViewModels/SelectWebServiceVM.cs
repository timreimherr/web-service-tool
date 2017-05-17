using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceTool.Models2;

namespace WebServiceTool.ViewModels
{
    public class SelectWebServiceVM
    {
        public Credentials Credentials { get; set; }
        public IEnumerable<WebService> AvailableWebServices { get; set; }
    }
}
