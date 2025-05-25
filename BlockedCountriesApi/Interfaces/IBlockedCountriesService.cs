// Interfaces/IBlockedCountriesService.cs


using BlockedCountriesApi.Models;

namespace BlockedCountriesApi.Interfaces
{
    public interface IBlockedCountriesService
    {
        IEnumerable<BlockedCountry> GetAll();
        void Add(BlockedCountry country);
        bool Remove(string code);
        bool IsBlocked(string code);
    }
}
