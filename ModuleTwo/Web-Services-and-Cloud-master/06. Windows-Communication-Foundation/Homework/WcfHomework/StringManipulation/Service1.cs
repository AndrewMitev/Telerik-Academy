namespace StringManipulation
{
    public class Service1 : IService1
    {
        public int NumberOfOccurances(string str1, string str2)
        {
            int counter = 0;
            int pos = 0;
            int lengthOfWord = str2.Length;

            while (true)
            {
                pos = str1.IndexOf(str2, pos);

                if (pos < 0)
                {
                    break;
                }
                
                counter++;
            }

            pos += lengthOfWord;
            return counter;
        }
    }
}
