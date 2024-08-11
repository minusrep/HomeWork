using HomeWorkApp;
using HomeWorkApp.Source;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class MathFunctionTests
    {
        private MathFunction _mathFunction;

        [TestInitialize]
        public void Setup()
        {
            _mathFunction = new MathFunction();
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = { 5, 3, 8, 4, 2 };
            _mathFunction.BubbleSort(array, (a, b) => a > b);
            CollectionAssert.AreEqual(new[] { 2, 3, 4, 5, 8 }, array);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] array = { 5, 3, 8, 4, 2 };
            int comparisonCount, swapCount;
            var sortedArray = _mathFunction.SelectionSort(array, out comparisonCount, out swapCount);
            CollectionAssert.AreEqual(new[] { 2, 3, 4, 5, 8 }, sortedArray);
            Assert.AreEqual(10, comparisonCount);
            Assert.AreEqual(3, swapCount);
        }

        [TestMethod]
        public void TestRecursiveSum()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            var sum = _mathFunction.RecursiveSum(array);
            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void TestRecursiveEvenSum()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            var sum = _mathFunction.RecursiveEvenSum(array);
            Assert.AreEqual(12, sum);
        }

        [TestMethod]
        public void TestRecursiveMax()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            var max = _mathFunction.RecursiveMax(array);
            Assert.AreEqual(6, max);
        }

        [TestMethod]
        public void TestReverse()
        {
            var value = "hello";
            var reversed = _mathFunction.Reverse(value);
            Assert.AreEqual("olleh", reversed);
        }

        [TestMethod]
        public void TestIsPallidrome()
        {
            var value1 = "racecar";
            var value2 = "hello";
            Assert.IsTrue(_mathFunction.IsPallidrome(value1));
            Assert.IsFalse(_mathFunction.IsPallidrome(value2));
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var n = 10;
            var fib = _mathFunction.Fibonacci(n);
            Assert.AreEqual(55, fib);
        }

        [TestMethod]
        public void TestDigitsSum()
        {
            var n = 12345;
            var sum = _mathFunction.DigitsSum(n);
            Assert.AreEqual(15, sum);
        }
    }
}