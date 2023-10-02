using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SorokinMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SorokinMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessage()
        {
            var name = "Михаил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Михаил", res);
        }
    }
}
