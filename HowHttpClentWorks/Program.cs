using HowHttpClentWorks.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient<IWeatherClient, OpenWeatherClient>(client =>
{
    client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
});

Console.WriteLine($"ASPNETCORE_URLS = {Environment.GetEnvironmentVariable("ASPNETCORE_URLS")}");
Console.WriteLine($"HTTP_PORTS      = {Environment.GetEnvironmentVariable("HTTP_PORTS")}");
Console.WriteLine($"HTTPS_PORTS     = {Environment.GetEnvironmentVariable("HTTPS_PORTS")}");
//builder.WebHost.UseUrls("https://localhost:5001");

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();