using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getDuplicatesTest()
        {
            string input = "I like eating apples";
            Assessment.Utility util = new Assessment.Utility();
            string output = util.showRepeatedLetters(input);
            Assert.AreEqual(output, "ileap");
        }

        [TestMethod]
        public void getVowelsTest()
        {
            string input = "I like eating apples";
            Assessment.Utility util = new Assessment.Utility();
            int output = util.showNumberOfVowels(input);
            Assert.AreEqual(output, 3);
        }

        [TestMethod]
        public void getNonVowelsTest()
        {
            string input = "I like eating apples";
            Assessment.Utility util = new Assessment.Utility();
            int output = util.showNonVowels(input);
            Assert.AreEqual(output, 9);
        }
    }
}
