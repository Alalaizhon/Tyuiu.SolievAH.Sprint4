using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint4.Task5.V28.Lib;

namespace Tyuiu.SolievAH.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -6, 2, -4, 1, 0 },
                                          { -3, -1, -5, 2, 2 },
                                          { 1, 1, 2, -3, -1 },
                                          { -5, -3, -2, 2, 0 },
                                          { 1, 2, 2, -2, 2 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] {  { 0, 2, 0, 1, 0 },
                                          { 0, 0, 0, 2, 2 },
                                          { 1, 1, 2, 0, 0 },
                                          { 0, 0, 0, 2, 0 },
                                          { 1, 2, 2, 0, 2 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
