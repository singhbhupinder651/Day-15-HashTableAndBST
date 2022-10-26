using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    //class MyBinaryNode<T> : IComparable without where T : IComparable<T>, the CompareTo method is called from System.Int32 class, so it doesnt work
    internal class MyBinaryNode<T> : IComparable, INode where T : IComparable<T>  
    {

        public T NodeData { get; set; }

        internal MyBinaryNode(T data)
        {
            this.NodeData = data;
        }

        public int CompareTo(Object obj)
        {
            MyBinaryNode<T> incomingNode = (MyBinaryNode<T>)obj;
            return this.NodeData.CompareTo(incomingNode.NodeData);
        }

    }
}
