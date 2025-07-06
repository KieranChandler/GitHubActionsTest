using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Shouldly;

namespace GitHubActionsTest.Tests;

public class WeatherTests
{
    [Fact]
    public async Task CanGetForecast()
    {
        using var client = new WebApplicationFactory<Program>()
            .CreateClient();

        var response = await client.GetAsync("WeatherForecast");

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }
}