using System;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Services;
using Xunit;


namespace dotignore.test
{
    public class FileServiceTests
    {
        private readonly Mock<IFileSystem> _fileSystem;

        public FileServiceTests()
        {
            _fileSystem = new Mock<IFileSystem>();
        }

        [Fact]
        public async Task CreateIgnoreFileAsync_ShouldCreate_WhenCalled()
        {
            _fileSystem.Setup(x => x.File.WriteAllTextAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

            var fileService = new FileService(_fileSystem.Object);
            string content = "content";
            await fileService.CreateIgnoreFileAsync(content);

            _fileSystem.Verify(x => x.File.WriteAllTextAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()));
        }

        [Fact]
        public async Task AppendIgnoreFileAsync_ShouldAppend_WhenCalled()
        {
            string path = ".gitignore";
            var fs = new MockFileSystem();
            fs.AddFile(path, new MockFileData("content"));

            var fileService = new FileService(fs);
            string content = "content";
            await fileService.AppendIgnoreFileAsync(content);
            var expected = $"content{Environment.NewLine}content";
            Assert.Equal(fs.File.ReadAllText(path), expected);
        }

        [Fact]
        public async Task AppendIgnoreFileAsync_ShouldCreate_WhenFileNotExist()
        {
            string path = ".gitignore";
            var fs = new MockFileSystem();
            var fileService = new FileService(fs);
            string content = "content";
            await fileService.AppendIgnoreFileAsync(content);
            var expected = $"{Environment.NewLine}content";
            Assert.Equal(fs.File.ReadAllText(path), expected);
        }
    }
}