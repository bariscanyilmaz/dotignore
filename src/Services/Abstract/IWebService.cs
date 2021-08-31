using System.Net.Http;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IWebService
    {
        Task<HttpResponseMessage> GetTemplateAsync(string template);

    }
}