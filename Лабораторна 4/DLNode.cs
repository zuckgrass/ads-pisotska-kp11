using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class DLNode
    {
        public int data;
        public DLNode prev;
        public DLNode next;
        public DLNode(int data)
        {
            this.data = data;
        }
    }
}
