using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeNode<T>
    {
        private T value;

        private bool hasParent;

        private BinarySearchTreeNode<T> parent;

        private BinarySearchTreeNode<T> leftChild;

        private BinarySearchTreeNode<T> rightChild;

        public BinarySearchTreeNode(T val,BinarySearchTreeNode<T> parent, BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
        {
            this.Value = val;
            this.LeftChild = left;
            this.RightChild = right;
            this.Parent = parent;
        }

        public BinarySearchTreeNode(T val) : this(val, null, null, null)
        { }

        public BinarySearchTreeNode<T> Parent
        {
            get { return this.parent; }
            set 
            {
                if (value == null)
                {
                    return;
                }
                this.parent = value;
            }
        }

        public T Value
        {
            get { return this.value; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert null value");
                }

                this.value = value;
            
            }
        }

        public BinarySearchTreeNode<T> LeftChild
        {
            get { return this.leftChild; }
            
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("This node has parent.");
                }

                this.leftChild = value;
                this.leftChild.hasParent = true;
            
            }
        }

        public BinarySearchTreeNode<T> RightChild
        {
            get { return this.rightChild; }
            
            set 
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("node already has a parent you stupid cunt!");
                }

                value.hasParent = true;
                this.rightChild = value;
            }
        }
    }
}
