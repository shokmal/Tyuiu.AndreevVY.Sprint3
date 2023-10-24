﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AndreevVY.Sprint3.Task4.V30.Lib;

namespace Tyuiu.AndreevVY.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -0.192;
            Assert.AreEqual(wait, res);
        }
    }
}
