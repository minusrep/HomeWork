using HomeWorkApp.Source.Collections;
using System.Collections.Generic;
using System;

namespace HomeWorkApp_Tests
{
    [TestClass]
    public class DListTests
    {
        [TestMethod]
        public void TestAdd()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Add(2);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list.Get(0));
            Assert.AreEqual(2, list.Get(1));
        }

        [TestMethod]
        public void TestAddFront()
        {
            DList<int> list = new DList<int>(5);
            list.AddFront(1);
            list.AddFront(2);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(2, list.Get(0));
            Assert.AreEqual(1, list.Get(1));
        }

        [TestMethod]
        public void TestInsert()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Insert(1, 3);
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual(1, list.Get(0));
            Assert.AreEqual(3, list.Get(1));
            Assert.AreEqual(2, list.Get(2));
        }
        [TestMethod]
        public void TestRemoveByIndex()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(1);

            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list.Get(0));
            Assert.AreEqual(3, list.Get(1));
        }

        [TestMethod]
        public void TestRemoveByValue()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(2);

            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list.Get(0));
        }

        [TestMethod]
        public void TestFind()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int index = list.Find(2);
            Assert.AreEqual(1, index);
            index = list.Find(4);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestEmpty()
        {
            DList<int> list = new DList<int>(5);
            Assert.IsTrue(list.Empty);
            list.Add(1);
            Assert.IsFalse(list.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestGetOutOfRange()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            var value = list.Get(1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestInsertOutOfRange()
        {
            DList<int> list = new DList<int>(5);
            list.Insert(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestRemoveIndexOutOfRange()
        {
            DList<int> list = new DList<int>(5);
            list.Add(1);
            list.Remove(1);
        }
    }
}