// Controllers/BlockedController.cs
using Microsoft.AspNetCore.Mvc;
using BlockedCountriesApi.Models;
using BlockedCountriesApi.Interfaces;

namespace BlockedCountriesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlockedController : ControllerBase
    {
        private readonly IBlockedCountriesService _blockedService;

        public BlockedController(IBlockedCountriesService blockedService)
        {
            _blockedService = blockedService;
        }

        [HttpPost]
        public IActionResult AddBlockedCountry([FromBody] BlockedCountry country)
        {
            if (string.IsNullOrWhiteSpace(country.Code) || string.IsNullOrWhiteSpace(country.Name))
                return BadRequest("Code and Name are required.");

            _blockedService.Add(country);
            return Ok($"Blocked {country.Name} ({country.Code})");
        }

        [HttpGet]
        public ActionResult<IEnumerable<BlockedCountry>> GetAll()
        {
            return Ok(_blockedService.GetAll());
        }

        [HttpDelete("{code}")]
        public IActionResult Remove(string code)
        {
            if (_blockedService.Remove(code))
                return Ok($"Unblocked country {code}");
            return NotFound($"Country with code {code} not found.");
        }
    }
}
