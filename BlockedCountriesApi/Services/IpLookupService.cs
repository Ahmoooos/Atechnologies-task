// Services/IpLookupService.cs
using BlockedCountriesApi.Models;
using BlockedCountriesApi.Interfaces;
using System.Net.Http.Json;

namespace BlockedCountriesApi.Services
{
    public class IpLookupService : IIpLookupService
    {
        private readonly HttpClient _httpClient;
        private readonly IBlockedCountriesService _blockedService;

        public IpLookupService(HttpClient httpClient, IBlockedCountriesService blockedService)
        {
            _httpClient = httpClient;
            _blockedService = blockedService;
        }

        public async Task<IpLookupResult> LookupAsync(string ip)
        {
            var url = $"https://ipapi.co/{ip}/json/";

            var response = await _httpClient.GetFromJsonAsync<IpLookupResult>(url);

            if (response is null) return null!;

            response.Ip = ip;
            response.IsBlocked = _blockedService.IsBlocked(response.CountryCode);

            return response;
        }
    }
}
