using System;
using NUnit.Framework;

namespace Kaizenko.TempConv.Tests
{
    public class TemperatureConverterTests
    {
        [Test]
        public void ConvertCtoF_When0C_Expect32F()
        {
           //ARRANGE
            TemperatureConverter tempConverter = new TemperatureConverter();
           //ACT
            double tempInF =  tempConverter.ConvertCtoF(0);
            //ASSERT
         
            Assert.AreEqual(32, tempInF);
        }

        [Test]
        public void ConvertCtoF_When100C_Expect212F()
        {
           TemperatureConverter tempConverter = new TemperatureConverter();
           double tempInF = tempConverter.ConvertCtoF(100);
           Assert.AreEqual(212, tempInF);
          //Assert.That(tempInF, isW)
        }

        [Test]
        public void ConvertCtoF_WhenNegative40_ExpectNegative40F()
        {
           TemperatureConverter tempConverter = new TemperatureConverter();
           double tempInF = tempConverter.ConvertCtoF(-40);
            Assert.AreEqual(-40, tempInF);
        }

        [Test]
        public void ConvertCtoF_When37C_Expect98Point6()
        {
            TemperatureConverter tempConverter = new TemperatureConverter();
            double tempInF = tempConverter.ConvertCtoF(37);
            Assert.AreEqual(98.6, tempInF);
        }

    }

}
