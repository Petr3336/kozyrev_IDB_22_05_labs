using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    // Класс для вывода даты и времени в американском формате
    public class AmericanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo ci = new CultureInfo("en-US");
            return DateTime.Now.ToString(ci);
        }
    }
}
