using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    // Конкретный декоратор, добавляющий символы к строке даты и времени в начало
    public class CustomDateTimeDecoratorBefore : DateTimeDecorator
    {
        private string customString;

        public CustomDateTimeDecoratorBefore(IDateTimePrinter dateTimePrinter, string customString)
            : base(dateTimePrinter)
        {
            this.customString = customString;
        }

        public override string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(customString);
            sb.Append(dateTimePrinter.PrintDateTime());
            return sb.ToString();
        }
    }
}
