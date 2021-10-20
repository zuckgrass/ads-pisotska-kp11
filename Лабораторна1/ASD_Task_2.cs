using System;
using static System.Console;
using static System.Math;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, a = 0, b = 0, c = 0, d = 0;
                for (int i = 10; i < 100; i++)
                {
                    num = i;
                    a = num / 10;
                    b = num % 10;
                    if (a * a + b * b == num)
                    {
                        WriteLine(num);
                    }
                }
                for (int i = 100; i < 1000; i++)
                {

                    num = i;
                    a = num / 100;
                    b = (num % 100) / 10;
                    c = num - a * 100 - b * 10;
                    if (Pow(a, 3) + Pow(b, 3) + Pow(c, 3) == num)
                    {
                        WriteLine(num);
                    }
                }
                for (int i = 1000; i < 10000; i++)
                {
                    num = i;
                    a = num / 1000;
                    b = (num - a * 1000) / 100;
                    c = (num - a * 1000 - b * 100) / 10;
                    d = num - a * 1000 - b * 100 - c * 10;
                    if (Pow(a, 4) + Pow(b, 4) + Pow(c, 4) + Pow(d, 4) == num)
                    {
                        WriteLine(num);
                    }
                }
            
            
        }
    }
}

