namespace FolderTraversal
{
    using System;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Windows folder is protected
            var rootPath = @"c:\windows";
            PrintAllExeFiles(rootPath);
        }

        private static void PrintAllExeFiles(string rootPath)
        {
            var subFolders = Directory.GetDirectories(rootPath);
            var containedFiles = Directory.GetFiles(rootPath);

            foreach (var file in containedFiles
                .Where(file => file.EndsWith(".exe"))
                .Select(file => file.Substring(file.LastIndexOf('\\') + 1)))
            {
                Console.WriteLine(file);
            }

            foreach (var folder in subFolders)
            {
                PrintAllExeFiles(folder);
            }
        }
    }
}