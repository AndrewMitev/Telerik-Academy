namespace PriorityQueue
{
    using System;
    /// <summary>
    /// Should be something like this. 
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            BinaryHeapPriorityQueue<int> heap = new BinaryHeapPriorityQueue<int>(8);

            heap.Enqueue(new Node<int>(5, true));
            heap.Enqueue(new Node<int>(1, true));
            heap.Enqueue(new Node<int>(1, true));
            heap.Enqueue(new Node<int>(1, true));
            heap.DFS();

            heap.DisplayAllValues();
        }
    }
}
