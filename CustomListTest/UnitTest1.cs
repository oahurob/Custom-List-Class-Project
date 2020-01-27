using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {

        // ADDING TEST

        //Test for adding value to index 0
        [TestMethod]
        public void Test_Add_To_Index0()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.Add(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        //Test for Adding value to index 3
        [TestMethod]
        public void Test_AddValue_atIndex3()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.Add(testNum);

            //Assert
            Assert.AreEqual(testNum, list[3]);

        }

        //Test for Adding value to index 0 and then index 1
        [TestMethod]
        public void Test_AddValue_atIndex0_andIndex1()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.Add(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        //Test for Adding value to each index
        [TestMethod]
        public void Test_AddValue_ToEachIndex()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 4;

            //Act
            list.Add(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        // REMOVING TEST

        //Test for Removing value at index 0
        [TestMethod]
        public void Test_RemoveValue_atIndex0()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 0;

            //Act
            list.Remove(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        //Test for Removing value at index 3
        [TestMethod]
        public void Test_RemoveValue_atIndex4()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 0;

            //Act
            list.Remove(testNum);

            //Assert
            Assert.AreEqual(testNum, list[3]);

        }

        //Test for Removing value at index 0 of a filled Array with a Capacity of 4
        [TestMethod]
        public void Test_RemoveValue_atIndex0_withCapOf4()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 0;

            //Act
            list.Remove(testNum);

            //Assert
            Assert.AreEqual(testNum, list[0]);

        }

        //Test for Removing value at index 3 of a filled Array and check Array
        [TestMethod]
        public void Test_RemoveValue_atIndex3_OfFilledArray()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 0;

            //Act
            list.Remove(testNum);

            //Assert
            Assert.AreEqual(testNum, list[3]);

        }

        //  COPYING TEST

        //Test for copying Array into temp Array
        [TestMethod]
        public void Test_Copying_Array()
        {
            //Arrange
            List<int> list = new List<int>();
            list.Copy;

            //Act
            list.list;

            //Assert
            Assert.AreEqual(list.Copy, list.list);

        }

        //Test to make sure index 0-3 of Original Array equal 0-3 of new Array
        [TestMethod]
        public void Test_OriginalArray_Equals_Index0Through3_OfNewArray()
        {
            //Arrange
            List<int> list = new List<int>();
            list.Copy;

            //Act
            list.list;

            //Assert
            Assert.AreEqual(list.Copy, list.list);

        }
    }
}
