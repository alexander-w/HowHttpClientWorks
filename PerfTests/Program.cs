using NBomber.CSharp;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://localhost:5001/"),
    Timeout = TimeSpan.FromSeconds(5)
};

var scenario = Scenario.Create("weather_scenario", async context =>
{
    var step = await Step.Run("get_weather", context, async () =>
    {
        var response = await httpClient.GetAsync("weather/London");

        return response.IsSuccessStatusCode
            ? Response.Ok()
            : Response.Fail();
    });

    return Response.Ok();
})
.WithWarmUpDuration(TimeSpan.FromSeconds(5))
.WithLoadSimulations(
    Simulation.KeepConstant(
        copies: 20,
        during: TimeSpan.FromSeconds(30))
);

NBomberRunner
    .RegisterScenarios(scenario)
    .Run();