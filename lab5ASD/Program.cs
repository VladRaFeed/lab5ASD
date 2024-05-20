using System;

namespace lab5asd
{
    class TreeNode
    {
        public int key;
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;

        public TreeNode()
        {
            key = 0;
            left = null;
            right = null;
            parent = null;
        }

        public TreeNode(int key)
        {
            this.key = key;
            left = null;
            right = null;
            parent = null;
        }
    }

    class Program
    {
        public void IndorderTreeWalk(int x)
        {
            if(x != null)
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test");
        }
    }
}