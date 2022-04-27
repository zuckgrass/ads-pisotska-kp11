using System;
using static System.Console;

class Program
{
    static void Main()
    {
        while (true)
        {
            WriteLine("Do you want to try test or customer regime?");
            string ans = ReadLine();
            if (ans == "test")
            {
                WriteLine("*****Test regime*****");
                WriteLine("initqueue");
                Write("Input data of the massive: ");
                WriteLine("1 2 3 4 5 6");
                string[] h = { "1", "2", "3", "4", "5", "6" };
                int[] test = initqueue(h);
                ShowQueue(test);
                WriteLine("dequeue");
                dequeue(test);
                WriteLine("enqueue");
                WriteLine("Input element: 6");
                enqueue(test, "6");
                WriteLine("enqueue");
                WriteLine("Input element: 1");
                enqueue(test, "1");
                WriteLine("destroyqueue");
                destroyqueue(test);
            }
            else if(ans=="customer")
            {
                WriteLine("*****Customer regime*****");
                Write("Input data of the massive: ");
                string[] text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
                    if (pr == false)
                    {
                        Write("Is not correct format. Input array: ");
                        text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    }
                    else
                        break;
                }
                int[] queue = initqueue(text);
                ShowQueue(queue);
                while (true)
                {
                    WriteLine("Commands: enqueue, dequeue, destroyqueue, initqueue");
                    Write("Input command: ");
                    string command = ReadLine();
                    if (command == "dequeue")
                        dequeue(queue);
                    else if (command == "enqueue")
                    {
                        Write("Input element: ");
                        string an = ReadLine();
                        enqueue(queue, an);
                    }
                    else if (command == "destroyqueue")
                        destroyqueue(queue);
                    else if (command == "initqueue")
                    {
                        Write("Input data of the massive: ");
                        string[] Text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        queue = initqueue(Text);
                        ShowQueue(queue);
                    }
                    else
                        WriteLine("Command isn't correct");
                }
            }
        }
    }
    static void dequeue(int[] queue)
    {
        if (isEmpty(queue))
        {
            while (true)
            {
                WriteLine("Queue is Empty. Would you like to try enqueue command? (Yes/No)");
                string answer = ReadLine();
                if (answer == "Yes" || answer == "yes")
                {
                    Write("Input element: ");
                    string an = ReadLine();
                    while (CheckInt(an) != true)
                    {
                        Write("Incorrect format. Input element: ");
                        an = ReadLine();
                    }
                    enqueue(queue, an);
                    ShowQueue(queue);
                    break;
                }
                else if (answer == "no" || answer == "No")
                    return;
            }
        }
        else
        {
            for (int i = 0; i < queue.Length - 1; i++)
            {
                queue[i] = queue[i + 1];
            }
            Array.Clear(queue, queue.Length - 1, 1);
            ShowQueue(queue);
        }
    }
    static void enqueue(int[] queue, string an)
    {
        if (isOver(queue))
        {
            WriteLine("Queue is over");
            for (int i = 0; i < queue.Length; i++)
                dequeue(queue);
        }
        while (CheckInt(an) != true)
        {
            Write("Incorrect format. Input element: ");
            an = ReadLine();
        }
        for (int i=0; i<queue.Length; i++)
        {
            if(queue[i] == 0)
            {
                if (int.Parse(an) == 0)
                    Exit();
                queue[i] = int.Parse(an);
                break;
            }
        }
        ShowQueue(queue);
    }
    static void destroyqueue(int [] queue)
    {
        Array.Clear(queue, 0, queue.Length);
        ShowQueue(queue);
    }
    static int [] initqueue(string [] Text)
    {
        while (true)
        {
            bool pr = true;
            for (int i = 0; i < Text.Length; i++)
            {
                int result;
                if (int.TryParse(Text[i], out result) == false)
                {
                    pr = false;
                }
            }
            if (pr == false)
            {
                Write("Is not correct format. Input array: ");
                Text = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            else
                break;
        }
        int[] queue = new int[Text.Length];
        for (int i = 0; i < Text.Length; i++)
        {
            queue[i] = int.Parse(Text[i]);
        }
        return queue;
    }
    static void Exit()
    {
        Environment.Exit(0);
    }
    static bool isOver(int[] queue)
    {
        if (queue[queue.Length - 1] != 0)
            return true;
        else
            return false;
    }
    static bool isEmpty(int[] queue)
    {
        if (queue[0] != 0)
            return false;
        else
            return true;
    }
    static void ShowQueue(int[] queue)
    {
        for (int i = 0; i < queue.Length; i++)
        {
            if (queue[i] != null)
                Write(queue[i] + " ");
            else
                break;
        }
        WriteLine();
    }
    static bool CheckInt(string an)
    {
        int result;
        bool pr = true;
        if (int.TryParse(an, out result) == false)
        {
            pr = false;
        }
        return pr;
    }
}