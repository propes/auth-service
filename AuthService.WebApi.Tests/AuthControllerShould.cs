using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json.Linq;
using Xunit;

namespace AuthService.WebApi.Tests
{
   public class AuthControllerShould : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public AuthControllerShould(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ReturnTokenWhenLoginDetailsAreValid()
        {
            var client = _factory.CreateClient();

            var response = await client.PostAsync("/login", JsonContent.Create("{ \"username\": \"admin\", \"password\": \"Welcome123!\" }"));

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var json = await response.Content.ReadAsStringAsync();

            var accessToken = JObject
                                .Parse(json)
                                .SelectToken("access_token")
                                .Value<string>();

            accessToken.Should().Be("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c");
        }
    }
}
