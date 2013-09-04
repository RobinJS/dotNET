using System;
using System.Collections.Generic;

namespace TreesAndTraversals
{
    class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public void FindRoot()
        {
            string searchFor = "root";
            TraverseBFS(searchFor);
        }

        public void FindLeafs()
        {
            string searchFor = "leafs";
            TraverseBFS(searchFor);
        }

        public void FindMiddleNodes()
        {
            string searchFor = "middleNodes";
            TraverseBFS(searchFor);
        }

        public void TraverseBFS(string searchFor)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.root);
            List<T> leafs = new List<T>();
            List<T> middleNodes = new List<T>();

            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                //Console.Write("{0} ", currentNode.Value);

                if (searchFor == "root" && currentNode.HasParent == false)
                {
                    Console.WriteLine("The root is: " + currentNode.Value);
                }

                if (searchFor == "leafs" && currentNode.ChildrenCount == 0)
                {
                    leafs.Add(currentNode.Value);
                }

                if (searchFor == "middleNodes" && currentNode.HasParent && currentNode.ChildrenCount > 0)
                {
                    middleNodes.Add(currentNode.Value);
                }

                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {

                    TreeNode<T> childNode = currentNode.GetChild(i);

                    queue.Enqueue(childNode);
                }
            }

            if (searchFor == "leafs")
            {
                Console.Write("The leafs are: ");
                Print(leafs);
            }

            if (searchFor == "middleNodes")
            {
                Console.Write("The middle nodes are: ");
                Print(middleNodes);
            }
        }

        public void Print(List<T> nodes)
        {
            foreach (var item in nodes)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
