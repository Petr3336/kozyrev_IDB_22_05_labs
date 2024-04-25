using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    // Конкретный декоратор, добавляющий символы к строке даты и времени в конец
    public class CustomDateTimeDecoratorAfter : DateTimeDecorator
    {
        private string customString;

        public CustomDateTimeDecoratorAfter(IDateTimePrinter dateTimePrinter, string customString)
            : base(dateTimePrinter)
        {
            this.customString = customString;
        }

        public override string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dateTimePrinter.PrintDateTime());
            sb.Append(customString);
            return sb.ToString();
        }
    }
}
