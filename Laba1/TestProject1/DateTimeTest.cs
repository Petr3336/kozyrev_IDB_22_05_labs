using date_time;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Text;

namespace DateTimeTest
{
    [TestClass]
    public class DateTimePrinterTests
    {
        [TestMethod]
        public void EuropeanDateTimePrinter_PrintsCorrectFormat()
        {
            var printer = new EuropeanDateTimePrinter();
            var expectedFormat = "dd/MM/yyyy HH:mm:ss";

            var result = printer.PrintDateTime();

            Assert.IsTrue(DateTime.TryParseExact(result, expectedFormat, new CultureInfo("fr-FR"), DateTimeStyles.None, out _));
        }

        [TestMethod]
        public void AmericanDateTimePrinter_PrintsCorrectFormat()
        {
            var printer = new AmericanDateTimePrinter();
            var expectedFormat = "M/d/yyyy h:mm:ss tt";

            var result = printer.PrintDateTime();

            Assert.IsTrue(DateTime.TryParseExact(result, expectedFormat, new CultureInfo("en-US"), DateTimeStyles.None, out _));
        }

        [TestMethod]
        public void CustomDateTimeDecoratorAfter_AppendsCustomString()
        {
            var printer = new CustomDateTimeDecoratorAfter(new EuropeanDateTimePrinter(), " custom");
            var expectedFormat = "dd/MM/yyyy HH:mm:ss 'custom'";

            var result = printer.PrintDateTime();

            Assert.IsTrue(DateTime.TryParseExact(result, expectedFormat, new CultureInfo("fr-FR"), DateTimeStyles.None, out _));
        }

        [TestMethod]
        public void CustomDateTimeDecoratorBefore_PrependsCustomString()
        {
            var printer = new CustomDateTimeDecoratorBefore(new AmericanDateTimePrinter(), "custom ");
            var expectedFormat = "'custom 'M/d/yyyy h:mm:ss tt";

            var result = printer.PrintDateTime();

            Assert.IsTrue(DateTime.TryParseExact(result, expectedFormat, new CultureInfo("en-US"), DateTimeStyles.None, out _));
        }
    }
}
