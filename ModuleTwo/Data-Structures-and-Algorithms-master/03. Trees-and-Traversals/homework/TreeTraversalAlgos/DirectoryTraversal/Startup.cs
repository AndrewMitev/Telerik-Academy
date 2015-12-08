namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string dir = "D:\\";

            InitiateTraverse(dir);
        }

        private static void InitiateTraverse(string dir)
        {
            FindExe(dir, " ");
        }

        private static void FindExe(string dir, string spaces)
        {
            spaces += " ";

            List<string> dirs = new List<string>();

            try
            {
                if (Directory.Exists(dir))
                {
                    dirs = Directory.GetDirectories(dir).ToList();

                    if (dirs.Count > 0)
                    {
                        foreach (var tempDir in dirs)
                        {
                            Console.WriteLine(spaces + tempDir);
                            ListDirecoty(tempDir, spaces + " ");
                            FindExe(tempDir, spaces + " ");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex) { }
        }

        private static void ListDirecoty(string dir, string spaces)
        {
            List<string> files = Directory
                .GetFiles(dir)
                .Where(f => f.EndsWith(".exe"))
                .ToList();

            foreach (var file in files)
            {
                Console.WriteLine(spaces + new FileInfo(file).Name);
            }
        }
    }
}
