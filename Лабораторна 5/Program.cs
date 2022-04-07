using System;
using static System.Console;
using System.IO;

class Program
{
    static void Main()
    {
        WriteLine("Commands: keyboard input, generate array, test, exit");
        Write("Input command: ");
        int counter = 0;
        while (true)
        {
            if (counter != 0)
            {
                WriteLine("Commands: keyboard input, generate array, test, exit");
                Write("Input command: ");
            }
            counter = 1;
            string[] text;
            string user=ReadLine();
            if(user== "keyboard input")
            {
                Write("Input array: ");
                text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                while (true)
                {
                    bool pr = true;
                    for (int i = 0; i < text.Length; i++)
                    {
                        int result;
                        if (int.TryParse(text[i], out result) == false)
                        {
                            pr = false;
                        }
                    }
                    if (text.Length % 2 != 0 || pr == false)
                    {
                        Write("Is not correct format. Input array: ");
                        text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    }
                    else
                    {
                        break;
                    }
                }
                Sorting(text);
            }
            else if(user== "generate array")
            {
                Random rnd = new Random();
                int n = rnd.Next(1, 11) * 2;
                text= new string[n];
                for (int i=0; i<n; i++)
                {
                    text[i] = rnd.Next(1, 10).ToString();
                }
                Sorting(text);
            }
            else if(user== "test")
            {
                string[] test = { "2", "1", "9", "2", "3", "1", "9", "5", "3", "1", "4", "8", "6", "5", "8", "3", "4", "1", "8", "9" };
                Sorting(test);
            }
            else if (user == "exit")
            {
                return;
            }
            else
            {
                Write("Try another command: ");
            }
        }
    }
    static void Sorting(string [] text)
    {
        int[] nums = new int[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            nums[i] = int.Parse(text[i]);
        }
        int max1 = 0;
        for (int i = 0; i < nums.Length / 2; i++)
        {
            if (nums[i] > max1)
                max1 = nums[i];
        }
        int max2 = 0;
        for (int i = nums.Length / 2; i < nums.Length; i++)
        {
            if (nums[i] > max2)
                max2 = nums[i];
        }
        int[] count1= new int[max1 + 1];
        int[] count2 = new int[max2 + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length / 2)
                count1[nums[i]]++;
            else
                count2[nums[i]]++;
        }
        for (int i = 1; i < count1.Length; i++)
        {
            count1[i] += count1[i - 1];
        }
        for (int i = 1; i < count2.Length; i++)
        {
            count2[i] += count2[i - 1];
        }
        int[] sorted1 = new int[nums.Length / 2];
        int[] sorted2 = new int[nums.Length / 2];
        for (int i = nums.Length / 2 - 1; i >= 0; i--)
        {
            for (int j = 0; j < nums.Length / 2 - 1; j++)
            {
                if (sorted1[count1[nums[i]] - 1 - j] == 0)
                {
                    sorted1[count1[nums[i]] - 1 - j] = nums[i];
                    break;
                }
            }
        }
        for (int i = nums.Length - 1; i >= nums.Length / 2; i--)
        {
            for (int j = 0; j < nums.Length / 2 - 1; j++)
            {
                if (sorted2[(nums.Length / 2 - 1) - (count2[nums[i]] - 1 - j)] == 0)
                {
                    sorted2[(nums.Length / 2 - 1) - (count2[nums[i]] - 1 - j)] = nums[i];
                    break;
                }
            }
        }
        Colour(nums);
        WriteLine();
        for (int i = 0; i < nums.Length / 2; i++)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Write(sorted1[i] + " ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        for (int i = 0; i < nums.Length / 2; i++)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Write(sorted2[i] + " ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        WriteLine();
    }
    static void Colour(int [] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length / 2)
                Console.BackgroundColor = ConsoleColor.Blue;
            else
                Console.BackgroundColor = ConsoleColor.Red;
            Write(arr[i] + " ");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}