using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_one
{
    public class ApiTwoClient
    {
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        private readonly HttpClient _client;

        public ApiTwoClient(HttpClient client) => _client = client;

        public async Task<WeatherForecast[]> GetWeatherAsync()
        {
            var responseMessage = await _client.GetAsync(""); // its at the root route
            var stream = await responseMessage.Content.ReadAsStreamAsync();
            var weather = await JsonSerializer.DeserializeAsync<WeatherForecast[]>(stream, _options);
            return weather;
        }
    }
}
