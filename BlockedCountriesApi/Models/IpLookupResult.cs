// Models/IpLookupResult.cs
namespace BlockedCountriesApi.Models
{
    public class IpLookupResult
    {
        public string Ip { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public bool IsBlocked { get; set; }
    }
}
