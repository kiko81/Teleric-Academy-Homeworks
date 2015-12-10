namespace DirectoryTree
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            {
                // Windows directory is protected
                var rootPath = @"c:\windows";
                var rootFolder = new Folder(rootPath);

                CreateFolderTree(rootFolder);

                var size = CalculateSize(rootFolder);
            }
        }

        private static void CreateFolderTree(Folder folder)
        {
            var folderInfo = new DirectoryInfo(folder.Name);
            var subFoldersToAdd = new List<Folder>();

            var containedFiles = folderInfo.GetFiles();

            folder.Files = containedFiles.Select(file => new File(file.Name, (int)file.Length)).ToArray();

            foreach (var subfolder in Directory.GetDirectories(folder.Name))
            {
                var folderToAdd = new Folder(subfolder);
                subFoldersToAdd.Add(folderToAdd);
                CreateFolderTree(folderToAdd);
            }

            folder.Folders = subFoldersToAdd.ToArray();
        }

        private static int CalculateSize(Folder folder, int size = 0)
        {
            size += folder.Files.Sum(file => file.Size);

            size += folder.Folders.Sum(subfolder => CalculateSize(subfolder));

            return size;
        }
    }
}