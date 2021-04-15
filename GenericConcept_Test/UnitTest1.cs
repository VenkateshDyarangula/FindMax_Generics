using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1_Generics_To_FindMaxValues;

namespace UC1_Generics_To_FindMaxValues_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_MaxIntegerNumber_1st_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(8, 5, 6);
            Assert.AreEqual(8, max);
        }
        [TestMethod]
        public void Given_MaxIntegerNumber_2nd_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(5, 8, 6);
            Assert.AreEqual(8, max);
        }

        [TestMethod]
        public void Given_MaxIntegerNumber_3rd_Position_ShouldReturnSame()
        {
            int max = GenericClass<int>.maximum(5, 6, 8);
            Assert.AreEqual(8, max);
        }
    }
}