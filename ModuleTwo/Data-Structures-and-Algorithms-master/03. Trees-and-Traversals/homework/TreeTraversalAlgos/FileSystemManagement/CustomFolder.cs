namespace FileSystemManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class CustomFolder
    {
        private const string ErrorMessageFormat =
            "Directory name {0} must be at least one character and contain only letters, numbers, dash, dot and comma";

        private static readonly Regex NameValidation = new Regex(@"^[\w:\\\-.,$&+ ]+$");

        public CustomFolder(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public ICollection<CustomFile> Files { get; } = new HashSet<CustomFile>();

        public ICollection<CustomFolder> ChildDirectories { get; } = new HashSet<CustomFolder>();

        public static CustomFolder GetDirectory(string path)
        {
            var directory = new CustomFolder(path);
            CustomFolder.BuildDirectoryTree(directory);
            return directory;
        }

        public IEnumerable<CustomFile> GetFilesWithExtension(string extension)
        {
            var result = new List<CustomFile>();
            this.AddFilesWithExtensionToCollection(extension, result);
            return result;
        }

        public long GetMemorySizeInBytes()
        {
            long result = 0;
            result +=
                this.ChildDirectories.Sum(childDirectory => childDirectory.GetMemorySizeInBytes());
            result += this.Files.Sum(file => file.SizeInBytes);
            return result;
        }

        public bool Equals(CustomFile other)
        {
            return other != null && this.Name.Equals(other.Name);
        }

        public override bool Equals(object obj)
        {
            var other = obj as CustomFile;
            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        private static void BuildDirectoryTree(CustomFolder rootDirectory)
        {
            try
            {
                var childDirectories = Directory.GetDirectories(rootDirectory.Name);
                foreach (string directory in childDirectories)
                {
                    rootDirectory.ChildDirectories.Add(new CustomFolder(directory));
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle directories we dont have access to.
            }

            foreach (var childDirectory in rootDirectory.ChildDirectories)
            {
                CustomFolder.BuildDirectoryTree(childDirectory);
            }

            try
            {
                var files = Directory.GetFiles(rootDirectory.Name);
                foreach (string file in files)
                {
                    var info = new FileInfo(file);
                    rootDirectory.Files.Add(new CustomFile(file, info.Length));
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle files we dont have access to.
            }
        }

        private void AddFilesWithExtensionToCollection(string extension, ICollection<CustomFile> files)
        {
            foreach (var file in this.Files.Where(file => file.Name.EndsWith(extension)))
            {
                files.Add(file);
            }

            foreach (var childDirectory in this.ChildDirectories)
            {
                childDirectory.AddFilesWithExtensionToCollection(extension, files);
            }
        }
    }
}