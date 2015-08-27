namespace MinesNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mine
	{
        public static void Main(string[] arguments)
        {
            const int MAX_POINTS = 35;

			string command = string.Empty;

            int counter = 0;
			int row = 0;
			int column = 0;
		
            bool isMineHit = false;
            bool isNewGame = true;
			bool isGameWon = false;

            char[,] field = CreateField();
            char[,] landmineField = PlaceLandmines();

            List<Point> listOfPoints = new List<Point>(6);

			do
			{
				if (isNewGame)
				{
                    InitializeNewGame(field);
					isNewGame = false;
				}

				Console.Write("Enter row and column : ");
				command = Console.ReadLine().Trim();

				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						ShowPlayersRanks(listOfPoints);
						break;
					case "restart":
						field = CreateField();
						landmineField = PlaceLandmines();
						Display(field);
						isMineHit = false;
						isNewGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye!");
						break;
					case "turn":
						if (landmineField[row, column] != '*')
						{
							if (landmineField[row, column] == '-')
							{
								PlayerMove(field, landmineField, row, column);
								counter++;
							}

							if (MAX_POINTS == counter)
							{
								isGameWon = true;
							}
							else
							{
								Display(field);
							}
						}
						else
						{
							isMineHit = true;
						}

						break;
                    default:
                        {
                            Console.WriteLine("\nError! Invalid command\n");
                            break;
                        }
				}

				if (isMineHit)
				{
					Display(landmineField);

					Console.Write("\nHrrrrrr! Player dead! {0} Points. Enter player nickname: ", counter);

					string playerNickname = Console.ReadLine();
					Point playerPoints = new Point(playerNickname, counter);

					if (listOfPoints.Count < 5)
					{
						listOfPoints.Add(playerPoints);
					}
					else
					{
						for (int i = 0; i < listOfPoints.Count; i++)
						{
							if (listOfPoints[i].PointsCount < playerPoints.PointsCount)
							{
								listOfPoints.Insert(i, playerPoints);
								listOfPoints.RemoveAt(listOfPoints.Count - 1);
								break;
							}
						}
					}

					listOfPoints.Sort((Point firstPoint, Point secondPoint) => secondPoint.Name.CompareTo(firstPoint.Name));

					listOfPoints.Sort((Point firstPoint, Point secondPoint) => secondPoint.PointsCount.CompareTo(firstPoint.PointsCount));

					ShowPlayersRanks(listOfPoints);

					field = CreateField();
					landmineField = PlaceLandmines();
					counter = 0;
					isMineHit = false;
					isNewGame = true;
				}

				if (isGameWon)
				{
					Console.WriteLine("\nBRAVOOOS! You have succeeded.");
					Display(landmineField);

					Console.WriteLine("Enter nickname: ");
					string nickname = Console.ReadLine();

					Point points = new Point(nickname, counter);
					listOfPoints.Add(points);

					ShowPlayersRanks(listOfPoints);

					field = CreateField();
					landmineField = PlaceLandmines();

					counter = 0;

					isGameWon = false;
					isNewGame = true;
				}
			}
			while (command != "exit");

			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.Read();
		}

		private static void ShowPlayersRanks(List<Point> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",	i + 1, points[i].Name, points[i].PointsCount);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty ranks!\n");
			}
		}

		private static void PlayerMove(char[,] field, char[,] landmines, int row, int column)
		{
			char landminesCount = GetNumberOfPoints(landmines, row, column);
			landmines[row, column] = landminesCount;
			field[row, column] = landminesCount;
		}

		private static void Display(char[,] board)
		{
			int boardRowLength = board.GetLength(0);
			int boardColumnLength = board.GetLength(1);

			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");

			for (int row = 0; row < boardRowLength; row++)
			{
				Console.Write("{0} | ", row);

				for (int column = 0; column < boardColumnLength; column++)
				{
					Console.Write(string.Format("{0} ", board[row, column]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

        private static void InitializeNewGame(char[,] field)
        {
            Console.WriteLine("Welcome to “Mines”. Find fields without mines." +
                                "'top' command shows current rank list, 'restart' - begin new game, 'exit' - exit game!");

            Display(field);
        }

		private static char[,] CreateField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];

			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceLandmines()
		{
			int rows = 5;
			int columns = 10;
			char[,] field = new char[rows, columns];

			for (int row = 0; row < rows; row++)
			{
				for (int column = 0; column < columns; column++)
				{
					field[row, column] = '-';
				}
			}

			List<int> listOfRandomNumbers = new List<int>();

			while (listOfRandomNumbers.Count < 15)
			{
				Random random = new Random();
				int randomNumber = random.Next(50);

				if (!listOfRandomNumbers.Contains(randomNumber))
				{
					listOfRandomNumbers.Add(randomNumber);
				}
			}

            foreach (int number in listOfRandomNumbers)
			{
				int currentColumn = number / columns;
				int currentRow = number % columns;

				if (currentRow == 0 && number != 0)
				{
					currentColumn--;
					currentRow = columns;
				}
				else
				{
					currentRow++;
				}

				field[currentColumn, currentRow - 1] = '*';
			}

			return field;
		}

		private static void AssignPointsOnField(char[,] field)
		{
			int columnLength = field.GetLength(0);
			int rowLength = field.GetLength(1);

			for (int row = 0; row < columnLength; row++)
			{
				for (int column = 0; column < rowLength; column++)
				{
					if (field[row, column] != '*')
					{
                        char numberOfPoints = GetNumberOfPoints(field, row, column);
						field[row, column] = numberOfPoints;
					}
				}
			}
		}

		private static char GetNumberOfPoints(char[,] field, int rowIndex, int columnIndex)
		{
			int count = 0;
			int rows = field.GetLength(0);
            int columns = field.GetLength(1);

			if (rowIndex - 1 >= 0)
			{
                if (field[rowIndex - 1, columnIndex] == '*')
				{ 
					count++; 
				}
			}

			if (rowIndex + 1 < rows)
			{
                if (field[rowIndex + 1, columnIndex] == '*')
				{ 
					count++; 
				}
			}

			if (columnIndex - 1 >= 0)
			{
                if (field[rowIndex, columnIndex - 1] == '*')
				{ 
					count++;
				}
			}

			if (columnIndex + 1 < columns)
			{
                if (field[rowIndex, columnIndex + 1] == '*')
				{ 
					count++;
				}
			}

			if ((rowIndex - 1 >= 0) && (columnIndex - 1 >= 0))
			{
                if (field[rowIndex - 1, columnIndex - 1] == '*')
				{ 
					count++; 
				}
			}

			if ((rowIndex - 1 >= 0) && (columnIndex + 1 < columns))
			{
                if (field[rowIndex - 1, columnIndex + 1] == '*')
				{ 
					count++; 
				}
			}

			if ((rowIndex + 1 < rows) && (columnIndex - 1 >= 0))
			{
                if (field[rowIndex + 1, columnIndex - 1] == '*')
				{ 
					count++; 
				}
			}

			if ((rowIndex + 1 < rows) && (columnIndex + 1 < columns))
			{
                if (field[rowIndex + 1, columnIndex + 1] == '*')
				{ 
					count++; 
				}
			}

			return char.Parse(count.ToString());
		}

        public class Point
        {
            private string name;
            private int pointsCount;

            public Point()
            {
            }

            public Point(string name, int numberOfPoints)
            {
                this.Name = name;
                this.PointsCount = numberOfPoints;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int PointsCount
            {
                get { return this.pointsCount; }
                set { this.pointsCount = value; }
            }
        }
	}
}