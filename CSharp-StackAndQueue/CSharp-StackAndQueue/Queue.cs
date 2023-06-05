using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_StackAndQueue
{
    internal class Queue
    {
        MyLinkedList<int> myQueue = new MyLinkedList<int>();
        public void enqueue(Node<int> node)
        {
            myQueue.addFirst(node);
            Console.WriteLine("My Queue after enqueue");
            myQueue.printLikedList();
        }
    }
}
