using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using Models;
using System.Threading.Tasks;

namespace Services
{
    public class FileService
    {
        private const string PATH=".gitignore";
        public async Task CreateIgnoreFileAsync(string content)=>await File.WriteAllTextAsync(PATH,content);
    }
}