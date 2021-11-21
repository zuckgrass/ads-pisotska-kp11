using System;
using static System.Console;
using static System.Math;

namespace ASD
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Inpu M: "); int m = int.Parse(ReadLine());
            Write("Inpu N: "); int n = int.Parse(ReadLine());
            if (n % 2 != 0)
            {
                WriteLine("Try again");
            }
            else
            {
                Random rnd = new Random();
                int[,] matrix = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = rnd.Next(1, 10);
                        Write($"{matrix[i, j],3}|");
                    }
                    Write("\n");
                }
                int dirX = -1;
                int dirY = -1;
                int x = n - 1;
                int y = 1;
                int max1 = matrix[x, y - 1];
                WriteLine(matrix[x, y - 1]);
                for (int i = 0; i < m + 2; i++)
                {
                    for (int j = 1; j < n / 2; j++)
                    {
                        if (y >= 0 && y < m)
                        {
                            if (max1 < matrix[x, y])
                            {
                                max1 = matrix[x, y];
                            }
                            WriteLine(matrix[x, y]);
                        }
                        x += dirX;
                        y += dirY;
                    }
                    if (y >= 0 && y < m)
                    {
                        if (matrix[x, y] > max1)
                        {
                            max1 = matrix[x, y];
                        }
                        WriteLine(matrix[x, y]);
                    }
                    y++;
                    dirX = -dirX;
                    dirY = -dirY;
                }
                int max2 = max1;
                int a = 0;
                int N = n / 2 - 1;
                for (int i = 0; i < n / 2; i++)
                {
                    if (i % 2 == 1)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            max2 = max1;
                            if (matrix[N, j] > max2)
                            {
                                max2 = matrix[N, j];
                                WriteLine($"[{N},{j}]");
                                a = max2;
                            }
                            WriteLine(matrix[N, j]);
                        }
                    }
                    else
                    {
                        for (int j = m - 1; j >= 0; j--)
                        {
                            max2 = max1;
                            if (matrix[N, j] > max2)
                            {
                                max2 = matrix[N, j];
                                WriteLine($"[{N},{j}]");
                                a = max2;
                            }
                            WriteLine(matrix[N, j]);
                        }
                    }
                    N--;
                }
                if (a == 0)
                {
                    WriteLine("There is no element bigger than maximum of the first part");
                }
            }
        }
    }
}
