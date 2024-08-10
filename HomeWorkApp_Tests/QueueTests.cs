using HomeWorkApp.Source.Collections;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestEnqueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Item1");
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual("Item1", queue.Peek());
        }

        [TestMethod]
        public void TestDequeue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Item1");
            queue.Enqueue("Item2");
            var item = queue.Dequeue();
            Assert.AreEqual("Item1", item);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual("Item2", queue.Peek());
        }

        [TestMethod]
        public void TestDequeueEmptyQueue()
        {
            var queue = new Queue<string>();
            var item = queue.Dequeue();
            Assert.IsNull(item);
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void TestPeek()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Item1");
            queue.Enqueue("Item2");
            var item = queue.Peek();
            Assert.AreEqual("Item1", item);
            Assert.AreEqual(2, queue.Count);
        }

        [TestMethod]
        public void TestPeekEmptyQueue()
        {
            var queue = new Queue<string>();
            var item = queue.Peek();
            Assert.IsNull(item);
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void TestEmpty()
        {
            var queue = new Queue<string>();
            Assert.IsTrue(queue.Empty);
            queue.Enqueue("Item1");
            Assert.IsFalse(queue.Empty);
        }

        [TestMethod]
        public void TestCount()
        {
            var queue = new Queue<string>();
            Assert.AreEqual(0, queue.Count);
            queue.Enqueue("Item1");
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue("Item2");
            Assert.AreEqual(2, queue.Count);
            queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
        }
    }
}