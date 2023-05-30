using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T>
         where T : IComparable<T>
    {
        public BinaryTreeNode<T> RootNode { get; set; }
        public int SCount { get; set; }
        public int MCount { get; set; }
        public int KCount { get; set; }
        public BinaryTree(BinaryTreeNode<T> Root)
        {
            RootNode = Root;
        }
        public void Add(T SourceItem)
        {
            if (RootNode == null)
            {
                RootNode = new BinaryTreeNode<T>(SourceItem);
            }
            else
            {
                Insert(SourceItem);
            }
        }
        public void Find(T SourceItem)
        {
            foreach (BinaryTreeNode<T> item in Traversal(RootNode))
            {
                if (item.Value.Equals(SourceItem) && SourceItem.ToString() == "S")
                {
                    SCount++;
                }
                else if (item.Value.Equals(SourceItem) && SourceItem.ToString() == "M")
                {
                    MCount++;
                }
                else if (item.Value.Equals(SourceItem) && SourceItem.ToString() == "K")
                {
                    KCount++;
                }

            }
        }
        IEnumerable<BinaryTreeNode<T>> Traversal(BinaryTreeNode<T> Node)
        {
            if (Node.LeftNode != null)
                foreach (BinaryTreeNode<T> leftNode in Traversal(Node.LeftNode))
                    yield return leftNode;

            yield return Node;

            if (Node.RightNode != null)
                foreach (BinaryTreeNode<T> rightNode in Traversal(Node.RightNode))
                    yield return rightNode;
        }
        public void Insert(T SourceItem)
        {
            BinaryTreeNode<T> tempNode = RootNode;
            bool found = false;
            while (!found)
            {
                int comparedValue = tempNode.Value.CompareTo(SourceItem);
                if (comparedValue == 0)
                {
                    if (tempNode.LeftNode == null)
                    {
                        tempNode.LeftNode = new BinaryTreeNode<T>(SourceItem, tempNode);
                        return;
                    }
                    else
                    {
                        tempNode = tempNode.LeftNode;
                    }
                }
                else
                {
                    if (tempNode.RightNode == null)
                    {
                        tempNode.RightNode = new BinaryTreeNode<T>(SourceItem, tempNode);
                        return;
                    }
                    else
                    {
                        tempNode = tempNode.RightNode;
                    }
                }
            }
        }

    }
}
