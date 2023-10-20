using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvanchikovDA.Sprint2.Task3.V11.Lib;

namespace Tyuiu.IvanchikovDA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 1.77777778;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
             DataService ds = new DataService();
        double x = 0;
        double res = ds.Calculate(x);
        double wait = 0.83333333;
        Assert.AreEqual(wait, res);

        [TestMethod]
        public void ValidCondition3()
             DataService ds = new DataService();
        double x = -1;
        double res = ds.Calculate(x);
        double wait = 2;
        Assert.AreEqual(wait, res);

        [TestMethod]
        public void ValidCondition4()

        }
    }
}
