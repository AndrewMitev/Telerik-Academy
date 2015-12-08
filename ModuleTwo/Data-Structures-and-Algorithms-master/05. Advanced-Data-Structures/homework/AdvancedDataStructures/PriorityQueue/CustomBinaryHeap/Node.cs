namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class Node<T> where T : struct, IComparable<T>
    {
        public Node(T value, bool hasParent)
        {
            this.Value = value;
            this.HasParent = hasParent;
            this.Children = new List<Node<T>>();
        }

        public T Value { get; set; }

        public bool HasParent { get; set; }

        public IList<Node<T>> Children { get; set; }

        public void AddChild(Node<T> child)
        {
            if (this.Children.Count < 2 && this.Value.CompareTo(child.Value) > 0)
            {
                this.Children.Add(child);
            }
        }

        public Node<T> GetChild(int index)
        {
            return this.Children[index];
        }
    }
}
