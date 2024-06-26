﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5asd
{
    public class BinaryTree
    {
        public TreeNode root;

        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void InorderTreeWalk()
        {
            if (root != null)
            {
                root.TreeWalk(root);
            }
        }

        public void ReverseInorderTreeWalk()
        {
            if(root != null)
            {
                root.ReverseTreeWalk(root);
            }
        }

        public void NonRecursiveTreeWalk()
        {
            if (root != null)
            {
                root.NonRecursiveTreeWalk(root);
            }
        }

        public void TreeMin()
        {
            if(root != null)
            {
                root.FindTreeMin(root);
            }
        }

        public void TreeMax()
        {
            if(root != null)
            {
                root.FindTreeMax(root);
            }
        }

        public void TreePredecessor()
        {
            if(root != null)
            {
                root.TreePredecessor(root);
            }
        }
    }
}
