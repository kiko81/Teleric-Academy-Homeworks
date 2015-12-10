namespace TreeManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[n];

            for (var i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (var i = 1; i < n; i++)
            {
                var treeConnection = Console.ReadLine().Split(' ');

                var parentId = int.Parse(treeConnection[0]);
                var childId = int.Parse(treeConnection[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // I. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // II. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.WriteLine("Leafs: " + string.Join(", ", leafs.Select(l => l.Value)));

            // III. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.WriteLine("Middle nodes: " + string.Join(", ", middleNodes.Select(mn => mn.Value)));

            // IV. Find the longest path from the root
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Number of levels: {0}", longestPath + 1);

            // V. Find all paths in the tree with given sum of their nodes
            Console.Write("Enter sum of path to search for: ");
            var pathSum = int.Parse(Console.ReadLine()); // 0 - 14 
            var paths = new List<List<Node<int>>>();
            FindPathWithSum(FindRoot(nodes), pathSum, new List<Node<int>>(), paths);

            if (paths.Count > 0)
            {
                foreach (var sumPath in paths)
                {
                    Console.WriteLine("{0} = {1}", string.Join(" + ", sumPath.Select(node => node.Value)), pathSum);
                }
            }
            else
            {
                Console.WriteLine("No path with that sum found");
            }

            // VI. Find all subtrees with given sum of their nodes
            Console.Write("Enter sum of subtree to search for: ");
            var subtreeSum = int.Parse(Console.ReadLine());
            var rootNodesOfSubreesWithGivenSum = new List<Node<int>>();
            GetSumOfAllSubtrees(FindRoot(nodes), subtreeSum, rootNodesOfSubreesWithGivenSum);

            foreach (var node in rootNodesOfSubreesWithGivenSum)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", GetElementsOfSubtree(node, new List<Node<int>>()).Select(st => st.Value)), subtreeSum);
            }
        }

        private static List<Node<int>> GetElementsOfSubtree(Node<int> root, List<Node<int>> elements)
        {
            elements.Add(root);
            foreach (var node in root.Children)
            {
                GetElementsOfSubtree(node, elements);
            }

            return elements;
        }

        private static int CalculateTreeSum(Node<int> node)
        {
            return node.Value + node.Children.Sum(CalculateTreeSum);
        }

        private static void GetSumOfAllSubtrees(Node<int> rootNode, int wantedSum, ICollection<Node<int>> rootsOfSubtrees)
        {
            var currentNodeSUm = CalculateTreeSum(rootNode);
            if (currentNodeSUm == wantedSum)
            {
                rootsOfSubtrees.Add(rootNode);
            }

            foreach (var child in rootNode.Children)
            {
                GetSumOfAllSubtrees(child, wantedSum, rootsOfSubtrees);
            }
        }

        private static void FindPathWithSum(Node<int> root, int requestedSum, List<Node<int>> currentPath, ICollection<List<Node<int>>> resultingPaths)
        {
            currentPath.Add(root);
            var currentPathSum = currentPath.Sum(n => n.Value);

            if (currentPathSum > requestedSum)
            {
                return;
            }

            if (currentPathSum == requestedSum)
            {
                resultingPaths.Add(currentPath);
            }

            foreach (var child in root.Children)
            {
                FindPathWithSum(child, requestedSum, new List<Node<int>>(), resultingPaths);
                FindPathWithSum(child, requestedSum, new List<Node<int>>(currentPath), resultingPaths);
            }
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            var maxPath = root.Children.Select(FindLongestPath)
                              .Concat(new[] { 0 })
                              .Max();

            return maxPath + 1;
        }

        private static IEnumerable<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            return nodes.Where(node => node.HasParent && node.Children.Count > 0)
                        .ToList();
        }

        private static IEnumerable<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            return nodes.Where(node => node.Children.Count == 0)
                        .ToList();
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var child in nodes.SelectMany(node => node.Children))
            {
                hasParent[child.Value] = true;
            }

            for (var i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            return null;
        }
    }
}
