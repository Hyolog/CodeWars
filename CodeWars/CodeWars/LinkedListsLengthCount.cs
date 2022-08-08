using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55beec7dd347078289000021/train/csharp"/>
    [TestClass]
    public class LinkedListsLengthCount
    {
        [TestMethod]
        public void Test()
        {
            Node list = Node.BuildOneTwoThree();
            Assert.AreEqual(0, Node.Length(null), "Length of null list should be zero.");
            Assert.AreEqual(1, Node.Length(new Node(99)), "Length of single node list should be one.");
            Assert.AreEqual(3, Node.Length(list), "Length of the three node list should be three.");

            Node list2 = Node.BuildOneTwoThree();
            //Assert.AreEqual(1, Node.Count(list2, value => value == 1), "list should only contain one 1.");
            //Assert.AreEqual(1, Node.Count(list2, value => value == 2), "list should only contain one 2.");
            Assert.AreEqual(1, Node.Count(list2, value => value == 3), "list should only contain one 3.");
            Assert.AreEqual(0, Node.Count(list2, value => value == 99), "list should return zero for integer not found in list.");
            Assert.AreEqual(0, Node.Count(null, value => value == 1), "null list should always return count of zero.");

            Assert.AreEqual(2, Node.Count(list2, value => value % 2 != 0), "list should contain two odd numbers.");
            Assert.AreEqual(1, Node.Count(list2, value => value % 2 == 0), "list should contain one even number.");
        }
    }

    public partial class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(Node head)
        {
            if (head == null)
                return 0;

            var result = 1;
            var node = head;
            
            while (node?.Next != null)
            {
                result++;
                node = node.Next;
            }

            return result;
        }

        public static int Count(Node head, Predicate<int> func)
        {
            var result = 0;
            var node = head;

            while (node != null)
            {
                if (func(node.Data))
                    result++;

                node = node.Next;
            }

            return result;
        }

        public static Node BuildOneTwoThree()
        {
            var one = new Node(1);
            var two = new Node(2);
            var three = new Node(3);

            one.Next = two;
            two.Next = three;

            return one;
        }
    }
}
