using Newtonsoft.Json;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestLibrary;
namespace TestLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 object1 = new Class1();
            object1.DoSomething(10);
        }
    }
}
