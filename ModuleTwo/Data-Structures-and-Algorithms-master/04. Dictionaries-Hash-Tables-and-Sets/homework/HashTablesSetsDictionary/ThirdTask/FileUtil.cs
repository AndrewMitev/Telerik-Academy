namespace ThirdTask
{
    using System;
    using System.IO;

    public static class FileUtil
    {
        public static string File;

        public static string[] ReadAllWords()
        {
            StreamReader reader = new StreamReader(File);

            using (reader)
            {
                string data = reader.ReadToEnd();
                data = data.Replace("?", "");
                Console.WriteLine(data);

                string[] words = data.Split(new[] { ' ', ',', '/', '!', '.' , '-'}, StringSplitOptions.RemoveEmptyEntries);

                return words;
            }
        }
    }
}
