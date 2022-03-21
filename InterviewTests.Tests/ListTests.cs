using Microsoft.VisualStudio.TestTools.UnitTesting;

using Listy;
using System;

namespace InterviewTests.Tests
{
    [TestClass]
    public class ListTests  
    {
        [TestMethod]
        public void BackValueFromPopulatedList()
        {
            //Arrange
            List list = new List();
            list.PushFront(12);
            list.PushFront(3);
            list.PushFront(7);
            int i;

            //Act
            i = list.Back();

            //Assert
            Assert.AreEqual(i, 12);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BackValueFromEmptyList()
        {

            //Arrange
            List list = new List();
            int i;

            //Act
            i = list.Back();

            //Assert

        }
        [TestMethod]
        public void FrontValueFromPopulatedList()
        {
            //Arrange
            List list = new List();
            list.PushFront(21);
            int i;

            //Act
            i = list.Front();

            //Assert
            Assert.AreEqual(i, 21);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FrontValueFromEmptyList()
        {
            //Arrange
            List list = new List();
            int i;

            //Act
            i = list.Front();
        }

        [TestMethod]
        public void ListIsNotEmpty()
        {
            //Arrange
            List list = new List();
            bool isEmpty;
            list.PushFront(21);

            //Act
            isEmpty = list.IsEmpty();

            //Assert
            Assert.IsFalse(isEmpty);
        }

        [TestMethod]
        public void ListIsEmpty()
        {
            //Arrange
            List list = new List();
            bool isEmpty;

            //Act
            isEmpty = list.IsEmpty();

            //Assert
            Assert.IsTrue(isEmpty);
        }


    }
}
