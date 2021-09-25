using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebClient.Services;

namespace WebClient.Controllers
{
    public class WeatherController : ControlerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));
        }

        public async Task<IActionResult> Index()
        {
            //List<WeatherModel> weathers = new List<WeatherModel> 
            //{
            //    new WeatherModel{ Date = DateTime.Now, Summary="test summary1", TemperatureC =10 },
            //    new WeatherModel{ Date = DateTime.Now.AddDays(-2), Summary="test summary2", TemperatureC =20 }
            //};

            var weathers = await _weatherService.GetWeather();

            return View(weathers);
        }
    }
}
