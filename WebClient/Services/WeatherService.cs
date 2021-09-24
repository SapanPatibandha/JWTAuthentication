using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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
            _client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoicGF0aWJhbmRoYSIsIlVzZXIiOiJwYXRpYmFuZGhhIiwiaWQiOiJiODY3MTEwNi05YmE3LTQyN2EtYmE5ZC1hYmJiZmJiY2RhYjciLCJqdGkiOiIzYmEwNzkyOS1jNjRmLTQ2NjAtOWU2My01MGViNTNhN2FiNDEiLCJleHAiOjE2MzI1MTY3OTksImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NjE5NTUiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQyMDAifQ.LvkRES26l0JA3RkFBrL0GgUPvuCBL1lt5SWg2FrOKtk");
        }

        public async Task<IEnumerable<WeatherModel>> GetWeather()
        {
            var response = await _client.GetAsync($"/WeatherForecast");
            return await response.ReadContentAs<List<WeatherModel>>();
        }
    }
}
