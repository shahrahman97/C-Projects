using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCP_Technical_Exercise_Challenge;

namespace TechnicalChallenge_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Dispose_PassedInInteger11_ExpectAssertToEqual()
        {
            int[] testArray = Exercise.Decompose(11);
            int[] expectedArray = { 1, 2, 4, 10 };

            CollectionAssert.AreEqual(expectedArray, testArray);
        }

        [TestMethod]
        public void Dispose_PassedInInteger50_ExpectAssertToEqual()
        {
            int[] testArray = Exercise.Decompose(50);
            int[] expectedArray = { 1, 3, 5, 8, 49 };

            CollectionAssert.AreEqual(expectedArray, testArray);
        }

        [TestMethod]
        public void Dispose_PassedInIntege4_ExpectAssertToNull()
        {
            int[] testArray = Exercise.Decompose(4);
            Assert.IsNull(testArray);
        }

        [TestMethod]
        public void Dispose_PassedInInteger9_ExpectAssertToEqual()
        {
            int[] testArray = Exercise.Decompose(9);
            int[] expectedArray = { 1, 4, 8 };

            CollectionAssert.AreEqual(expectedArray, testArray);
        }
    }
}