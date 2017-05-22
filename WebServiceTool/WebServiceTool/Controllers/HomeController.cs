using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServiceTool.ViewModels;
using WebServiceTool.Services;


namespace WebServiceTool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SelectWebServiceVM model = APIServices.GetSelectWebServiceVM();
            return View(model);
        }

        public IActionResult OriginalIndex()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
