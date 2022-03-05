using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
//using NUnit.Framework;

namespace codewarsio
{
    [TestClass]
    public class MaxDiffLength
    {

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length <= 0 || a2.Length <= 0)
                return -1;
            var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
            return Math.Max(first, second);
        }
    }

    public class ExampleTests
    {
        public static void test1()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
        }
    }
}
