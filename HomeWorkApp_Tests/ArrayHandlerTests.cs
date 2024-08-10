using HomeWorkApp;
using HomeWorkApp.Source;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class ArrayHandlerTests
    {
        private ArrayHandler _arrayHandler;

        public ArrayHandlerTests()
        {
            _arrayHandler = new ArrayHandler();
        }

        [TestMethod]
        public void InverseValidInputReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, _arrayHandler.Inverse(new int[] { 1, 2, 3}));
        }

        [TestMethod]
        public void RotateValidInputReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 3, 1, 2 }, _arrayHandler.Rotate(new int[] { 1, 2, 3 }, 1));
            
            CollectionAssert.AreEqual(new int[] { 2, 3, 1 }, _arrayHandler.Rotate(new int[] { 1, 2, 3 }, 2));
        }

        [TestMethod]
        public void SortByEvenValidInputReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 3, 2 }, _arrayHandler.SortByEven(new List<int>() { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void AddValidInputReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 4 }, _arrayHandler.Add(new int[] { 1, 2, 3 }));

            CollectionAssert.AreEqual(new int[] { 1, 0 }, _arrayHandler.Add(new int[] { 9 }));

        }
    }
}