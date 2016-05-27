using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uppgift3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Tests
{
    [TestClass()]
    public class CalculationTests
    {

        //three and two 
        [TestMethod()]

        public void GetCurrentSpeedTest_textInput()
        {
            //arrange 
            var cal = new Calculation();
            //act 
            var actual = cal.GetCurrentSpeed("six", "two");
            var expected = 3;
            Assert.AreEqual(expected, actual, "input with text /three and two ");
        }

        //2.2 and 4,5 Number With point and number with comma 
        [TestMethod()]

        public void GetCurrentSpeedTest_PointAndCommaInput()
        {
            //arrange 
            var cal = new Calculation();
            //act 
            var actual = cal.GetCurrentSpeed("8.0", "2,0");
            var expected = 4;
            Assert.AreEqual(expected, actual, "Point and comma inPut  ");
        }

        //number with letter 
        [TestMethod()]

        public void GetCurrentSpeedTest_NumberWithLetterInput()
        {
            //arrange 
            var cal = new Calculation();
            //act 
            var actual = cal.GetCurrentSpeed("8K", "2m");
            var expected = 8;
            Assert.AreEqual(expected, actual, "Input number with Letter  ");
        }
    }
}