using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebServiceTool.Controllers
{
    public class DriverLogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        private async Task<T> GetWSObject<T>(string uriActionString)
        {
            T returnValue = default(T);

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(@"http://localhost:53900/");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(uriActionString);
                    response.EnsureSuccessStatusCode();
                    returnValue = JsonConvert.DeserializeObject<T>(((HttpResponseMessage)response).Content.ReadAsStringAsync().Result);
                }

                return returnValue;
            }
            catch (Exception e)
            {

                throw (e);
            }
        }

    }







}