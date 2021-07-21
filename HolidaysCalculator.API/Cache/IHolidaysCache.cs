using System;
using System.Threading.Tasks;

namespace HolidaysCalculator.API.Cache
{
    public interface IHolidaysCache
    {
        Task<T> GetOrCreateCacheAsync<T>(Func<T> method, string cacheKey)
            where T : class;
    }
}