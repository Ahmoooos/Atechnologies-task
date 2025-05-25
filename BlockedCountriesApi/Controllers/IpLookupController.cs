// Controllers/IpLookupController.cs
using Microsoft.AspNetCore.Mvc;
using BlockedCountriesApi.Interfaces;

namespace BlockedCountriesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IpLookupController : ControllerBase
    {
        private readonly IIpLookupService _ipLookupService;

        public IpLookupController(IIpLookupService ipLookupService)
        {
            _ipLookupService = ipLookupService;
        }

        [HttpGet("{ip}")]
        public async Task<IActionResult> Lookup(string ip)
        {
            try
            {
                var result = await _ipLookupService.LookupAsync(ip);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Invalid IP address or external API error.");
            }
        }
    }
}
