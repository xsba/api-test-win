using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace api_test.integration_tests.ControllerTests
{
    public class HomeControllerTests : IClassFixture<CustomWebApplicationFactory<api_test.Startup>>
    {
        private readonly CustomWebApplicationFactory<api_test.Startup> _factory;

        //

        public HomeControllerTests(CustomWebApplicationFactory<api_test.Startup> factory)
        {
            _factory = factory;
        }

        //

        [Fact]
        public async Task Get_Root_Pid()
        {
            // Arrange
            var client = _factory.CreateClient();

            //Act
            var resp = await client.GetAsync("/");
            var body = await resp.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
            Assert.Matches(new Regex(@"^PID:\d+$"), body);
        }

    }
}
