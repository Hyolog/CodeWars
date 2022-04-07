using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5550d638a99ddb113e0000a2/train/csharp"/>
    [TestClass]
    public class JosephusPermutation
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { 1, 2, 3, 4, 5}, 1), new object[] { 1, 2, 3, 4, 5});
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1), new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2), new object[] { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 });
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" }, 4), new object[] { "e", "s", "W", "o", "C", "d", "r", "a" });
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { 1, 2, 3, 4, 5, 6, 7 }, 3), new object[] { 3, 6, 2, 7, 5, 1, 4 });
            CollectionAssert.AreEqual(JosephusPermutationFunc(new List<object> { }, 3), new object[] { });
        }

        public class Node
        {
            public object Value;
            public Node Next;
            public Node Before;

            public Node(object value = null, Node next = null, Node before = null)
            {
                Value = value;
                Next = next;
                Before = before;
            }
        }

        public static List<object> JosephusPermutationFunc(List<object> items, int k)
        {
            if (items.Count == 0)
                return new List<object>();

            var tempNode = new Node(items[0]);
            var firstNode = tempNode;

            for (int i = 1; i < items.Count; i++)
            {
                var node = new Node(items[i]);

                tempNode.Next = node;
                node.Before = tempNode;
                tempNode = node;
            }

            // circular linkedList
            tempNode.Next = firstNode;
            firstNode.Before = tempNode;

            var result = new List<object>();

            while (result.Count != items.Count)
            {
                var currentNode = MoveStep(tempNode, k);
                result.Add(currentNode.Value);
                currentNode.Before.Next = currentNode.Next;
                currentNode.Next.Before = currentNode.Before;
                tempNode = currentNode.Before;
                currentNode = null;
            }

            return result;
        }

        public static Node MoveStep(Node node, int step)
        {
            for (int i = 0; i < step; i++)
                node = node.Next;

            return node;
        }
    }
}
