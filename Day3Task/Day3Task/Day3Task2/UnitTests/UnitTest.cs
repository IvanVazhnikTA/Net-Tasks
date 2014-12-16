using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Day3Task2;
using System.Numerics;

namespace UnitTests
{

    [TestFixture]
    class UnitTest
    {

        [Test]
        public static void PositiveNewtonCalculation()
        {

            BigInteger number = 137231006679;
            int n = 7;
            int accuracy = 1000;
            double result = 39;

            Assert.AreEqual(result, Newton.NCalc(number, n, accuracy));
            
        }

        [Test]
        public static void NegativeNewtonCalculation()
        {

            BigInteger number = 137231006679;
            int n = 7;
            int accuracy = 1000;
            double result = 27;

            Assert.AreNotEqual(result, Newton.NCalc(number, n, accuracy));

        }

        [Test]
        public static void PositiveValueCheck()
        {

            BigInteger number = 137231006679;
            int n = 7;
            int accuracy = 1000;
           
            Assert.IsTrue(ValueCheck.InputCheck(number, n, accuracy));

        }

        [Test]
        public static void NegativeValueCheckNumber()
        {

            BigInteger number = -78947586;
            int n = 7;
            int accuracy = 1000;

            Assert.IsFalse(ValueCheck.InputCheck(number, n, accuracy));

        }
        [Test]
        public static void NegativeValueCheckN()
        {

            BigInteger number = 78947586;
            int n = -7;
            int accuracy = 1000;

            Assert.IsFalse(ValueCheck.InputCheck(number, n, accuracy));

        }

        [Test]
        public static void NegativeValueCheckAccuracy()
        {

            BigInteger number = 78947586;
            int n = 7;
            int accuracy = -1000;

            Assert.IsFalse(ValueCheck.InputCheck(number, n, accuracy));

        }




    }
}
