using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint4.Task3.V6.Lib;

namespace Tyuiu.SolievAH.Sprint4.Task3.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] array = new int[,] { { 8, 8, 3, 4, 5 },
                                            { 8, 6, 6, 4, 6 },
                                            { 3, 6, 5, 3, 4 },
                                            { 5, 6, 3, 7, 5 },
                                            { 7, 8, 5, 6, 6 } };
            int res = dataService.Calculate(array);
            Assert.AreEqual(8, res);
        }
    }
}
