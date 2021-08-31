using System.IO;
using System.Threading.Tasks;
using Services.Abstract;

namespace Services
{
    public class FileService:IFileService
    {
        private const string PATH=".gitignore";
        public async Task CreateIgnoreFileAsync(string content)=>await File.WriteAllTextAsync(PATH,content);
    }
}