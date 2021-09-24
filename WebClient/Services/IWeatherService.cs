using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherModel>> GetWeather();

    }
}
