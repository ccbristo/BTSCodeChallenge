using System;
using System.Collections.Generic;
using BTSCodeChallenge.BLL.BLLs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BTSCodeChallenge.LogicTests
{
    [TestClass]
    public class ChallengeOneTests
    {
        [TestMethod]
        public void ChallengeOneIsCorrect()
        {
            var inputList = new List<int> {1, 59, 12, 43, 4, 58, 5, 13, 46, 3, 6};
            var correctOutput = new List<List<int>>
            {
                new List<int> { 1 },
                new List<int> { 3, 4, 5, 6 },
                new List<int> { 12, 13 },
                new List<int> { 43 },
                new List<int> { 46 },
                new List<int> { 58, 59 }
            };

            var actualOutput = ListHelper.FindConsecutiveSubListInListOfInts(inputList);

            AssertTwoListOfRunsAreEqual(correctOutput, actualOutput);
        }

        // Incase you ever need a method to validate this and give fun (and descriptive) error messages.
        public static void AssertTwoListOfRunsAreEqual(List<List<int>> correctList, List<List<int>> actualList)
        {
            //Custom Logic To Handle the lists are equal
            if (correctList.Count != actualList.Count) Assert.Fail("What are you even doing? The main lists don't even have the same length.");

            for (var i = 0; i < correctList.Count; i++)
            {
                if (correctList[i].Count != actualList[i].Count) Assert.Fail($"You done goofed! The lists at index {i} don't even have the same length.");

                for (var j = 0; j < correctList[i].Count; j++)
                {
                    if (correctList[i][j] != actualList[i][j]) Assert.Fail($"I mean, you got close-ish, but the actual value of {actualList[i][j]} with and index of {j} in list {i} does not match the correct value {correctList[i][j]}.");
                }
            }

            //Whoot you made it!
            Assert.IsTrue(true);
        }
    }
}
