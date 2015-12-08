﻿namespace FileSystemManagement
{
    using System.Text.RegularExpressions;

    internal class CustomFile
    {
        private const string ErrorMessageFormat =
            "File name {0} must be at least one character and contain only letters, numbers, dash, dot and comma";

        private static readonly Regex NameValidation = new Regex(@"^[\w:\\\-.,$&+ ]+$");

        public CustomFile(string name, long sizeInBytes)
        {
            this.Name = name;
            this.SizeInBytes = sizeInBytes;
        }

        public string Name { get; set; }

        public long SizeInBytes { get; set; }

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

        public override string ToString()
        {
            return this.Name;
        }
    }
}
