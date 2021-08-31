using System.Net.Http;
using System.Threading.Tasks;

namespace Services
{
    public class WebService
    {
        private readonly HttpClient _httpClient;
        private string baseURL(string template) => $"https://raw.githubusercontent.com/github/gitignore/master/{template}.gitignore";
        public WebService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<HttpResponseMessage> GetTemplateAsync(string template)
        {
            return await _httpClient.GetAsync(baseURL(template)); 
        }

    }
}