using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesManager.Controllers.DataStructure;

namespace SalesManagerTest.Controller.DataStructure
{
    [TestClass]
    public class QueueTest
    {
        private Queue<int> AuxQueue;

        [TestMethod]
        public void TestEmptyQueue()
        {
            AuxQueue = new Queue<int>();
            Assert.AreEqual(AuxQueue.Size(), 0);
            Assert.IsTrue(AuxQueue.IsEmpty());
        }

        [TestMethod]
        public void TestAdd()
        {
            AuxQueue = new Queue<int>();
            int value = 2;

            AuxQueue.Add(value);
            Assert.AreEqual(value, AuxQueue.Find(value));
        }

        [TestMethod]
        public void TestRemove()
        {
            AuxQueue = new Queue<int>();
            int value = 2;

            AuxQueue.Add(value);
            Assert.AreEqual(value, AuxQueue.Remove(value));
        }

        [TestMethod]
        public void TestRemoveNonExistentValue()
        {
            AuxQueue = new Queue<int>();
            int value = 2;

            Assert.IsNull(AuxQueue.Remove(value));
        }

        [TestMethod]
        public void TestFind()
        {
            AuxQueue = new Queue<int>();
            int value = 2;

            AuxQueue.Add(value);
            Assert.AreEqual(value, AuxQueue.Find(value));
        }

        [TestMethod]
        public void TestFindNonExistentValue()
        {
            AuxQueue = new Queue<int>();
            int value = 2;

            Assert.IsNull(AuxQueue.Find(value));
        }

    }
}
