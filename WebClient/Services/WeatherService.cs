using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebClient.Extensions;
using WebClient.Models;


namespace WebClient.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public WeatherService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<WeatherModel>> GetWeather()
        {
            var response = await _client.GetAsync($"/WeatherForecast");
            return await response.ReadContentAs<List<WeatherModel>>();
        }
    }
}
