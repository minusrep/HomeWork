using HomeWorkApp.Source.Collections;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestPush()
        {
            var stack = new Stack<string>();
            stack.Push("Item1");
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual("Item1", stack.Peek());
        }

        [TestMethod]
        public void TestPop()
        {
            var stack = new Stack<string>();
            stack.Push("Item1");
            stack.Push("Item2");
            var item = stack.Pop();
            Assert.AreEqual("Item2", item);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual("Item1", stack.Peek());
        }

        [TestMethod]
        public void TestPopEmptyStack()
        {
            var stack = new Stack<string>();
            var item = stack.Pop();
            Assert.IsNull(item);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestPeek()
        {
            var stack = new Stack<string>();
            stack.Push("Item1");
            stack.Push("Item2");
            var item = stack.Peek();
            Assert.AreEqual("Item2", item);
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void TestPeekEmptyStack()
        {
            var stack = new Stack<string>();
            var item = stack.Peek();
            Assert.IsNull(item);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestEmpty()
        {
            var stack = new Stack<string>();
            Assert.IsTrue(stack.Empty);
            stack.Push("Item1");
            Assert.IsFalse(stack.Empty);
        }

        [TestMethod]
        public void TestCount()
        {
            var stack = new Stack<string>();
            Assert.AreEqual(0, stack.Count);
            stack.Push("Item1");
            Assert.AreEqual(1, stack.Count);
            stack.Push("Item2");
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
        }
    }
}