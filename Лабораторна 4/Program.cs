using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using lab4;

class Program
{
    static void Main(string[] args)
    {
        DLList dl = new DLList();
        WriteLine("Available commands:");
        WriteLine("AddFirst");
        WriteLine("AddLast");
        WriteLine("AddAtPosition");
        WriteLine("DeleteFirst");
        WriteLine("DeleteLast");
        WriteLine("DeleteAtPosition");
        WriteLine("Task");
        WriteLine("Exit");
        while (true)
        {
            Write("Input your command: ");
            string com = ReadLine();
            if(com== "AddFirst")
            {
                Write("Input data of the node: ");
                int data=int.Parse(ReadLine());
                dl.AddFirst(data);
                dl.Print();
            }
            else if(com== "AddLast")
            {
                Write("Input data of the node: ");
                int data = int.Parse(ReadLine());
                dl.AddLast(data);
                dl.Print();
            }
            else if( com== "AddAtPosition")
            {
                Write("Input data of the node: ");
                int data = int.Parse(ReadLine());
                Write("Input position of the node: ");
                int position = int.Parse(ReadLine());
                dl.AddAtPosition(data, position);
                dl.Print();
            }
            else if(com== "DeleteFirst")
            {
                dl.DeleteFirst();
                dl.Print();
            }
            else if(com== "DeleteLast")
            {
                dl.DeleteLast();
                dl.Print();
            }
            else if(com== "DeleteAtPosition")
            {
                Write("Input position of the node: ");
                int position = int.Parse(ReadLine());
                dl.DeleteAtPosition(position);
                dl.Print();
            }
            else if(com == "Task")
            {
                Write("Input data of the node: ");
                int data = int.Parse(ReadLine());
                dl.Task(data);
                dl.Print();
            }
            else if (com == "Exit")
            {
                break;
            }
            else
            {
                WriteLine("Try another command");
            }
        }
    }
}