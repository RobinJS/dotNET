using System;

namespace TreesAndTraversals
{
    class TreesAndTraversals
    {
        static void Main()
        {
            Tree<int> tree =
            new Tree<int>(3,
                          new Tree<int>(5,
                                        new Tree<int>(0),
                                        new Tree<int>(1),
                                        new Tree<int>(6)),
                          new Tree<int>(2,
                                        new Tree<int>(4)));

            tree.FindRoot();
            Console.WriteLine();
            tree.FindLeafs();
            Console.WriteLine();
            tree.FindMiddleNodes();
        }
    }
}
