using System;
using System.Collections.Generic;
using System.Linq;

namespace SeaChess1._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
=======
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("The rules are simple: first player play only with X, second play with O.");
            Console.WriteLine("First player make line or diagonal of 3 consecutive X or O wins.");
            Console.WriteLine("To choose the player where he plays, enter 2 numbers: 1st for a row, 2nd for a cell with space between them.");
            Console.WriteLine();
            CreatingAField();
<<<<<<< HEAD
            Console.WriteLine();
            int r = 0;
            int c = 0;
            string points = "Score: ";
            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;
            PrintScore(r, c, points);
            PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
            Console.WriteLine();

            string firstOrSecondPlayer = string.Empty;
            int count = 0;
            int[] playersMoves = new int[9];
            int[] position = new int[2];
            bool isRange = false;
            bool isPlayed = false;
            ConsoleKeyInfo play;

            while (true)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    firstOrSecondPlayer = "first";
                    Console.WriteLine("First player!");
                    position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    CheckRangeOfNumbers(position, ref isRange);
=======

            string firstOrSecondPlayer = string.Empty;
            string command = string.Empty;
            int count = 1;
            int row = 0;
            int col = 0;
            int[,] matrix = new int[3, 3];
            List<string> name = new List<string>();
            int[] position = new int[2];
            bool isRange = false;

            while (true)
            {
                if (count % 2 == 1)
                {
                    firstOrSecondPlayer = "first";
                    Console.WriteLine("First player!");
                    position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    CheckRangeOfNumbers(position, count, ref isRange);
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                    if (!isRange)
                    {
                        isRange = true;
                        continue;
                    }
<<<<<<< HEAD

=======
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                    count++;
                }
                else
                {
<<<<<<< HEAD
                    Console.WriteLine();
                    Console.WriteLine();
                    firstOrSecondPlayer = "second";
                    Console.WriteLine("Second player!");
                    position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    CheckRangeOfNumbers(position, ref isRange);
=======
                    firstOrSecondPlayer = "second";
                    Console.WriteLine("Second player!");
                    position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    CheckRangeOfNumbers(position, count, ref isRange);
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                    if (!isRange)
                    {
                        isRange = true;
                        continue;
                    }
<<<<<<< HEAD

=======
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                    count++;
                }

                if (firstOrSecondPlayer == "first")
                {
<<<<<<< HEAD
                    FirstPlayerPosition(position, playersMoves, ref isPlayed);
                    if (!isPlayed)
                    {
                        Console.WriteLine("That move is already played, please chose again.");
                        count--;
                        continue;
                    }

                    Console.Clear();
                    Rules();
                    PrintMovesOfPlayer(playersMoves, position);
                    PrintScore(r, c, points);
                    PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                    Console.WriteLine();
                }
                else if (firstOrSecondPlayer == "second")
                {
                    SecondPlayerPosition(position, playersMoves, ref isPlayed);
                    if (!isPlayed)
                    {
                        Console.WriteLine("That move is already played, please chose again.");
                        count--;
                        continue;
                    }

                    Console.Clear();
                    Rules();
                    PrintMovesOfPlayer(playersMoves, position);
                    PrintScore(r, c, points);
                    PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                    Console.WriteLine();
                }

                if ((playersMoves[0] == 1 && playersMoves[1] == 1 && playersMoves[2] == 1) ||
                    (playersMoves[3] == 1 && playersMoves[4] == 1 && playersMoves[5] == 1) ||
                    (playersMoves[6] == 1 && playersMoves[7] == 1 && playersMoves[8] == 1) ||
                    (playersMoves[0] == 1 && playersMoves[4] == 1 && playersMoves[8] == 1) ||
                    (playersMoves[2] == 1 && playersMoves[4] == 1 && playersMoves[6] == 1) ||
                    (playersMoves[0] == 1 && playersMoves[3] == 1 && playersMoves[6] == 1) ||
                    (playersMoves[1] == 1 && playersMoves[4] == 1 && playersMoves[7] == 1) ||
                    (playersMoves[2] == 1 && playersMoves[5] == 1 && playersMoves[8] == 1))
                {
                    firstPlayerPoints++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("First player won.");
                    Console.WriteLine("If you wanna play again press - y, any other button will stop the game.");
                    play = Console.ReadKey(true);
                    if (play.KeyChar == 'y')
                    {
                        Console.Clear();
                        Rules();
                        CreatingAField();
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        playersMoves = new int[9];
                        count--;
                        continue;
                    }
                    else
                    {
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    }

                }
                else if ((playersMoves[0] == 2 && playersMoves[1] == 2 && playersMoves[2] == 2) ||
                    (playersMoves[3] == 2 && playersMoves[4] == 2 && playersMoves[5] == 2) ||
                    (playersMoves[6] == 2 && playersMoves[7] == 2 && playersMoves[8] == 2) ||
                    (playersMoves[0] == 2 && playersMoves[4] == 2 && playersMoves[8] == 2) ||
                    (playersMoves[2] == 2 && playersMoves[4] == 2 && playersMoves[6] == 2) ||
                    (playersMoves[0] == 2 && playersMoves[3] == 2 && playersMoves[6] == 2) ||
                    (playersMoves[1] == 2 && playersMoves[4] == 2 && playersMoves[7] == 2) ||
                    (playersMoves[2] == 2 && playersMoves[5] == 2 && playersMoves[8] == 2))
                {
                    secondPlayerPoints++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Second player won.");
                    Console.WriteLine("If you wanna play again press - y, any other button will stop the game.");
                    play = Console.ReadKey(true);
                    if (play.KeyChar == 'y')
                    {
                        Console.Clear();
                        Rules();
                        CreatingAField();
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        playersMoves = new int[9];
                        count--;
                        continue;
                    }
                    else
                    {
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        break;
                    }

                }
                else if (playersMoves[0] != 0 && playersMoves[1] != 0 && playersMoves[2] != 0 &&
                    playersMoves[3] != 0 && playersMoves[4] != 0 && playersMoves[5] != 0 &&
                    playersMoves[6] != 0 && playersMoves[7] != 0 && playersMoves[8] != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Nobody won.");
                    Console.WriteLine("If you wanna play again press - y, any other button will stop the game.");
                    play = Console.ReadKey(true);
                    if (play.KeyChar == 'y')
                    {
                        Console.Clear();
                        Rules();
                        CreatingAField();
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        playersMoves = new int[9];
                        count--;
                        continue;
                    }
                    else
                    {
                        PrintScore(r, c, points);
                        PrintPlayersPoints(r, c, firstPlayerPoints, secondPlayerPoints);
                        Console.WriteLine();
                        break;
                    }

                }

=======
                    FirstPlayerPosition(name, position);
                    PrintMovesOfPlayer(row, col, matrix, position, firstOrSecondPlayer, name);


                }
                else if (firstOrSecondPlayer == "second")
                {
                    SecondPlayerPosition(name, position);
                    PrintMovesOfPlayer(row, col, matrix, position, firstOrSecondPlayer, name);


                }

                Console.WriteLine();
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
            }

        }

