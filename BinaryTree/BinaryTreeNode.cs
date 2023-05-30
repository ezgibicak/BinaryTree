using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> ParentNode { get; set; }
        public BinaryTreeNode<T> LeftNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }

        public BinaryTreeNode(T RealValue)
        {
            Value = RealValue;
        }

        public BinaryTreeNode(T RealValue, BinaryTreeNode<T> Parent)
        {
            Value = RealValue;
            ParentNode = Parent;
        }

        public BinaryTreeNode(T RealValue, BinaryTreeNode<T> Parent, BinaryTreeNode<T> Left, BinaryTreeNode<T> Right)
        {
            Value = RealValue;
            RightNode = Right;
            LeftNode = Left;
            ParentNode = Parent;
        }
    }
}
