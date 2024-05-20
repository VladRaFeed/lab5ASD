using System;

namespace lab5asd
{
    public class TreeNode
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

        public void Insert(int  value)
        {
            if(value >= key)
            {
                if (right == null)
                {
                    right = new TreeNode(key);
                }
                else
                {
                    right.Insert(value);
                }
            } else
            {
                if(left == null)
                {
                    left = new TreeNode(key);
                } else
                {
                    left.Insert(value);
                }
            }
        }
    }

    public class BinaryTree
    {
        public TreeNode root;

        public void Insert(int data)
        {
            if (root != null) 
            {
                root.Insert(data);
            } else
            {
                root = new TreeNode(data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
        }
    }
}