<<<<<<< HEAD
        private static void PrintScore(int r, int c, string points)
        {
            r = 20;
            c = 6;
            points = "Score: ";
            Console.SetCursorPosition(r, c);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(points);
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void PrintPlayersPoints(int r, int c, int firstPlayerPoints, int secondPlayerPoints)
        {
            r = 27;
            c = 6;
            Console.SetCursorPosition(r, c);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{firstPlayerPoints} - ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{secondPlayerPoints}");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void Rules()
        {
            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("The rules are simple: first player play only with X, second play with O.");
            Console.WriteLine("First player make line or diagonal of 3 consecutive X or O wins.");
            Console.WriteLine("To choose the player where he plays, enter 2 numbers: 1st for a row, 2nd for a cell with space between them.");
            Console.WriteLine();
        }

        private static void PrintMovesOfPlayer(int[] playersMoves, int[] position)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write(" ___ ___ ___");
                }

                if (i > 0)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j == 0 || j == 3 || j == 6)
                        {
                            Console.Write("|");
                        }

                        if (playersMoves[j] == 0)
                        {
                            Console.Write("___");
                        }
                        else if (playersMoves[j] == 1)
                        {
                            Console.Write("_X_");
                        }
                        else if (playersMoves[j] == 2)
                        {
                            Console.Write("_O_");
                        }

                        Console.Write("|");
                        if (j == 2 || j == 5 || j == 8)
                        {
                            Console.WriteLine();
                        }

                    }

                    Console.WriteLine();
