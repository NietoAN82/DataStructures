using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Used for initial tree 
    /*class Example
    {
        public static void Main(string[] args)
        {
            //Create a tree for code work.
            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");
            TreeNode<string> d = new TreeNode<string>("d");
            TreeNode<string> e = new TreeNode<string>("e");
            TreeNode<string> f = new TreeNode<string>("f");
            TreeNode<string> g = new TreeNode<string>("g");

            //Set b to be left node of a. a is the root, b is the left child, and c is the right child
            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            b.SetRight(e);
            c.SetLeft(f);
            c.SetRight(g);

            Debug.WriteLine(Trees<string>.GetHeight(a));
        }
    }*/
    //Used for traversal of tree
    class Example
    {
        public static void Main(string[] args)
        {
            //Create a tree for code work.
            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");


            //Set b to be left node of a. a is the root, b is the left child, and c is the right child
            a.SetLeft(b);
            a.SetRight(c);
            //Preorder()Visit the root node then the left node then the right node
            //PreOrder(a);

            //InOrder(a) Visit the left node, root node, then the right node.
            //InOrder(a);

            //PostOrder() Vist left node, then the right node, then the root node.
            PostOrder(a);
        }

        static void PreOrder(TreeNode<string> root)
        {
            if(root != null)
            {
                Debug.WriteLine(root.GetValue().ToString() + " ");
                PreOrder(root.GetLeft());
                PreOrder(root.GetRight());
            }
        }

        static void InOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                InOrder(root.GetLeft());
                Debug.WriteLine(root.GetValue().ToString());
                InOrder(root.GetRight());
            }
        }

        static void PostOrder(TreeNode<string> root)
        {
            if(root != null)
            {
                PostOrder(root.GetLeft());
                PostOrder(root.GetRight());
                Debug.WriteLine(root.GetValue().ToString());
            }
        }

        static bool IsBalanced(TreeNode<string> root)
        {
            int diff = 0;

            if((root.GetLeft() != null && root.GetRight() == null) ||
                root.GetLeft() == null && root.GetRight() != null)
            {
                diff += 1;
            }
            else
            {
                diff = 0;
            }

            return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
        }
    }
    public class Trees<T> //<> added so program recognizes generic parameter
    {
        

        /// <summary>
        /// Function that determines the height of the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int GetHeight(TreeNode<T> root)
        {
            if (root == null) { return 0; } else
            {
                return Math.Max(GetHeight(root.GetLeft()), GetHeight(root.GetRight()) + 1); // Add one to account for root
            }
        }
        
    }

    public class TreeNode<T>//<> makes it possible to have a value of any type. T is placeholder
    {
        T value;
        TreeNode<T> left = null;
        TreeNode<T> right = null;

        public TreeNode(T value)
        {
            this.value = value;
        }

        //Add three getter methods and three setter methods for the tree.
        public TreeNode<T> GetLeft() { return left; }
        public TreeNode<T> GetRight() { return right; }
        public T GetValue()
        {
            return value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetRight(TreeNode<T> node)
        {
            right = node;
        }
        public void SetLeft(TreeNode<T> node)
        {
            left = node;
        }
    }
}
