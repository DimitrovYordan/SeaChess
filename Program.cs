using System;
using System.Collections.Generic;
using System.Linq;

namespace SeaChess1._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("The rules are simple: first player play only with X, second play with O.");
            Console.WriteLine("First player make line or diagonal of 3 consecutive X or O wins.");
            Console.WriteLine("To choose the player where he plays, enter 2 numbers: 1st for a row, 2nd for a cell with space between them.");
            Console.WriteLine();
            CreatingAField();

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
                    if (!isRange)
                    {
                        isRange = true;
                        continue;
                    }
                    count++;
                }
                else
                {
                    firstOrSecondPlayer = "second";
                    Console.WriteLine("Second player!");
                    position = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    CheckRangeOfNumbers(position, count, ref isRange);
                    if (!isRange)
                    {
                        isRange = true;
                        continue;
                    }
                    count++;
                }

                if (firstOrSecondPlayer == "first")
                {
                    FirstPlayerPosition(name, position);
                    PrintMovesOfPlayer(row, col, matrix, position, firstOrSecondPlayer, name);


                }
                else if (firstOrSecondPlayer == "second")
                {
                    SecondPlayerPosition(name, position);
                    PrintMovesOfPlayer(row, col, matrix, position, firstOrSecondPlayer, name);


                }

                Console.WriteLine();
            }

        }

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
        }

        private static void SecondPlayerPosition(List<string> name, int[] position)
        {
            if (position[0] == 1)
            {
                if (position[1] == 1)
                {
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
                }

            }
            else if (position[0] == 2)
            {
                if (position[1] == 1)
                {
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
                }

            }
            else if (position[0] == 3)
            {
                if (position[1] == 1)
                {
                    name.Add("O");
                }
                else if (position[1] == 2)
                {
                    name.Add("O");
                }
                else if (position[1] == 3)
                {
                    name.Add("O");
                }

            }

        }

        private static void FirstPlayerPosition(List<string> name, int[] position)
        {
            if (position[0] == 1)
            {
                if (position[1] == 1)
                {
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
                }

            }
            else if (position[0] == 2)
            {
                if (position[1] == 1)
                {
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
                }

            }
            else if (position[0] == 3)
            {
                if (position[1] == 1)
                {
                    name.Add("X");
                }
                else if (position[1] == 2)
                {
                    name.Add("X");
                }
                else if (position[1] == 3)
                {
                    name.Add("X");
                }

            }

        }

        private static void CheckRangeOfNumbers(int[] position, int count, ref bool isRange)
        {

            if (position[0] < 1 || position[0] > 3 || position[1] < 1 || position[1] > 3)
            {
                Console.WriteLine("One or two of numbers you chose is not in range 1 to 3.");
                isRange = false;
            }
            else
            {
                isRange = true;
            }

        }

    }
}
