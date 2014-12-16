using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Day4Task;


namespace UnitTests
{



    [TestFixture]
    public class UnitTest
    {
        Polynomial p1;
        Polynomial p2;

        [SetUp]
        public void Init()
        {
            p1 = new Polynomial(2.5, 5, 4.78);
            p2 = new Polynomial(2, 7, 8.8, 1.1);

        }

        [TearDown]
        public void Dest()
        {

            p1 = null;
            p2 = null;
        }


        [Test]
        public void PolyPlusTest()
        {
            Polynomial p3 =p1+p2;
            string result = "Coefficients:*4,5;*12;*13,58;*1,1";
            Assert.AreEqual(result, p3.ToString());
        }

        [Test]
        public void PolyMinusTest()
        {
            Polynomial p3 = p1 - p2;
            string result = "Coefficients:*0,5;*-2;*-4,02;*-1,1";
            Assert.AreEqual(result, p3.ToString());
            
        }

        [Test]
        public void PolyCalculateTest()
        {
            double x = 0.3;
            double result = 4.4302;
            Assert.AreEqual(result, p1.Calculate(x));

        }

        [Test]
        public void PolyMultiTest()
        {
            Polynomial p3 = p1 * p2;
            string result = "Coefficients:*5;*27,5;*66,56;*80,21;*47,564;*5,258";
            Assert.AreEqual(result, p3.ToString());
        }
      
        [Test]
        public void PolyEqualsTest()
        {
            Assert.False(p1 == p2);
        }


    }
}
