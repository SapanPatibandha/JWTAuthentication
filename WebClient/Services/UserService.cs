using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebClient.Extensions;
using WebClient.Models;

namespace WebClient.Services
{
    public class UserService : IUserService
    {

        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public UserService(HttpClient client, IConfiguration configuration)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<User> Authenticate(string username, string password)
        {
            LoginViewModel loginViewModel = new LoginViewModel() 
            { 
                User = username, 
                Password = password
            };


            var response = await _client.PostAsJson($"/Authenticate/login", loginViewModel);
            if (response.IsSuccessStatusCode)
            {
                User user = new User();

                return user;
            }
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }
    }
}
