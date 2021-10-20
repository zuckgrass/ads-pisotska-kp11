using System;
using static System.Console;
using static System.Math;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double x = rnd.NextDouble() * 100 - 50;
            double y = rnd.NextDouble() * 100 - 50;
            double z = rnd.NextDouble() * 100 - 50;
            double a = 0, b = 0, n = 0, l = 0;
            double m = x * x + x * y * y + x * x * z;
            if (m > 0)
            {
                a = 1 + Sin(x) / Sqrt(m);
            }
            if (a != 0)
            {
                n = y + z / a;
            }
            if (n != 0)
            {
                l = x + a / n;
            }
            if (l != 0)
            {
                b = Log(a * a * a + x * x) / l;
            }
            else
            {
                WriteLine("Error");
            }
            WriteLine("a=" + a);
            WriteLine("b=" + b);
        }
    }
}
