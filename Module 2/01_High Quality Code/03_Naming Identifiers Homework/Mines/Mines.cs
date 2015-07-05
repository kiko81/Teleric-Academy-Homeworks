namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        public static void Main(string[] аргументи)
        {
            const int FreeCells = 35;

            string command = string.Empty;
            char[,] playField = CreateField();
            char[,] mines = PlaceBombs();
            int counter = 0;
            bool onMine = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool atStart = true;
            bool gameEnded = false;

            do
            {
                if (atStart)
                {
                    Console.WriteLine("Lets play “Mines”. Try to open all cells without mines in" +
                    " Command 'top' shows table, 'restart' restarts the game, 'exit' quits the game");
                    PrintField(playField);
                    atStart = false;
                }

                Console.Write("Insert row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playField.GetLength(0) && col <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScores(champions);
                        break;
                    case "restart":
                        playField = CreateField();
                        mines = PlaceBombs();
                        PrintField(playField);
                        onMine = false;
                        atStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye! See you soon");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ChangePlayer(playField, mines, row, col);
                                counter++;
                            }

                            if (FreeCells == counter)
                            {
                                gameEnded = true;
                            }
                            else
                            {
                                PrintField(playField);
                            }
                        }
                        else
                        {
                            onMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! invalid command\n");
                        break;
                }

                if (onMine)
                {
                    PrintField(mines);
                    Console.Write("\nYou stepped on a mine - {0} points. insert your name: ", counter);
                    string nickName = Console.ReadLine();
                    Score playerScore = new Score(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < playerScore.Points)
                            {
                                champions.Insert(i, playerScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Points));
                    champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    HighScores(champions);

                    playField = CreateField();
                    mines = PlaceBombs();
                    counter = 0;
                    onMine = false;
                    atStart = true;
                }

                if (gameEnded)
                {
                    Console.WriteLine("\nCongratulations! You've opened all fields without mines.");
                    PrintField(mines);
                    Console.WriteLine("Put your name, buddy: ");
                    string name = Console.ReadLine();
                    Score points = new Score(name, counter);
                    champions.Add(points);
                    HighScores(champions);
                    playField = CreateField();
                    mines = PlaceBombs();
                    counter = 0;
                    gameEnded = false;
                    atStart = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Telerik");
            Console.WriteLine("Good luck.");
            Console.Read();
        }

        private static void HighScores(List<Score> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Table empty!\n");
            }
        }

        private static void ChangePlayer(char[,] field, char[,] bombs, int row, int col)
        {
            char numberOfMines = MineCount(bombs, row, col);
            bombs[row, col] = numberOfMines;
            field[row, col] = numberOfMines;
        }

        private static void PrintField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
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

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int rand = random.Next(50);
                if (!mines.Contains(rand))
                {
                    mines.Add(rand);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void CalculateFieldValues(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (field[col, row] != '*')
                    {
                        char mineCount = MineCount(field, col, row);
                        field[col, row] = mineCount;
                    }
                }
            }
        }

        private static char MineCount(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}