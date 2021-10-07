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

        public async Task CreateIgnoreFileAsync_ShouldCreate_WhenFileNotExist()
        {
            //Arrange
            string path=".gitignore";
            string content="content";
            var fs=new MockFileSystem();
            var fileService=new FileService(fs);
            //Act
            await fileService.CreateIgnoreFileAsync(content);
            //Assert
            var expected="content";
            Assert.Equal(expected,fs.File.ReadAllText(path));
        }

        [Fact]
        public async Task CreateIgnoreFileAsync_ShouldOverwrite_WhenFileExist()
        {
            //Arrange
            string path=".gitignore",existedContent="exsited",content="content";
            
            var fs=new MockFileSystem();
            fs.AddFile(path,new MockFileData(existedContent));

            var fileService=new FileService(fs);
            //Act
            await fileService.CreateIgnoreFileAsync(content);
            //Assert
            var expected="content";

            Assert.Equal(expected,fs.File.ReadAllText(path));
            Assert.NotEqual(existedContent,fs.File.ReadAllText(path));
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

        [Fact]
        public void IsExist_ShouldReturnTrue_WhenFileExist()
        {
            string path = ".gitignore";
            var fs = new MockFileSystem();
            fs.AddFile(path,null);
            var fileService = new FileService(fs);

            var actual=fileService.IsExist();

            Assert.True(actual);
        }

        [Fact]
        public void IsExist_ShouldReturnFalse_WhenFileNotExist()
        {
            var fs = new MockFileSystem();   
            var fileService = new FileService(fs);
            var actual=fileService.IsExist();
            Assert.False(actual);
        }
    }
}