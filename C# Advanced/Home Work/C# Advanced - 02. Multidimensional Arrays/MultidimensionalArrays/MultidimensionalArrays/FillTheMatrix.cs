using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            int[,] matrix = new int[num, num];
            int number = 1;

            switch (word)
            {
                case "a":
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            matrix[j, i] = number++;
                        }
                    }

                    break;

                case "b":
                    int counterB = 1;
                    bool isOdd = true;
                    for (int row = 0; row < num; row++)

                    {
                        if (isOdd)

                        {
                            for (int col = 0; col < num; col++)

                            {
                                matrix[col, row] = counterB++;
                            }
                        }
                        else
                        {
                            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                            {
                                matrix[col, row] = counterB++;
                            }

                        }

                        isOdd = !isOdd;
                    }


                    break;

                case "c":
                    for (int i = num - 1; i >= 0; i--)
                    {
                        int col = 0;
                        int row = i;

                        do
                        {
                            matrix[row, col] = number;
                            col++;
                            number++;
                            row++;
                        } while (row <= matrix.GetLength(0) - 1);
                    }
                    for (int j = 1; j < num; j++)
                    {
                        int col = j;
                        int row = 0;
                        do
                        {
                            matrix[row, col] = number;
                            col++;
                            number++;
                            row++;
                        } while (col <= matrix.GetLength(1) - 1);
                    }

                    break;
                case "d":
                    int row = 0;
                    int col = 0;

                    while (number <= matrix.Length)
                    {
                        // down
                        while (row < num && matrix[row, col] == 0)
                        {
                            matrix[row, col] = number;
                            row++;
                            number++;
                        }

                        row--;
                        col++;

                        // right
                        while (col < num && matrix[row, col] == 0)
                        {
                            matrix[row, col] = number;
                            col++;
                            number++;
                        }

                        row--;
                        col--;

                        // up
                        while (row >= 0 && matrix[row, col] == 0)
                        {
                            matrix[row, col] = number;
                            row--;
                            number++;
                        }

                        row++;
                        col--;

                        // left
                        while (col >= 0 && matrix[row, col] == 0)
                        {
                            matrix[row, col] = number;
                            col--;
                            number++;
                        }

                        row++;
                        col++;
                    }
                    break;
            }




            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != num - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
