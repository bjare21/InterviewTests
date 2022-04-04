using Listy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTests.Tests
{
    [TestClass]
    public class SortListTests
    {
        [TestMethod]
        public void BubbleSortTable()
        {
            //Arrange
            int[] table = new int[10]
            {
                21,34,2,8,14,32,31,1,27,19
            };

            //Act
            SortList.BubbleSort(table, 10);

            //Assert
            Assert.AreEqual(table[0], 1);
            Assert.AreEqual(table[9], 34);
        }
    }
}
