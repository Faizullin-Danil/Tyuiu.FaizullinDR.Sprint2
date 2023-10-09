using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint2.Task5.V5.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 14;
            string res = ds.FindCardValue(x);
            string wait = "туз";
            Assert.AreEqual(wait, res);

            
        }
    }
}
