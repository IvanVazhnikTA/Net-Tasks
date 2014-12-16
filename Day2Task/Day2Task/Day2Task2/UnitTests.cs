using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day2Task2
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public static void NODCalculationPositiveTest()
        {
            Calculation calc = new Calculation();
            
            int a = 1071;
            int b =  462;
            int result = 21;
            int time = 100;

            Assert.AreEqual(result,calc.NODCalc(time,a,b));
        }

        [Test]
        public static void NODCalculationPositiveTestWithTreeParams()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int c = 21;
            int result = 21;
            int time = 100;

            Assert.AreEqual(result, calc.NODCalc(time, a, b, c));
        }

        [Test]
        public static void NODCalculationNegativeTest()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int result = 7;
            int time = 100;

            Assert.AreEqual(result, calc.NODCalc(time, a, b));
        }

        [Test]
        public static void NODCalculationNegativeTestWithFourParams()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int c = 77;
            int d = 96;
            int result = 7;
            int time = 100;

            Assert.AreEqual(result, calc.NODCalc(time, a, b, c, d));
        }

        [Test]
        public static void NODCalculationTestWithNegativeNumber()
        {
            Calculation calc = new Calculation();

            int a =-1071;
            int b =-462;            
            int result =-21;
            int time = 100;

            Assert.AreEqual(result, calc.NODCalc(time, a, b));
        }

        [Test]
        public static void NODBinaryCalculationPositiveTest()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int result = 21;          

            Assert.AreEqual(result, calc.GCD(a, b));
        }

        [Test]
        public static void NODBinaryCalculationPositiveTestWithTreeParams()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int c = 21;            
            int result = 21;          

            Assert.AreEqual(result, calc.GCD(a, b, c));
        }

         [Test]
        public static void NODBinaryCalculationNegativeTest()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int result = 8;
            int time = 100;

            Assert.AreEqual(result, calc.GCD(time, a, b));
        }

         [Test]
        public static void NODBinaryCalculationNegativeTestWithTreeParams()
        {
            Calculation calc = new Calculation();

            int a = 1071;
            int b = 462;
            int c = 21;            
            int result = 8;           

            Assert.AreEqual(result, calc.GCD(a, b, c));
        }
         [Test]
         public static void NODBinaryCalculationTestWithNegativeNumber()
         {
             Calculation calc = new Calculation();

             int a = -1071;
             int b = -462;
             int result = -21;             

             Assert.AreEqual(result, calc.GCD(a, b));
         }
    }
}
