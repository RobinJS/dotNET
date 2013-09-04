using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LongestSubsequenceTest
{
    [TestClass]
    public class LongestSubsequenceTest
    {
        [TestMethod]
        public void TestFindLongestSubsequence()
        {
            List<int> numbers = new List<int>{ 9, 5, -3, 6, -8, 5, -5, 21, 5, 6, -5, 8, -6 };
            //List<int> expectedList = new List<int>{ 5, 5, 5 };
            List<int> tested = LongestSubsequence.FindLongestSubsequence(numbers);
            Assert.IsTrue(tested.Count == 3);
            for (int i = 0; i < tested.Count; i++)
            {
                Assert.AreEqual(5, tested[i]);
            }
        }
    }
}
