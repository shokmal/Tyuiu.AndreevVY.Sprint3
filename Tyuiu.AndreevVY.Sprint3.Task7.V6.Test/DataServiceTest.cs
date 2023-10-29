using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint3.Task7.V23.Lib;

namespace Tyuiu.AndreevVY.Sprint3.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] num = { 13.81, 11.87, 9.87, 7.74, 5.36, 2.5, 0, 0.79, -1.75, -3.78, -5.71 };
            CollectionAssert.AreEqual(num, ds.GetMassFunction(-5, 5));
        }
    }
}
