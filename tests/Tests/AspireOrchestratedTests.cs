using System.Threading.Tasks;

namespace Anima.Blueprint.Tests;

[Collection("DistributedAppTestCollection")]
public class AspireOrchestratedTests(DistributedAppTestFixture fixture)
{
    [Fact]
    public async Task HealthCheck_ValidRequest_ShouldReturnResponse()
    {
        // Act
        var response = await fixture._httpClient!.GetAsync("/");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
