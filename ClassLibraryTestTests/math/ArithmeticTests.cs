using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTest.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.math.Tests
{
    [TestClass()]
    public class ArithmeticTests
    {
        [TestMethod()]
        [TestCategory("1")][TestCategory("2")] 
        public void addTest()
        {
            Arithmetic arithmetic = new Arithmetic();

            Assert.AreEqual(5, arithmetic.add(2, 3));
        }

        [TestMethod()]
        [TestCategory("2")]
        [ExpectedException(typeof(InvalidContentException))]
        public void AddTest2()
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.add(2, 0);
        }

        //[TestMethod()]
        //public void addTest1()
        //{

        //}

        //[TestMethod()]
        //public void addTest2()
        //{

        //}
    }
}