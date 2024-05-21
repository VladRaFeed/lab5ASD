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

        public void TreeWalk(TreeNode key)
        {
            if(key.left != null)
            {
                TreeWalk(key.left);
            }

            Console.WriteLine(key.key + " ");

            if(key.right != null)
            {
                TreeWalk(key.right);
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

        public void InorderTreeWalk()
        {
            if(root != null)
            {
                InorderTreeWalk(root);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinaryTree newTree = new BinaryTree();  

            newTree.Insert(5);
            newTree.Insert(3);
            newTree.Insert(10);
            newTree.Insert(1);
            newTree.Insert(15);
            newTree.Insert(7);
            newTree.Insert(2);

            Console.WriteLine("Tree Walk");
            newTree.InorderTreeWalk();  
        }
    }
}