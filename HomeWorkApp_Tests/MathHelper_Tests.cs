using HomeWorkApp;
using HomeWorkApp.Source;
using System.Diagnostics;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class MathHelper_Tests
    {
        private MathHelper _mathHelper;

        public MathHelper_Tests() 
        { 
            _mathHelper = new MathHelper();
        }

        [TestMethod]
        public void Factorial_ValidInput_ReturnsCorrrectResult()
        {
            Assert.AreEqual(1, _mathHelper.Factorial(0));

            Assert.AreEqual(1, _mathHelper.Factorial(1));

            Assert.AreEqual(2, _mathHelper.Factorial(2));

            Assert.AreEqual(6, _mathHelper.Factorial(3));

            Assert.AreEqual(720, _mathHelper.Factorial(6));
        }

        [TestMethod]
        public void Factorial_InvalidInput_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, _mathHelper.Factorial(-500));

            Assert.AreEqual(-1, _mathHelper.Factorial(21));

            Assert.AreEqual(-1, _mathHelper.Factorial(-2));
        }

        [TestMethod]
        public void Fibonacci_ValidInput_ReturnsCorrectResult()
        {
            CollectionAssert.AreEqual(new int[] { }, _mathHelper.Fibonacci(0));

            CollectionAssert.AreEqual(new int[] { 1 }, _mathHelper.Fibonacci(1));

            CollectionAssert.AreEqual(new int[] { 1, 1}, _mathHelper.Fibonacci(2));

            CollectionAssert.AreEqual(new int[] { 1, 1, 2, 3 }, _mathHelper.Fibonacci(4));

            CollectionAssert.AreEqual(new int[] { 1, 1, 2, 3, 5, 8, 13, 21 }, _mathHelper.Fibonacci(8));
        }

        [TestMethod]
        public void Fibonacci_InvalidInput_ReturnsEmpty()
        {
            CollectionAssert.AreEqual(new int[] { }, _mathHelper.Fibonacci(-10));

            CollectionAssert.AreEqual(new int[] { }, _mathHelper.Fibonacci(-1));
        }

        [TestMethod]
        public void BinaryCountOnes_ValidInput_CorrectResult()
        {
            Assert.AreEqual(3, _mathHelper.BinaryCountOnes(7));

            Assert.AreEqual(1, _mathHelper.BinaryCountOnes(1));

            Assert.AreEqual(0, _mathHelper.BinaryCountOnes(0));

            Assert.AreEqual(3, _mathHelper.BinaryCountOnes(11));

            Assert.AreEqual(4, _mathHelper.BinaryCountOnes(15));
        }

        [TestMethod]
        public void BinaryCountOnes_InvalidInput_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, _mathHelper.BinaryCountOnes(-10));

            Assert.AreEqual(-1, _mathHelper.BinaryCountOnes(-1));

            Assert.AreEqual(-1, _mathHelper.BinaryCountOnes(-154345));
        }

        [TestMethod] 
        public void IsPallidromeValidInputReturnsTrue()
        {
            Assert.AreEqual(true, _mathHelper.IsPallidrome(121));

            Assert.AreEqual(true, _mathHelper.IsPallidrome(111));

            Assert.AreEqual(true, _mathHelper.IsPallidrome(101));

            Assert.AreEqual(true, _mathHelper.IsPallidrome(11));

            Assert.AreEqual(true, _mathHelper.IsPallidrome(1));
        }

        [TestMethod]
        public void IsPallidromeValidInputReturnsFalse()
        {
            Assert.AreEqual(false, _mathHelper.IsPallidrome(122));

            Assert.AreEqual(false, _mathHelper.IsPallidrome(-1));

            Assert.AreEqual(false, _mathHelper.IsPallidrome(-121));

            Assert.AreEqual(false, _mathHelper.IsPallidrome(997));

            Assert.AreEqual(false, _mathHelper.IsPallidrome(28));
        }
    }
}