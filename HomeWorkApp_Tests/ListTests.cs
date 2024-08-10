using HomeWorkApp.Source.Collections;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var list = new List<string>();

            list.Add("Item1");

            Assert.AreEqual(1, list.Count);

            Assert.AreEqual("Item1", list.Get(0));
        }

        [TestMethod]
        public void TestAddFront()
        {
            var list = new List<string>();

            list.AddFront("Item1");

            Assert.AreEqual(1, list.Count);

            Assert.AreEqual("Item1", list.Get(0));

            list.AddFront("Item2");

            Assert.AreEqual(2, list.Count);

            Assert.AreEqual("Item2", list.Get(0));

            Assert.AreEqual("Item1", list.Get(1));
        }

        [TestMethod]
        public void TestGet()
        {
            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            Assert.AreEqual("Item1", list.Get(0));
            Assert.AreEqual("Item2", list.Get(1));
            Assert.IsNull(list.Get(2));
        }

        [TestMethod]
        public void TestInsert()
        {
            var list = new List<string>();
            list.Add("Item1");

            list.Add("Item2");

            list.Insert(1, "Item1.5");

            Assert.AreEqual(3, list.Count);

            Assert.AreEqual("Item1", list.Get(0));

            Assert.AreEqual("Item1.5", list.Get(1));

            Assert.AreEqual("Item2", list.Get(2));
        }

        [TestMethod]
        public void TestRemove()
        {
            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            var removed = list.Remove();
            Assert.AreEqual("Item1", removed);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Item2", list.Get(0));
        }

        [TestMethod]
        public void TestRemoveValue()
        {
            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            var removed = list.Remove("Item1");
            Assert.AreEqual("Item1", removed);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Item2", list.Get(0));
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            var removed = list.RemoveLast();
            Assert.AreEqual("Item2", removed);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("Item1", list.Get(0));
        }

        [TestMethod]
        public void TestClear()
        {
            var list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            list.Clear();
            Assert.AreEqual(0, list.Count);
            Assert.IsTrue(list.Empty);
        }
    }
}