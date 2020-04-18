using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinarySearchTree
    {
        public Node Root;
        public int AddNode(int value)
        {
            Node n = new Node();
            n.Data = value;
            return AddNode(n);
        }
        public int AddNode(Node node)
        {
            Node current = Root;
            Node parent = Root;
            //Tree is Empty, insert 1st Node.
            if (current == null)
            {
                Root = node;
                return 0;
            }
            while (true)
            {
                parent = current;
                if (current.Compare(node) > 0)
                {
                    current = current.LeftChild;
                    if (current == null)
                    {
                        parent.LeftChild = node;
                        return 1;
                    }
                }
                else if (current.Compare(node) == 0)
                {
                    Console.WriteLine("Node Already Exists. Exiting.");
                    return -1;
                }
                else if (current.Compare(node) < 0)
                {
                    current = current.RightChild;
                    if (current == null)
                    {
                        parent.RightChild = node;
                        return 1;
                    }
                }
            }
            //current = node;
            //return -1;
        }

        public object ToString()
        {
            return this.Root == null ? null : this.Root.ToString();
        }

        internal void InOrderTraverse()
        {
            Stack<Node> nodes = new Stack<Node>();
            Node curr = this.Root;

            if (this.Root == null)
            {
                //Console.WriteLine("Tree is Empty");
                return;
            }

            while (true)
            {
                if (curr != null)
                {
                    nodes.Push(curr);
                    curr = curr.LeftChild;
                }
                if (curr == null)
                {
                    curr = nodes.Pop();
                    Console.WriteLine(curr.Data);

                    curr = curr.RightChild;
                }

                if (nodes.Count == 0 && curr == null)
                {
                    break;
                }

            }
        }

        internal void PreOrderTraverse()
        {
            Stack<Node> nodes = new Stack<Node>();
            Node curr = this.Root;

            if (this.Root == null)
            {
                //Console.WriteLine("Tree is Empty");
                return;
            }

            while (true)
            {
                if (curr.RightChild != null)
                {
                    nodes.Push(curr.RightChild);
                }
                if (curr.LeftChild != null)
                {
                    nodes.Push(curr.LeftChild);
                }
                if (curr != null)
                {
                    Console.WriteLine(curr.Data);
                }
                if(nodes.Count>0)
                {
                    curr = nodes.Pop();
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;

        public int Compare(Node n)
        {
            if (this.Data == n.Data)
            {
                return 0;
            }
            else if (this.Data < n.Data)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }

    class BSTRunner
    {
        //public static void Main()
        //{
        //    BinarySearchTree tree = new BinarySearchTree();

        //    tree.AddNode(50);
        //    tree.AddNode(10);
        //    tree.AddNode(10);
        //    tree.AddNode(20);
        //    tree.AddNode(30);
        //    tree.AddNode(40);
        //    tree.AddNode(60);
        //    tree.AddNode(70);
        //    tree.AddNode(80);
        //    tree.AddNode(90);

        //    tree.InOrderTraverse();
        //    tree.PreOrderTraverse();
        //}
    }
}
