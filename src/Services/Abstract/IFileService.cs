using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFileService
    {
        Task CreateIgnoreFileAsync(string content);
    }
}