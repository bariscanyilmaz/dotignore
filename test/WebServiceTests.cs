using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Services;
using Xunit;

namespace dotignore.test
{
    public class WebServiceTests
    {

        private readonly MockRepository _mockRepository;
        private readonly Mock<HttpMessageHandler> _mockHttpHandler;
        private readonly HttpClient _client;

        public WebServiceTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Default);
            _mockHttpHandler = _mockRepository.Create<HttpMessageHandler>();
            _client = new HttpClient(_mockHttpHandler.Object);
        }

        [Fact]
        public async Task GetTemplateAsync_ShouldReturnContent_WhenCalled()
        {
            //Arrange

            string expected = "content";
            _mockHttpHandler.Protected().Setup<Task<HttpResponseMessage>>
            (
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(expected)

            });

            var service = new WebService(_client);

            //Act
            var result = await service.GetTemplateAsync("template");

            //Assert
            Assert.Equal(expected, result);

        }





    }
}