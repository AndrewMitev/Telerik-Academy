namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class BinaryHeapPriorityQueue<T> where T : struct, IComparable<T>
    {
        public BinaryHeapPriorityQueue(T value, params Node<T>[] children)
        {
            this.Root = new Node<T>(value, false);

            this.Stack = new Stack<Node<T>>();

            foreach (var item in children)
            {
                this.Root.AddChild(item);
            }
        }

        public Node<T> Root { get; private set; }

        public Stack<Node<T>> Stack;

        public void Enqueue(Node<T> element)
        {
            if (element.Value.CompareTo(this.Root.Value) > 0)
            {
                Console.WriteLine("cmp");
                element.AddChild(Root);

                this.Root = element;
            }
            else
            {
                InsertValue(element, this.Root);
            }
        }

        public T Dequeue()
        {
            return this.Stack.Pop().Value;
        }

        public void DFS()
        {
            this.Stack.Push(this.Root);
            Traverse(this.Root);
        }

        public void DisplayAllValues()
        {
            while (this.Stack.Count > 0)
            {
                Console.WriteLine(this.Dequeue());
            }
        }

        private void Traverse(Node<T> node)
        {
            foreach (var item in node.Children)
            {
                if (!this.Stack.Contains(item))
                {
                    this.Stack.Push(item);
                    Traverse(item);
                }
            }
        }

        private void InsertValue(Node<T> element, Node<T> parent)
        {
            if (parent.Children.Count == 0 && parent.Value.CompareTo(element.Value) > 0)
            {
                parent.Children.Add(element);
            }
            else
            {
                foreach (var child in parent.Children)
                {
                    if (element.Value.CompareTo(child.Value) < 0 && child.Children.Count < 2)
                    {
                        child.Children.Add(element);
                        return;
                    }
                    else if (element.Value.CompareTo(child.Value) < 0 && child.Children.Count >= 2)
                    {
                        InsertValue(element, child);
                    }
                }
            }
        }
    }
}
