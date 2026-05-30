using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTestingwithJenkins
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetAllTest()
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("/api/allstudents");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(200, (int)response.StatusCode);
        }

        [Theory]
        [InlineData(2, 200)]
        [InlineData(12, 204)]
        [InlineData(5, 200)]
        [InlineData(41, 204)]
        public async Task GetByIdTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync($"/api/student/{id}");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }
        [Theory]
        [InlineData(2, 200)]
        [InlineData(12, 204)]
        [InlineData(5, 200)]
        [InlineData(41, 204)]
        public async Task GetNameByIdTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync($"/api/student/{id}");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }
    }
}
