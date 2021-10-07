using System;
using Services.Abstract;
using System.IO.Abstractions;
using System.Threading.Tasks;


namespace Services
{
    public class FileService : IFileService
    {
        private const string PATH = ".gitignore";
        private readonly IFileSystem _fileSystem;
        public FileService(IFileSystem fileSystem) => _fileSystem = fileSystem;
        public bool IsExist() => _fileSystem.File.Exists(PATH);
        public async Task CreateIgnoreFileAsync(string content) => await _fileSystem.File.WriteAllTextAsync(PATH, content);
        public async Task AppendIgnoreFileAsync(string content) => await _fileSystem.File.AppendAllTextAsync(PATH, Environment.NewLine + content);

    }
}