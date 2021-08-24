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
            _httpClient=client;
        }

        public async Task<string> GetTemplateAsync(string template)
        {
            var res = await _httpClient.GetAsync(baseURL(template));
            return await res.Content.ReadAsStringAsync();
        }

    }
}