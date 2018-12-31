using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using roadmappr.Models;

namespace roadmappr.Data
{
    public class ApiMiddleware
    {
        private readonly HttpClient _client = new HttpClient();

        public ApiMiddleware()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36");
        }

        public async Task<Trello> Get(string uri, string parameter = null)
        {
            try
            {
                var responseStr = await _client.GetAsync(uri);
                var fullJson = responseStr.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Request returned code " + responseStr.StatusCode);

                return JsonConvert.DeserializeObject<Trello>(fullJson);
            }
            catch
            {
                return null;
            }
        }
    }
}
