namespace CatConcert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] catsData = Console.ReadLine().Split(' ');
            int catsCount = int.Parse(catsData[0]);

            List<Cat> listOfCats = new List<Cat>();

            for (int i = 0; i < catsCount; i++)
            {
                listOfCats.Add(new Cat(i + 1));
            }

            string[] songsData = Console.ReadLine().Split(' ');
            long songsCount = long.Parse(songsData[0]);

            AddSongsToCats(listOfCats);

            int indexOFCatWithLeastSongs = GetCatWithLeastSongs(listOfCats);   

            Cat badCat = listOfCats[indexOFCatWithLeastSongs];

            listOfCats.RemoveAt(indexOFCatWithLeastSongs);

            List<long> resultsList = new List<long>();

            foreach (int song in badCat.Songs)
            {
                int numberOfSongsCatDoesntKnow = 1;

                foreach (Cat cat in listOfCats)
                {
                    if (!cat.Songs.Contains(song))
                    {
                        numberOfSongsCatDoesntKnow++;
                    }
                }

                resultsList.Add(numberOfSongsCatDoesntKnow);
            }

            resultsList.Sort();

            Console.WriteLine(resultsList[0]);
        }

        internal static void AddSongsToCats(List<Cat> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("AddSongsToCats(): must pass list of Cats");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("Mew!"))
                {
                    break;
                }
                else
                {
                    string[] data = input.Split(' ');

                    int key = int.Parse(data[1]);
                    int val = int.Parse(data[4]);

                    if (key <= list.Count)
                    {
                        list[key - 1].Songs.Add(val);
                    }
                }
            }
        }

        private static int GetCatWithLeastSongs(List<Cat> listOfCats)
        {
            if (listOfCats == null || listOfCats.Count == 0)
            {
                throw new ArgumentException("GetCatWithLeastSongs(): must pass list of Cats");
            }

            int min = int.MaxValue;
            int minIndex = 0;

            foreach (Cat cat in listOfCats)
            {
                int j = 0;

                int catSongsCount = cat.Songs.Count();

                if (catSongsCount == 0)
                {
                    Console.WriteLine("No concert!");
                    Environment.Exit(0);
                }
                else if (catSongsCount < min)
                {
                    min = catSongsCount;
                    minIndex = j;
                }

                j++;
            }

            return minIndex;
        }
    }
}
