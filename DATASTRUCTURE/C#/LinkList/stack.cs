using System;

namespace LinkList
{
    public class stack
    {

        Node head;
        public stack(int data)
        {
            
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            
            newNode.next = head;
            newNode = head;
        }
        public void pop()
        {
             Node n = head.next;
           head = n;
        }
    }
}