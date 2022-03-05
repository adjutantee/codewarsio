using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
//using NUnit.Framework;

namespace codewarsio
{
    [TestClass]
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
    }

    public class ExampleTests
    {
        //[Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        //[Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", Kata.HighAndLow("1 2 3"));
        }
    }
}