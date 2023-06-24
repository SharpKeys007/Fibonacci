using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void GetFibonacciTest()
        {
            Assert.AreEqual(0, Fibonacci.GetFibonacci(0));
            Assert.AreEqual(5, Fibonacci.GetFibonacci(5));
            Assert.AreEqual(8, Fibonacci.GetFibonacci(6));
            Assert.AreEqual(10946, Fibonacci.GetFibonacci(21));
        }
    }
}