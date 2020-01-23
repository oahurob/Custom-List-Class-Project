using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.ListAdd(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }
    }
}
