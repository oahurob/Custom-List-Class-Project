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
        public void Test_AddTo_Index0()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(4);

            //Assert
            Assert.AreEqual(4, list[0]);

        }

        //Test for Adding value to index 3
        [TestMethod]
        
        // index out of bounds
        public void Test_AddValue_atIndex3()
        {
            //Arrange
            List<int> list = new List<int>();
    

            //Act
            list.Add(5);
            list.Add(3);
            list.Add(7);
            list.Add(1);

            //Assert
            Assert.AreEqual(1, list[3]);

        }

        //Test for Adding value pass capacity to extend array
        [TestMethod]
        public void Test_AddValue_ToExtendArray()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(4);
            list.Add(8);
            list.Add(4);
            list.Add(3);
            list.Add(5);
            list.Add(2);
            list.Add(7);

            //Assert
            Assert.AreEqual(2, list[5]);

        }

        //Test for Adding value to each index
        [TestMethod]
        public void Test_AddValue_ToEachIndex()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(2);
            list.Add(5);
            list.Add(1);
            list.Add(6);
            list.Add(3);
            list.Add(3);

            //Assert
            Assert.AreEqual(6, list.Count);

        }

        // REMOVING TEST

        //Test for Removing value at index 0
        [TestMethod]
        public void Test_RemoveValue_atIndex0()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(2);
            list.Add(3);
            list.Add(7);
            list.Remove(2);

            //Assert
            Assert.AreEqual(3, list[0]);

        }

        //Test for Removing value at index 1
        [TestMethod]
        public void Test_RemoveValue_atIndex1()
        {
            //Arrange
            List<int> list = new List<int>();
            //Act
            list.Add(2);
            list.Add(7);
            list.Add(3);
            list.Add(7);
            list.Add(4);
            list.Remove(7);

            //Assert
            Assert.AreEqual(3, list[1]);

        }

        //Test for Removing value at index 0 of a filled Array with a Capacity of 4
        [TestMethod]
        public void Test_RemoveValue_atIndex0_withCapOf4()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(12);
            list.Remove(12);

            //Assert
            Assert.AreEqual(0, list.Count);

        }

        //Test for Removing value at index 3 of a filled Array and check Array
        [TestMethod]
        public void Test_RemoveValue_atIndex3_OfFilledArray()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(34);
            list.Remove(20);

            //Assert
            Assert.AreEqual(34, list[0]);

        }

        // COPY TEST

        //Test for capacity doubling from 4 to 8
        [TestMethod]
        public void Test_Capacity_4to8()
        {
            //Arrange
            List<int> list = new List<int>();
            int testNum = 8;

            //Act
            int[] arrayLength = list.CopyList();
            int length = arrayLength.Length;

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

            //Act
            list.Add(2);
            list.Add(7);
            list.Add(3);
            list.Add(7);
            list.Add(4);
            list.Add(2);
            list.Add(7);
            list.Add(3);
            list.Add(7);

            //Assert
            Assert.AreEqual(testNum, list.capacity);
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

            //Act
            list.Add(1);

            //Assert
            Assert.AreEqual(1, list[0]);
        }

        //Test for checking if index 3 was successfully changed to a string
        [TestMethod]
        public void Test_index3_ToString()
        {
            //Arrange
            List<int> list = new List<int>();

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(4);

            //Assert
            Assert.AreEqual(4, list[3]);
        }

        //OPERATOR + TEST

        //Test for checking combined list one 0 equals 1 or two 0
        [TestMethod]
        public void Test_Combined0_equals_1()
        {
            //Arrange
            List<int> one = new List<int>();
            List<int> two = new List<int>();

            //Act
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(1);
            two.Add(2);
            one = one + two;

            //Assert
            Assert.AreEqual(2, one[4]);
        }

        //Test checking combined list 4 equals 8 
        [TestMethod]
        public void Test_Combined_equals_8()
        {
            //Arrange
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            one.Add(4);
            one.Add(5);
            one.Add(6);
            two.Add(7);
            two.Add(8);


            //Act
            one = one + two;

            //Assert
            Assert.AreEqual(8, one[4]);
        }

        //Test checking combined list 0 "blue" equals "blue"
        [TestMethod]
        public void Test_Combined0_equals_one0()
        {
            //Arrange
            List<string> one = new List<string>();
            List<string> two = new List<string>();
            one.Add("blue");
            one.Add("red");
            one.Add("yellow");
            two.Add("black");
            two.Add("purple");


            //Act
            one = one + two;

            //Assert
            Assert.AreEqual("blue", one[0]);
        }

        //Test checking combined list 0 equals two1
        [TestMethod]
        public void Test_Combined4_equals_two1()
        {
            //Arrange
            List<string> one = new List<string>();
            List<string> two = new List<string>();
            one.Add("blue");
            one.Add("red");
            one.Add("yellow");
            two.Add("black");
            two.Add("purple");


            //Act
            one = one + two;

            //Assert
            Assert.AreEqual("purple", one[4]);
        }

        //OPERATOR - TEST

        //Test checking if list one - list two
        [TestMethod]
        public void Test_listOne_minus_listTwo()
        {
            //Arrange
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            one.Add(1);//-
            one.Add(2);//-
            one.Add(3);
            two.Add(1);//-
            two.Add(2);//-
            two.Add(8);


            //Act
            one = one - two;

            //Assert
            Assert.AreEqual(3, one[0]);
        }

        //ZIP TEST

        //Test checking zip list at last index
        [TestMethod]
        public void Test_Zip_LastIndex()
        {
            //Arrange
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(1);
            two.Add(2);
            two.Add(8);


            //Act
            List<T>.Zip(one, two);

            //Assert
            Assert.AreEqual(3, one[0]);
        }
    }
}
