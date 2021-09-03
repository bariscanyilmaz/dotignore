using System.Net.Http;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IWebService
    {
        Task<string> GetTemplateAsync(string template);

    }
}