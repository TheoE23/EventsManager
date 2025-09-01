using EventsManager.Models;
using System.Net.Http;
using System.Text.Json;


namespace EventsManager.Services
{
    public class WeatherFetchService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherFetchService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["WeatherStack:ApiKey"];
        }

        public async Task<decimal?> GetTemperatureAsync(string cityName)
        {
            var url = $"http://api.weatherstack.com/current?" +
                $"access_key={_apiKey}&query={cityName}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode == false)
            {
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);

            if (doc.RootElement.TryGetProperty("current", out var current))
            {
                if (current.TryGetProperty("temperature", out var tempElement))
                {
                    return tempElement.GetDecimal();
                }
            }
            return null;
        }


    }
}
