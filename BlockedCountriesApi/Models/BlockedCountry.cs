// Models/BlockedCountry.cs
namespace BlockedCountriesApi.Models
{
    public class BlockedCountry
    {
        public string Code { get; set; } = string.Empty; // ISO Alpha-2 Code
        public string Name { get; set; } = string.Empty;
    }
}
