using System;
using System.IO;

namespace DirectoryTraverse
{
    class DirectoryTraverse
    {
        static void Main()
        {
            string pathToTraverse = @"C:\Windows";
            TraverseDir(pathToTraverse);
        }

        private static void TraverseDir(DirectoryInfo dir)
        {
            try
            {
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".exe")
                    {
                        Console.WriteLine(file.Name);
                    }
                }

                DirectoryInfo[] children = dir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    TraverseDir(child);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized access to dir: " + dir.FullName);
            }
        }

        public static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath));
        }
    }
}
