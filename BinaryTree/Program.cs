using System;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> color = InitializeBinaryTree();

            color.Find("S");
            color.Find("M");
            color.Find("K");
            Console.WriteLine("S sayısı {0}", color.SCount);
            Console.WriteLine("M sayısı {0}", color.MCount);
            Console.WriteLine("K sayısı {0}", color.KCount);
        }

        private static BinaryTree<string> InitializeBinaryTree()
        {
            BinaryTree<string> color = new BinaryTree<string>(new BinaryTreeNode<string>("M"));

            color.Add("S");
            color.Add("M");
            color.Add("K");
            color.Add("K");
            color.Add("M");
            color.Add("S");
            color.Add("M");
            color.Add("M");
            color.Add("S");
            color.Add("S");
            color.Add("K");
            return color;
        }
    }
}
