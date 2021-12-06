using System;
using static System.Console;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            bool sorted = true;
            string temp;
            string [] priklad=new string [10] { "1", "99", "100", "76", "123", "15", "114", "1980", "1040", "3" };
            Colour(priklad, 10);
            for (int i = 0; i < 10; i++)
            {
                sorted = true;
                for (int j = 1; j < 10 - i; j++)
                {
                    if (priklad[j - 1].Length < priklad[j].Length)
                    {
                        temp = priklad[j - 1];
                        priklad[j - 1] = priklad[j];
                        priklad[j] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
            Write("\n");
            Colour(priklad, 10);
            for (int i = 0; i < 10; i++)
            {
                sorted = true;
                for (int j = 1; j < 10 - i; j++)
                {
                    if (priklad[j - 1].Length == priklad[j].Length && int.Parse(priklad[j - 1]) > int.Parse(priklad[j]))
                    {
                        temp = priklad[j - 1];
                        priklad[j - 1] = priklad[j];
                        priklad[j] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
            Write("\n");
            Colour(priklad, 10);
            Write("\n");
            Write("Input the length of the massive: ");
            int n = int.Parse(ReadLine());
            int[] arr = new int[n];
            string[] str = new string[n];

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 10000);
                str[i] = arr[i].ToString();
            }
            Colour(str, n);
            for (int i = 0; i < n; i++)
            {
                sorted = true;
                for (int j = 1; j < n - i; j++)
                {
                    if (str[j - 1].Length < str[j].Length)
                    {
                        temp = str[j - 1];
                        str[j - 1] = str[j];
                        str[j] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
            Write("\n");
            Colour(str, n);
            for (int i = 0; i < n; i++)
            {
                sorted = true;
                for (int j = 1; j < n - i; j++)
                {
                    if (str[j - 1].Length == str[j].Length && int.Parse(str[j - 1]) > int.Parse(str[j]))
                    {
                        temp = str[j - 1];
                        str[j - 1] = str[j];
                        str[j] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
            Write("\n");
            Colour(str, n);
        }

        static void Colour(string [] str, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (str[i].Length==1)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (str[i].Length == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if(str[i].Length==3)
                {
                    Console.BackgroundColor =ConsoleColor.Green;
                }
                else if(str[i].Length==4)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                Write($"{str[i],10}");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}