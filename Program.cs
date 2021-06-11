using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {

        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node()
            {
                
            }

            public Node(int data)
            {
                this.Data = data;
            }
        }

        public class BinaryTree
        {
            private Node _Root;

            public BinaryTree()
            {
                _Root = null;
            }

            public void Insert(int data)
            {
                if (_Root == null)
                {
                    _Root = new Node(data);
                    return;
                }

                InsertRec(_Root, new Node(data));
            }

            private void InsertRec(Node root, Node newNode)
            {
                if (root == null)
                    root = newNode;

                if (newNode.Data < root.Data)
                {
                    if (root.Left == null)
                        root.Left = newNode;
                    else
                    {
                        InsertRec(root.Left, newNode);
                    }
                }
                else
                {
                    if (root.Right == null)
                        root.Right = newNode;
                    else
                    {
                        InsertRec(root.Right, newNode);
                    }
                }
            }

            private void DisplayTree(Node root)
            {
                if (root == null) return;
                
                DisplayTree(root.Left);
                System.Console.Write(root.Data + "");
                DisplayTree(root.Right);
            }

            public void DisplayTree()
            {
                DisplayTree(_Root);
            }
            
        }

        class thisEpicTree
        {
            static void Main(string[] args)
            {
                BinaryTree tree = new BinaryTree();
                Node root = new Node();
                
                tree.Insert(10);
                tree.Insert(15);
                tree.Insert(6);
                tree.Insert(12);
                tree.Insert(13);
                tree.Insert(8);
                tree.Insert(18);
                tree.Insert(3);
            }
        }
    }
}