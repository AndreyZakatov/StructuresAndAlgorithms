using System;
using System.Linq;
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
        public void Remove_NoDuplicate_ReturnTrue()
        {
            _list.Remove(3);
            Assert.IsTrue(_list.Find(3) != null);
        }
        
    }


}