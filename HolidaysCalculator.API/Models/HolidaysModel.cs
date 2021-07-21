using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidaysCalculator.API.Models
{
    /// <summary>
    /// Holiday model
    /// </summary>
    public class HolidaysModel
    {
        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Public holidays
        /// </summary>
        public IEnumerable<PublicHolidayModel> PublicHolidayModels { get; set; }

        /// <summary>
        /// Total holiday count for country
        /// </summary>
        public int TotalCount => PublicHolidayModels.Count();
    }
}
