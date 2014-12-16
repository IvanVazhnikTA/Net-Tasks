using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Day3Task1;
using System.Numerics;


namespace UnitTests
{


    [TestFixture]
    public class UnitTests
    {

        [Test]
        public static void PositiveBinaryByteValue()
        {
            byte Value = 124;
            string result = "01111100";

            Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:B}", Value));
        }
          [Test]
          public static void PositiveBinaryIntValue()
        {
            int Value = 23045;
            string result = "00000000 00000000 01011010 00000101";

            Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:B}", Value));
        }

         [Test]
         public static void PositiveBinaryLongValue()
          {
              long Value = 31906574882;
              string result = "00000000 00000000 00000000 00000111 01101101 11000111 10110010 00100010";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:B}", Value));
          }

          [Test]
          public static void PositiveBinaryBigValue()
          {
              BigInteger Value = 18446744073709551614;
              string result = "00000000 11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111110";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:B}", Value));
          }

          [Test]
          public static void PositiveHexByteValue()
          {
              byte Value = 124;
              string result = "7c";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:H}", Value));
          }

          [Test]
          public static void PositiveHexIntValue()
          {
              int Value = 23045;
              string result = "00 00 5a 05";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:H}", Value));
          }

          [Test]
          public static void PositiveHexLongValue()
          {
              long Value = 31906574882;
              string result = "00 00 00 07 6d c7 b2 22";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:H}", Value));
          }

          [Test]
          public static void PositiveHexBigValue()
          {
              BigInteger Value = 18446744073709551614;
              string result = "00 ff ff ff ff ff ff ff fe";

              Assert.AreEqual(result, String.Format(new BinaryFormatter(), "{0:H}", Value));
          }


          [Test]
          public static void NegativeFormatValueD()
          {
              int Value = 23045;
              string result = "00 00 5a 05";

              Assert.AreNotEqual(result, String.Format(new BinaryFormatter(), "{0:D}", Value));
          }
         
        [Test]
          public static void NegativeFormatValueC()
          {
              int Value = 23045;
              string result = "00000000 00000000 01011010 00000101";

              Assert.AreNotEqual(result, String.Format(new BinaryFormatter(), "{0:C}", Value));
          }

        [Test]
        [ExpectedException("System.FormatException")]
        public static void PositiveFormatValueException()
        {
            int Value = 23045;
            string result = "00000000 00000000 01011010 00000101";

            Assert.AreNotEqual(result, String.Format(new BinaryFormatter(), "{0:T}", Value));
       
        }
        
      

    }


}
