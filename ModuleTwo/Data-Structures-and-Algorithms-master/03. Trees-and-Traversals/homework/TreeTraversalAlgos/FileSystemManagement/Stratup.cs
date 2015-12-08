namespace FileSystemManagement
{
    using System;

    public class Stratup
    {
        public static void Main()
        {
            var path = @"C:\Windows";
            var directory = CustomFolder.GetDirectory(path);

            Console.WriteLine(path + "size in bytes: " + directory.GetMemorySizeInBytes());
        }
    }
}