=======
        private static void PrintMovesOfPlayer(int row, int col, int[,] matrix, int[] position, string firstOrSecondPlayer, List<string> name)
        {
            row = position[0] - 1;
            col = position[1] - 1;
            matrix[0, 0] = matrix[row, col];

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1)
                    {
                        Console.Write(" ___ ___ ___");
                        break;
                    }

                    Console.Write($"|");
                    if (j == 4)
                    {
                        break;
                    }

                    if (i - 2 == row && j - 1 == col)
                    {
                        Console.Write($"_{name[0]}_");
                        name.RemoveAt(0);
                    }
                    else
                    {
                        Console.Write($"___");
                    }
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

                Console.WriteLine();
            }

        }

        private static void CreatingAField()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1)
                    {
                        Console.Write(" ___ ___ ___");
                        break;
                    }

                    Console.Write($"|");
                    if (j == 4)
                    {
                        break;
                    }

                    Console.Write($"___");
                }

                Console.WriteLine();
            }
<<<<<<< HEAD

        }

        private static void SecondPlayerPosition(int[] position, int[] playersMoves, ref bool isPlayed)
=======
        }

        private static void SecondPlayerPosition(List<string> name, int[] position)
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
        {
            if (position[0] == 1)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[0] == 0)
                    {
                        playersMoves[0] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[1] == 0)
                    {
                        playersMoves[1] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[2] == 0)
                    {
                        playersMoves[2] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }
            else if (position[0] == 2)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[3] == 0)
                    {
                        playersMoves[3] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[4] == 0)
                    {
                        playersMoves[4] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[5] == 0)
                    {
                        playersMoves[5] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }
            else if (position[0] == 3)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[6] == 0)
                    {
                        playersMoves[6] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[7] == 0)
                    {
                        playersMoves[7] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[8] == 0)
                    {
                        playersMoves[8] = 2;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }

        }

<<<<<<< HEAD
        private static void FirstPlayerPosition(int[] position, int[] playersMoves, ref bool isPlayed)
=======
        private static void FirstPlayerPosition(List<string> name, int[] position)
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
        {
            if (position[0] == 1)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[0] == 0)
                    {
                        playersMoves[0] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[1] == 0)
                    {
                        playersMoves[1] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[2] == 0)
                    {
                        playersMoves[2] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }
            else if (position[0] == 2)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[3] == 0)
                    {
                        playersMoves[3] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[4] == 0)
                    {
                        playersMoves[4] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[5] == 0)
                    {
                        playersMoves[5] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }
            else if (position[0] == 3)
            {
                if (position[1] == 1)
                {
<<<<<<< HEAD
                    if (playersMoves[6] == 0)
                    {
                        playersMoves[6] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 2)
                {
                    if (playersMoves[7] == 0)
                    {
                        playersMoves[7] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

                }
                else if (position[1] == 3)
                {
                    if (playersMoves[8] == 0)
                    {
                        playersMoves[8] = 1;
                        isPlayed = true;
                    }
                    else
                    {
                        isPlayed = false;
                    }

=======
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                }

            }

        }

<<<<<<< HEAD
        private static void CheckRangeOfNumbers(int[] position, ref bool isRange)
=======
        private static void CheckRangeOfNumbers(int[] position, int count, ref bool isRange)
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
        {

            if (position[0] < 1 || position[0] > 3 || position[1] < 1 || position[1] > 3)
            {
                Console.WriteLine("One or two of numbers you chose is not in range 1 to 3.");
<<<<<<< HEAD
                Console.WriteLine("Please chose again.");
=======
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
                isRange = false;
            }
            else
            {
                isRange = true;
            }

        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 90570dcb0e5b62dcf423cca1ca1df48e573ca030
