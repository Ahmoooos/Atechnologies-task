// Services/BlockedCountriesStore.cs
using System.Collections.Concurrent;

namespace BlockedCountriesApi.Services
{
    public static class BlockedCountriesStore
    {
        public static ConcurrentDictionary<string, string> BlockedCountries { get; } = new();
    }
}
