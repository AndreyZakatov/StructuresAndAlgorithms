using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsDataStructures;
using NUnit.Framework;

namespace StructuresAndAlgorythmsTest
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedList _list;

        [SetUp]
        public void SetUp()
        {
            _list  = new LinkedList();
            foreach (int i in Enumerable.Range(1, 1000))
            {
                _list.AddInTail(new Node(i));
            }


            //Adding duplicate values
            _list.InsertAfter(_list.Find(3), new Node(3));
            _list.InsertAfter(_list.Find(3), new Node(3));
            _list.InsertAfter(_list.Find(3), new Node(3));
            
            _list.InsertAfter(_list.Find(50), new Node(50));
            _list.InsertAfter(_list.Find(50), new Node(50));
            _list.InsertAfter(_list.Find(50), new Node(50));
        }

        [Test]
        public void Remove_Duplicate_ReturnTrue()
        {
            _list.Remove(3);
            Assert.IsTrue(_list.Find(3) != null);
        }
        [Test]
        public void Remove_NoDuplicate_ReturnFalse()
        {
            _list.Remove(2);
            Assert.IsFalse(_list.Find(2) != null);
        }
        [Test]
        public void RemoveAll_Duplicate_ReturnTrue()
        {
            _list.RemoveAll(3);
            Assert.IsTrue(_list.Find(3) == null);
        }
        
        [Test]
        public void RemoveAll_NoDuplicate_ReturnTrue()
        {
            _list.RemoveAll(2);
            Assert.IsTrue(_list.Find(2) == null);
        }
        
        
        [Test]
        public void FindAll_Duplicate_ReturnTrue()
        {
            List<Node> searchResult = _list.FindAll(3);
            Assert.IsTrue(searchResult.Count == 4);
        }
        
        [Test]
        public void FindAll_Duplicate2_ReturnTrue()
        {
            List<Node> searchResult = _list.FindAll(50);
            Assert.IsTrue(searchResult.Count == 4);
        }
        
        [Test]
        public void FindAll_NoDuplicate_ReturnTrue()
        {
            List<Node> searchResult = _list.FindAll(2);
            Assert.IsTrue(searchResult.Count == 1);
        }
        
        
        [Test]
        public void Clear_NoDuplicate_ReturnTrue()
        {
           _list.Clear();
            Assert.IsTrue(_list.head == null);
        }
        
        [Test]
        public void Count_ReturnTrue()
        {
            int count = _list.Count();
            Assert.IsTrue(count == 1006);
        }
        
        [Test]
        public void Count_OneNode_ReturnTrue()
        {
            LinkedList newList = new LinkedList();
            newList.AddInTail(new Node(1));

            Assert.IsTrue(newList.Count() == 1);
        }
        
        [Test]
        public void InsertAfter_Three_ReturnTrue()
        {
            Node node = _list.Find(6);
            Node nodeToPaste = new Node(6);
            _list.InsertAfter(node, nodeToPaste);
            
            Assert.IsTrue(node.next == nodeToPaste);
        }
        
        
        [Test]
        [Theory]
        public void InsertAfter_FindTest_ReturnTrue()
        {
            Node node = _list.Find(6);
            Node nodeToPaste = new Node(6);
            _list.InsertAfter(node, nodeToPaste);
            
            Node testNode = _list.Find(6);
            Assert.IsTrue(testNode.next == nodeToPaste);
        }
        
        
    }


}