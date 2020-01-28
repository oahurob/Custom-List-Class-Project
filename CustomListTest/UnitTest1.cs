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

        // COPY TEST

        //Test for capacity doubling from 4 to 8
        [TestMethod]
        public void Test_Capacity_4to8()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 8;
            int[] arrayLength = list.CopyList();
            int length = arrayLength.Length;

            //Act
            list.CopyList();

            //Assert
            Assert.AreEqual(testNum, length);
        }

        //Test checking length from 8 to 16
        [TestMethod]
        public void Test_Original8_equal_tempList16()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 16;
            int[] arrayLength = list.CopyList();
            int length = arrayLength.Length;

            //Act
            list.CopyList();

            //Assert
            Assert.AreEqual(testNum, length);
        } 

        //Test checking list 0 equals tempList 0
        [TestMethod]
        public void Test_list0_equal_tempList0()
        {
            //Arrange
            List<int> list = new List<int>();
            int original = list.list[0];
            int[] arrayTemp = list.CopyList();
            int tempList0 = arrayTemp[0];

            //Act
            list.CopyList();

            //Assert
            Assert.AreEqual(original, tempList0);
        }

        //Test checking original 3 equals tempList 3
        [TestMethod]
        public void Test_Original3_equals_tempList3()
        {
            //Arrange
            List<int> list = new List<int>();
            int original = list.list[3];
            int[] arrayTemp = list.CopyList();
            int tempList3 = arrayTemp[3];
            
            //Act
            list.CopyList();

            //Assert
            Assert.AreEqual(original, tempList3);
        }

        // TO STRING TEST  

        //Test for checking if index 0 was successfully changed to a string
        [TestMethod]
        public void Test_index0_ToString()
        {
            //Arrange
            List<int> list = new List<int>();
            string testString = "1";

            //Act
            list.ToString();

            //Assert
            Assert.AreEqual(testString, list[0]);
        }

        //Test for checking if index 3 was successfully changed to a string
        [TestMethod]
        public void Test_index3_ToString()
        {
            //Arrange
            List<int> list = new List<int>();
            string testString = "1";

            //Act
            list.ToString();

            //Assert
            Assert.AreEqual(testString, list[3]);
        }

        //OPERATOR + TEST

        //Test for
    }
}
