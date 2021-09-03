using System.Net.Http;
using System.Threading.Tasks;
using Services.Abstract;

namespace Services
{
    public class WebService : IWebService
    {
        private readonly HttpClient _httpClient;
        private string baseURL(string template) => $"https://raw.githubusercontent.com/github/gitignore/master/{template}.gitignore";
        public WebService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> GetTemplateAsync(string template)
        {
            return await _httpClient.GetStringAsync(baseURL(template));
        }

    }
}