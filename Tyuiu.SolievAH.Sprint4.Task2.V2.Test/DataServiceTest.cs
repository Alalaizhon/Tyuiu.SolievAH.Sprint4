using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint4.Task2.V2.Lib;
namespace Tyuiu.SolievAH.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 8, 1, 4, 1, 1, 1, 6, 2, 1, 3};
            int wait = 3;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
