using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFileService
    {
        bool IsExist();
        Task CreateIgnoreFileAsync(string content);
        Task AppendIgnoreFileAsync(string content);
    }
}