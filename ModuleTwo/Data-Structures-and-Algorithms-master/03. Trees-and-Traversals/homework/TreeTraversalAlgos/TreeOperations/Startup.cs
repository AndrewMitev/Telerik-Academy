namespace TreeOperations
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string input = @"7
                            2 4
                            3 2
                            5 0
                            3 5
                            5 6
                            5 1";

            var reader = new StringReader(input);
            Console.SetIn(reader);

            int numberOfNodes = int.Parse(Console.ReadLine());

            var allNodes = new TreeNode<int>[numberOfNodes];

            for (int i = 0; i < numberOfNodes; i++)
            {
                allNodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i < numberOfNodes; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                int indexParent = int.Parse(data[0]);
                int indexChild = int.Parse(data[1]);

                allNodes[indexChild].HasParent = true;
                allNodes[indexParent].Children.Add(allNodes[indexChild]);
            }

            TreeNode<int> root = FindRootNode(allNodes);
            Console.WriteLine("Root node is: " + root.Element);

            DisplayListOfNodes(GetAllLeaves(allNodes));

            Console.WriteLine(FindLongestPath(root));
        }

        private static TreeNode<int> FindRootNode(TreeNode<int>[] tree)
        {
            foreach (TreeNode<int> node in tree)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }

            return null;
        }

        private static List<TreeNode<int>> GetAllLeaves(TreeNode<int>[] tree)
        {

            List<TreeNode<int>> leaves = new List<TreeNode<int>>();

            foreach (var node in tree)
            {
                if (node.Children.Count == 0)
                {
                    leaves.Add(node);
                }
            }

            return leaves;
        }

        private List<TreeNode<int>> GetAllMiddleNodes(TreeNode<int>[] tree)
        {
            List<TreeNode<int>> middleNodes = new List<TreeNode<int>>();

            foreach (var node in tree)
            {
                if (node.HasParent == true && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(TreeNode<int> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int longestPathLength = 0;
            foreach (var child in node.Children)
            {
                int childLongest = FindLongestPath(child);
                if (childLongest > longestPathLength)
                {
                    longestPathLength = childLongest;
                }
            }

            return longestPathLength + 1;
        }

        private static void DisplayListOfNodes(ICollection<TreeNode<int>> nodes)
        {
            Console.Write("All leaves are: ");
            foreach (var node in nodes)
            {
                Console.Write(node.Element + " ");
            }

            Console.WriteLine();
        }
    }
}
