// Services/BlockedCountriesService.cs
using BlockedCountriesApi.Models;
using BlockedCountriesApi.Interfaces;

namespace BlockedCountriesApi.Services
{
    public class BlockedCountriesService : IBlockedCountriesService
    {
        public IEnumerable<BlockedCountry> GetAll()
        {
            return BlockedCountriesStore.BlockedCountries
                .Select(kvp => new BlockedCountry { Code = kvp.Key, Name = kvp.Value });
        }

        public void Add(BlockedCountry country)
        {
            BlockedCountriesStore.BlockedCountries.TryAdd(country.Code.ToUpper(), country.Name);
        }

        public bool Remove(string code)
        {
            return BlockedCountriesStore.BlockedCountries.TryRemove(code.ToUpper(), out _);
        }

        public bool IsBlocked(string code)
        {
            return BlockedCountriesStore.BlockedCountries.ContainsKey(code.ToUpper());
        }
    }
}
