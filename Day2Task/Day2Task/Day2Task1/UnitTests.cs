using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Day2Task1
{
    [TestFixture]
    class UnitTests
    {
        
        [Test]
        public static void InputValuePositiveTest()
        {
            InputValueCheck vc = new InputValueCheck();
            int p = 7;
            Assert.AreEqual(true, vc.PValueCheck(p));
        }
        [Test]
        public static void InputValueNegativeTestLarge()
        {
            InputValueCheck vc = new InputValueCheck();
            int p = 87;
            Assert.AreEqual(true, vc.PValueCheck(p));
        }
        [Test]
        public static void InputValueNegaviteTestLess()
        {
            InputValueCheck vc = new InputValueCheck();
            int p = 1;
            Assert.AreEqual(true, vc.PValueCheck(p));
        }
        [Test]
        public static void InputValueNegaviteTestMinus()
        {
            InputValueCheck vc = new InputValueCheck();
            int p = -7;
            Assert.AreEqual(true, vc.PValueCheck(p));
        }
        [Test]
        public static void ConvertingNumberToBinary()
        {
            Converter c = new Converter();
            int number = 39;
            int p = 2;
            String result = "100111";
            StringAssert.AreEqualIgnoringCase(result, c.ConvertNumToP(number, p));
        }
        [Test]
        public static void ConvertingNumberToOctal()
        {
            Converter c = new Converter();
            int number = 394;
            int p = 8;
            String result = "612";
            StringAssert.AreEqualIgnoringCase(result, c.ConvertNumToP(number, p));
        }

        [Test]
        public static void ConvertingNumberTohexadecimal()
        {
            Converter c = new Converter();
            int number = 69478;
            int p = 16;
            String result = "10F66";
            StringAssert.AreEqualIgnoringCase(result, c.ConvertNumToP(number, p));
        }

        public static void ConvertingNumberZero()
        {
            Converter c = new Converter();
            int number = 0;
            int p = 6;
            String result = "0";
            StringAssert.AreEqualIgnoringCase(result, c.ConvertNumToP(number, p));
        }
               
    }
}
