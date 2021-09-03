using System.IO;
using System.IO.Abstractions;
using System.Threading.Tasks;
using Services.Abstract;

namespace Services
{
    public class FileService:IFileService
    {
        private const string PATH=".gitignore";
        private readonly IFileSystem _fileSystem;
        public FileService(IFileSystem fileSystem)=>_fileSystem=fileSystem;
        public async Task CreateIgnoreFileAsync(string content)=>await _fileSystem.File.WriteAllTextAsync(PATH,content);
    }
}