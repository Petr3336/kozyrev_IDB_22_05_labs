using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    // Класс для вывода даты и времени в европейском формате
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo ci = new CultureInfo("fr-FR");
            return DateTime.Now.ToString(ci);
        }
    }
}
