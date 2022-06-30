using HttpClient.Configurations;
using HttpClient.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient.Services.Implementations
{
    public class ResponseService : IResponseService
    {
        private readonly General _general;
        public ResponseService(IOptions<General> generalOption)
        {
            _general = generalOption.Value;
        }
        public Models.Response GetResponseAsync()
        {
            var result = ResponseFromUrl(_general.Url);

            return result;
        }
        private Models.Response ResponseFromUrl(string url)
        {
            var httpClientHandler = new HttpClientHandler();

            var httpClient = new System.Net.Http.HttpClient(httpClientHandler)
            {
                BaseAddress = new Uri(url)
            };
            using (var result = httpClient.GetAsync(url).Result)
            {
                var response = JsonConvert.DeserializeObject<Models.Response>(result.Content.ReadAsStringAsync().Result);

                return response;
            }
        }
    }
}
