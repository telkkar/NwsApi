using System;
using System.Net.Http;
using Xunit;

namespace NwsApi.Tests
{
    public class NwsDataLoaderTest
    {
        [Fact]
        public void NwsDataLoader_NullHttpClientInConstructor_ThrowsException()
        {
            // Arrange
            HttpClient httpClient = null;
            string customUserAgent = "asdf";

            Action constructor = () =>
            {
                new NwsDataLoader(httpClient, customUserAgent);
            };

            // Act
            var exception = Record.Exception(constructor);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}
