using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using WheelDealRentalUserApplication.Models;

namespace WheelDealRentalUserApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            HttpClient client = new HttpClient();

            string URL = "https://localhost:44313/api/User/GetActiveOrders";

            
            HttpResponseMessage response = client.GetAsync(URL).Result;

            var result = response.Content.ReadAsAsync<List<Order>>().Result; 

            return View(result);
        }

        public IActionResult Delete(Guid id)
        {
            HttpClient client = new HttpClient();

            string URL = "https://localhost:44313/api/User/DeleteOrder";

            var model = new
            {
                Id = id
            };


            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(URL, content).Result;

            return RedirectToAction("Index");
        }

        

    }
}
