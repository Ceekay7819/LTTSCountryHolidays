using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidaysCalculator.API.Models
{
    public class PublicHolidayModel
    {
        /// <summary>
        /// Date of the holiday
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Local name of the holiday
        /// </summary>
        public string LocalName { get; set; }

        /// <summary>
        /// English name of the holiday
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode { get; set; }
    }
}
