using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        //Test for adding value to index 0
        [TestMethod]
        public void Test_Add_To_Index0()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.ListAdd(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        //Test for Adding value to index 3

        //Test for Adding value to index 1 and then index 2

        //Test for Adding value to each index

        //Test for Removing value at index 0

        //Test for Removing value at index 4

        //Test for Removing value at index 0 of a filled Array with a Capacity of 4

        //Test for Removing value at index 1 of a filled Array and check Array
    }
}
