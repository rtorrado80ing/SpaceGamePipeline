using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGreatLibrary;

namespace MyGreatLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 cls = new Class1();
            Assert.AreEqual(2, cls.AddOne(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 cls = new Class1();
            Assert.AreEqual(0, cls.AddOne(-1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Class1 cls = new Class1();
            Assert.AreNotEqual(0, cls.AddOne(0));
        }
    }
}
