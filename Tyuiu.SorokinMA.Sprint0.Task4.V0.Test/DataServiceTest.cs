using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SorokinMA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(12, DataService.Addition(6, 6));
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(4, DataService.Subtraction(10, 6));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(36, DataService.Multiplication(6, 6));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(18, 6));
        }
    }
}
