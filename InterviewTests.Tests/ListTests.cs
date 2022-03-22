using Microsoft.VisualStudio.TestTools.UnitTesting;

using Listy;
using System;

namespace InterviewTests.Tests
{
    [TestClass]
    public class ListTests  
    {
        [TestMethod]
        public void EraseElement()
        {
            //Arrange
            List list = new List();
            list.PushFront(1);
            list.PushFront(2);
            list.PushFront(3);
            Element lastElement = list.Last();

            //Act
            list.Erase(lastElement);

            //Assert
            Assert.AreEqual(list.Back(), 2);

        }

        [TestMethod]
        public void InsertElement()
        {
            //Arrange
            List list = new List();
            list.PushFront(1);
            Element oldElement = list.First();

            //Act
            list.Insert(oldElement, 21);

            //Assert
            Assert.AreEqual(list.Front(), 21);
            Assert.AreEqual(list.Back(), 1);
        }

        [TestMethod]
        public void PopBackPopulatedList()
        {
            //Arrange
            List list = new List();
            list.PushBack(11);
            list.PushFront(21);

            //Act
            list.PopBack();

            //Assert
            Assert.AreEqual(list.Back(), 21);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PopBackEmptyList()
        {
            //Arrange
            List list = new List();

            //Act
            list.PopBack();

        }

        [TestMethod]
        public void PopFrontPopulatedList()
        {
            //Arrange
            List list = new List();

            //Act
            list.PushFront(11);
            list.PushFront(21);
            list.PushFront(89);
            list.PushFront(26);
            list.PushFront(12);

            list.PopFront();
            list.PopFront();

            //Assert
            Assert.AreEqual(list.Front(), 89);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PopFrontEmptyList()
        {
            //Arrange
            List list = new List();

            //Act
            list.PopFront();
        }

        [TestMethod]
        public void PushBackValues()
        {
            //Arrange
            List list = new List();

            //Act
            list.PushBack(11);
            list.PushBack(24);
            list.PushBack(17);

            //Assert
            Assert.AreEqual(list.Back(), 17);
            Assert.AreEqual(list.Front(), 11);
        }

        [TestMethod]
        public void PushFrontValues()
        {
            //Arrange
            List list = new List();
            
            //Act
            list.PushFront(11);
            list.PushFront(21);
            list.PushFront(34);

            //Assert
            Assert.AreEqual(list.Front(), 34);
            Assert.AreEqual(list.Back(), 11);
        }

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
