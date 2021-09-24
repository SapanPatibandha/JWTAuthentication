using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<WeatherModel> weathers = new List<WeatherModel> 
            {
                new WeatherModel{ Date = DateTime.Now, Summary="test summary1", TemperatureC =10 },
                new WeatherModel{ Date = DateTime.Now.AddDays(-2), Summary="test summary2", TemperatureC =20 }
            };
            return View(weathers);
        }
    }
}
