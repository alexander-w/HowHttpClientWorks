using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HowHttpClentWorks.Clients;

public interface IWeatherClient
{
    Task<Models.WeatherResponse?> GetCurrentWeatherForCity(string city);
}

public class OpenWeatherClient : IWeatherClient
{
    private const string OpenWeatherMapApiKey = "get your key from https://openweathermap.org/";
    private readonly HttpClient _httpClient;

    public OpenWeatherClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Models.WeatherResponse?> GetCurrentWeatherForCity(string city)
    {
        // Query: weather?q={city}&appid={key}&units=metric
        var url = $"weather?q={Uri.EscapeDataString(city)}&appid={OpenWeatherMapApiKey}&units=metric";

        return await _httpClient.GetFromJsonAsync<Models.WeatherResponse>(url);
    }
}
