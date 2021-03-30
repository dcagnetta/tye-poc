using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_one.Controllers
{
    [ApiController]
    [Route("")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] ApiTwoClient client) => Ok(await client.GetWeatherAsync());
    }
}
