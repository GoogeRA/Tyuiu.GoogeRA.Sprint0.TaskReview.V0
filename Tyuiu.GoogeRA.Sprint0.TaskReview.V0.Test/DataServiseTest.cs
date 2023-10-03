using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GoogeRA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(45, DataService.Calc(3, 2, 4));
        }
    }
}

