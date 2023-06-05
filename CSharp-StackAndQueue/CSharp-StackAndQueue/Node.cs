﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_StackAndQueue
{
    internal class Node<T>
    {
        public T Key
        { get; set; }
        public Node<T> Next
        { get; set; }

        public Node(T key)
        {
            Key = key;
        }
    }
}

