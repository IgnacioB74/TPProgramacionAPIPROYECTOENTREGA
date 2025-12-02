using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Services
{
    public class ApiExterna : IApiExterna
    {
        private readonly HttpClient _client;

        public ApiExterna(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("ExternalApi");
        }

        public async Task<string> GetExternalDataAsync()
        {
            var response = await _client.GetAsync("/v1/data");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }

}




