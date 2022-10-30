using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5800580f8f7ddaea13000025/train/csharp"/>
    [TestClass]
    public class SumTheTree
    {
        public class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int value, Node left = null, Node right = null)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(13, SumTree(new Node(10, new Node(1), new Node(2))));
            Assert.AreEqual(12, SumTree(new Node(11, new Node(0), new Node(0, null, new Node(1)))));

        }

        public static int SumTree(Node root)
        {
            return root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
        }
    }
}
