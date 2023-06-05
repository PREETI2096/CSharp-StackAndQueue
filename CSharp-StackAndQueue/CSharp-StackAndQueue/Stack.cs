using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_StackAndQueue
{
    internal class Stack
    {
        MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
        public void push(Node<int> node)
        {
            myLinkedList.addFirst(node);
            Console.WriteLine("Linked list after push operation");
            myLinkedList.printLikedList();
        }

        public void pop()
        {
            myLinkedList.deleteFirst();
            Console.WriteLine("Linked list after pop operation");
            myLinkedList.printLikedList();
        }
    }
}
