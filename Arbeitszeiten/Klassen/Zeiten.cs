using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeiten.Klassen
{
    public class Zeiten
    {
        /// <summary>
        /// Gets the first day of week.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns>the first day of the week</returns>
        public static DateTime GetFirstDayOfWeek(DateTime dateTime)
        {
            while (dateTime.DayOfWeek != DayOfWeek.Monday)
                dateTime = dateTime.Subtract(new TimeSpan(1, 0, 0, 0));
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        /// <summary>
        /// Gets the last day of week.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns>the last day of the week</returns>
        public static DateTime GetLastDayOfWeek(DateTime dateTime)
        {
            while (dateTime.DayOfWeek != DayOfWeek.Sunday)
                dateTime = dateTime.AddDays(1);
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}
