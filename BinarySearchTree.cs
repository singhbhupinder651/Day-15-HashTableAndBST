using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        MyBinaryNode<T> rootNode;
        BinarySearchTree<T> leftChildTree { get; set; }
        BinarySearchTree<T> rightChildTree { get; set; }
        internal BinarySearchTree(T nodeData)
        {
            rootNode = new MyBinaryNode<T>(nodeData);
            leftChildTree = null;
            rightChildTree = null;
        }
        
        static int leftCount = 0, rightCount = 0;

        public void Insert(T item)
        {

            T currentNodeValue = this.rootNode.NodeData;
            if(currentNodeValue.CompareTo(item) > 0)
            {
                if(leftChildTree == null)
                {
                    leftCount++;
                    leftChildTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    leftChildTree.Insert(item);
                }
            }
            else
            {
                if(rightChildTree == null)
                {
                    rightCount++;
                    rightChildTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    rightChildTree.Insert(item);
                }
            }

        }

        public void GetSize()
        {
            Console.WriteLine("Size of Binary Search Tree: " + (1 + leftCount + rightCount));
        }

        bool result = false;
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.rootNode.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.rootNode.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element in BST is: {0}", node.rootNode.NodeData);
            }
            if(element.CompareTo(node.rootNode.NodeData) < 0)
            {
                IfExists(element, node.leftChildTree);
            }
            if(element.CompareTo(node.rootNode.NodeData) > 0)
            {
                IfExists(element, node.rightChildTree);
            }

            return result;
        }


        public void Display()
        {

            if(leftChildTree != null)
            {
                leftChildTree.Display();
            }

            Console.WriteLine(this.rootNode.NodeData.ToString());

            if(rightChildTree != null)
            {
                rightChildTree.Display();
            }

        }

    }
}
