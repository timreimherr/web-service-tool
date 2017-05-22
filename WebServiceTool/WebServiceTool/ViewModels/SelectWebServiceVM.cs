using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebServiceTool.Models2;

namespace WebServiceTool.ViewModels
{
    public class SelectWebServiceVM
    {
        public Credentials Credentials { get; set; }

        [Display(Name = "Available Web Services")]
        public IEnumerable<SelectListItem> AvailableWebServices { get; set; }

        public string SelectedWebService { get; set; }
    }
}
