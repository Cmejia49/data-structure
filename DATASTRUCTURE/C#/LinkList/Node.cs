using System;

namespace LinkList
{

    public class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}