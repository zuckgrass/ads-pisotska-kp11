using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class DLList
    {
        public DLNode tail;
        public void AddFirst(int data)
        {
            if (tail == null)
            {
                tail = new DLNode(data);
                tail.next = tail;
                tail.prev = tail;
            }
            else
            {
                DLNode current = new DLNode(data);
                tail.next.prev = current;
                current.next = tail.next;
                tail.next = current;
                current.prev = tail;
            }
        }
        public void AddLast(int data)
        {
            if (tail == null)
            {
                tail = new DLNode(data);
                tail.next = tail;
                tail.prev = tail;
            }
            else
            {
                DLNode current = new DLNode(data);
                current.next = tail.next;
                current.prev = tail;
                tail.next.prev = current;
                tail.next = current;
                tail = current;
            }
        }
        public void AddAtPosition(int data, int position)
        {
            if (tail == null)
            {   
                tail = new DLNode(data);
                tail.next = tail;
                tail.prev = tail;
            }
            else
            {
                DLNode current = tail.next;
                DLNode node = new DLNode(data);

                int i = 1;
                while (current.next != tail.next)
                {
                    current = current.next;
                    i++;
                }
                if (position == i + 1)
                {
                    AddLast(data);
                }
                else if (position > i + 1)
                {
                    AddFirst(data);
                }
                else
                {
                    current = tail.next;
                    i = 1;
                    while (i != position)
                    {
                        current = current.next;
                        i++;
                    }
                    node.prev = current.prev;
                    node.next = current;
                    current.prev.next = node;
                    current.prev = node;
                }
            }
        }
        public void DeleteFirst()
        {
            if (tail == null)
            {
                Console.WriteLine("Empty");
            }
            else if (tail.next == tail)
            {
                tail = null;
                Console.WriteLine("Empty");
            }
            else
            {
                DLNode current = tail.next;
                tail.next = current.next;
                current.next.prev = tail;
            }
        }
        public void DeleteLast()
        {
            if (tail == null)
            {
                Console.WriteLine("Empty");
            }
            else if (tail.next == tail)
            {
                tail = null;
                Console.WriteLine("Empty");
            }
            else
            {
                DLNode current = tail;
                current = current.prev;
                current.next = tail.next;
                tail.next.prev = current;
                tail = tail.prev;
            }
        }
        public void DeleteAtPosition(int position)
        {
            if (tail == null)
            {
                Console.WriteLine("Empty");
            }
            else if(tail.next == tail)
            {
                tail = null;
                Console.WriteLine("Empty");
            }
            else
            {
                DLNode current = tail.next;
                int i = 1;
                while (current.next != tail.next)
                {
                    current = current.next;
                    i++;
                }
                if (position == i)
                {
                    DeleteLast();
                }
                else if (position == 1)
                {
                    DeleteFirst();
                }
                else if(position >=i+1)
                {
                   DeleteFirst(); 
                }
                else
                {
                    current = tail.next;
                    i = 1;
                    while (i != position)
                    {
                        current = current.next;
                        i++;
                    }
                    current.prev.next = current.next;
                    current.next.prev=current.prev;
                }
            }
        }
        public void Task(int data)
        {
            if (tail == null)
            {
                tail = new DLNode(data);
                tail.next = tail;
                tail.prev = tail;
            }
            else
            {
                DLNode current = tail.next;
                int i = 1;
                while (current.next != tail.next)
                {
                    current = current.next;
                    i++;
                }
                if (i % 2 == 0)
                {
                    AddAtPosition(data, i / 2 + 1);
                }
                else
                {
                    AddFirst(data);
                }
            }
        }
        public void Print()
        {
            if (tail !=null)
            {
                DLNode current = tail.next;
                while (current.next != tail.next)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
                Console.WriteLine(current.data);
            }
        }
    }
}
