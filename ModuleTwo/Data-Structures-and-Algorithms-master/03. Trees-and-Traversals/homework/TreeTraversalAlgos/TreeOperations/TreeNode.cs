namespace TreeOperations
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        public TreeNode(T value)
        {
            this.Element = value;
        }

        public T Element { get; }

        public bool HasParent { get; internal set; }

        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();
    }
}
