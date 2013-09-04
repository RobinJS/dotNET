using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
	{
		public class Points
		{
			string userName;
			int userPoints;

            public string UserName
			{
				get { return userName; }
				set { userName = value; }
			}

            public int UserPoints
			{
				get { return userPoints; }
				set { userPoints = value; }
			}

			public Points() { }

            public Points(string name, int points)
			{
				this.userName = name;
				this.userPoints = points;
			}
		}

		static void Main(string[] arguments)
		{
			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombs = PlaceBombs();
			int counter = 0;
			bool mineExplosion = false;
            List<Points> championsList = new List<Points>(6);
			int row = 0;
			int column = 0;
			bool startNewGame = true;
			const int maxCells = 35;
			bool playerWin = false;

			do
			{
				if (startNewGame)
				{
					Console.WriteLine("Let's play \"Minesweeper\"!");
                    Console.WriteLine("Try your luck to find fields without mines.");
                    Console.WriteLine("If you enter 'top' you'll see the ranking, 'restart' starts new game, 'exit' exits the game!");
					dumpp(field);
					startNewGame = false;
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
						CreateRankings(championsList);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlaceBombs();
						dumpp(field);
						mineExplosion = false;
						startNewGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye-bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								MakePlayerTurn(field, bombs, row, column);
								counter++;
							}
							if (maxCells == counter)
							{
								playerWin = true;
							}
							else
							{
								dumpp(field);
							}
						}
						else
						{
							mineExplosion = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command\n");
						break;
				}
				if (mineExplosion)
				{
					dumpp(bombs);
					Console.Write("\nYou died like a hero with {0} points. " +
						"Enter your nickname: ", counter);
					string userNickname = Console.ReadLine();
                    Points points = new Points(userNickname, counter);
					if (championsList.Count < 5)
					{
						championsList.Add(points);
					}
					else
					{
						for (int i = 0; i < championsList.Count; i++)
						{
                            if (championsList[i].UserPoints < points.UserPoints)
							{
								championsList.Insert(i, points);
								championsList.RemoveAt(championsList.Count - 1);
								break;
							}
						}
					}
                    championsList.Sort((Points r1, Points r2) => r2.UserName.CompareTo(r1.UserName));
                    championsList.Sort((Points r1, Points r2) => r2.UserPoints.CompareTo(r1.UserPoints));
					CreateRankings(championsList);

					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					mineExplosion = false;
					startNewGame = true;
				}
				if (playerWin)
				{
					Console.WriteLine("\nCongratulations! You opened 35 cells without any blood drop.");
					dumpp(bombs);
					Console.WriteLine("Please, enter your name: ");
					string enteredName = Console.ReadLine();
                    Points currentPoints = new Points(enteredName, counter);
					championsList.Add(currentPoints);
					CreateRankings(championsList);
					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					playerWin = false;
					startNewGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - You're the best!");
			Console.Read();
		}

        private static void CreateRankings(List<Points> currentPoints)
		{
			Console.WriteLine("\nPoints:");
			if (currentPoints.Count > 0)
			{
				for (int i = 0; i < currentPoints.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, currentPoints[i].UserName, currentPoints[i].UserPoints);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty ranking!\n");
			}
		}

		private static void MakePlayerTurn(char[,] field,
			char[,] bombPositions, int row, int column)
		{
			char bombsCount = BombCounter(bombPositions, row, column);
			bombPositions[row, column] = bombsCount;
			field[row, column] = bombsCount;
		}

		private static void dumpp(char[,] board)
		{
			int fieldRows = board.GetLength(0);
			int fieldColumns = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < fieldRows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < fieldColumns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
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

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int columns = 10;
			char[,] playField = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					playField[i, j] = '-';
				}
			}

			List<int> bombPositions = new List<int>();
			while (bombPositions.Count < 15)
			{
				Random randomNumber = new Random();
				int randomLocation = randomNumber.Next(50);
				if (!bombPositions.Contains(randomLocation))
				{
					bombPositions.Add(randomLocation);
				}
			}

			foreach (int position in bombPositions)
			{
				int column = (position / columns);
				int row = (position % columns);
				if (row == 0 && position != 0)
				{
					column--;
					row = columns;
				}
				else
				{
					row++;
				}
				playField[column, row - 1] = '*';
			}

			return playField;
		}

		private static void BombEvaluation(char[,] gameField)
		{
			int fieldColumns = gameField.GetLength(0);
			int fieldRows = gameField.GetLength(1);

			for (int col = 0; col < fieldColumns; col++)
			{
				for (int row = 0; row < fieldRows; row++)
				{
					if (gameField[col, row] != '*')
					{
						char bombsCount = BombCounter(gameField, col, row);
						gameField[col, row] = bombsCount;
					}
				}
			}
		}

		private static char BombCounter(char[,] field, int rows, int columns)
		{
			int bombsCount = 0;
			int fieldRows = field.GetLength(0);
			int fieldColumns = field.GetLength(1);

			if (rows - 1 >= 0)
			{
				if (field[rows - 1, columns] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (rows + 1 < fieldRows)
			{
				if (field[rows + 1, columns] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (columns - 1 >= 0)
			{
				if (field[rows, columns - 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if (columns + 1 < fieldColumns)
			{
				if (field[rows, columns + 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if ((rows - 1 >= 0) && (columns - 1 >= 0))
			{
				if (field[rows - 1, columns - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((rows - 1 >= 0) && (columns + 1 < fieldColumns))
			{
				if (field[rows - 1, columns + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((rows + 1 < fieldRows) && (columns - 1 >= 0))
			{
				if (field[rows + 1, columns - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((rows + 1 < fieldRows) && (columns + 1 < fieldColumns))
			{
				if (field[rows + 1, columns + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			return char.Parse(bombsCount.ToString());
		}
	}
}
