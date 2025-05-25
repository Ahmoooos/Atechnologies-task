// Interfaces/IIpLookupService.cs
using BlockedCountriesApi.Models;
using System.Threading.Tasks;

namespace BlockedCountriesApi.Interfaces
{
    public interface IIpLookupService
    {
        Task<IpLookupResult> LookupAsync(string ip);
    }
}
