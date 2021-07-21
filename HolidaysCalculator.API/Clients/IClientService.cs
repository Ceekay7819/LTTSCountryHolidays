using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidaysCalculator.API.Clients
{
    public interface IClientService
    {
        Task<string> GetCountryWithMostHolidayByYear(int year);
        Task<string> GetMonthWithMostHolidays(int year);
        Task<string> GetCountryWithMostUniqueHolidays(int year);
    }
}

