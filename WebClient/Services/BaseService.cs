using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebClient.Services
{
    public class BaseService
    {
        internal readonly HttpClient _client;

        public BaseService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

            _client.DefaultRequestHeaders.Authorization
             = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoicGF0aWJhbmRoYSIsIlVzZXIiOiJwYXRpYmFuZGhhIiwiaWQiOiJiODY3MTEwNi05YmE3LTQyN2EtYmE5ZC1hYmJiZmJiY2RhYjciLCJqdGkiOiJmNzQxNWEzMC1lY2ViLTQwMTctYjg1Mi04YTM1ZDExZGNhYzEiLCJleHAiOjE2MzI2MDczNjgsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NjE5NTUiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQyMDAifQ.twN-KSSqRIVoCX7jF444ZsFWF4GiJvqd-2fDUmqeFMM");

        }
    }
}
