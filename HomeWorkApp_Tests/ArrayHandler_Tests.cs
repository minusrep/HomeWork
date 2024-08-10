using HomeWorkApp;
using HomeWorkApp.Source;
using System.Diagnostics;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class ArrayHandler_Tests
    {
        private ArrayHandler _arrayHandler;

        public ArrayHandler_Tests()
        {
            _arrayHandler = new ArrayHandler();
        }

        [TestMethod]
        public void Inverse_ValidInput_ReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, _arrayHandler.Inverse(new int[] { 1, 2, 3}));
        }

        [TestMethod]
        public void Rotate_ValidInput_ReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 3, 1, 2 }, _arrayHandler.Rotate(new int[] { 1, 2, 3 }, 1));
            
            CollectionAssert.AreEqual(new int[] { 2, 3, 1 }, _arrayHandler.Rotate(new int[] { 1, 2, 3 }, 2));
        }

        [TestMethod]
        public void SortByEven_ValidInput_ReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 3, 2 }, _arrayHandler.SortByEven(new List<int>() { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void Add_ValidInput_ReturnsCorrect()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 4 }, _arrayHandler.Add(new int[] { 1, 2, 3 }));

            CollectionAssert.AreEqual(new int[] { 1, 0 }, _arrayHandler.Add(new int[] { 9 }));

        }
    }
}