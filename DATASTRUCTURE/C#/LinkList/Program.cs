using System;

namespace LinkList
{
    
    public class Program
    {
     Node head;

    public void push(int data)
    {
        Node newNode = new Node(data);

        newNode.next = head;
        head = newNode;
    }
    
    public void inserAt(int position, int data)
    {
        Node newNode = new Node(data);

        if(this.head == null)
        {
            if(position != 0)
            {
                return;
            }else{
                this.head = newNode;
            }
        }

        if(this.head != null && position == 0)
        {
            newNode.next = head;
            this.head = newNode;
            return;
        }
        Node curr = this.head;
        Node prev = null;
        int i = 0;
        while(i != position)
        {
            prev = curr;
            curr = curr.next;

            if(curr == null)
            {
                return;
            }
            i++;
        }

        newNode.next = curr;
        prev.next = newNode;
    }

    public void delete()
    {
        Node n = head;
        while(n.next.next != null)
        {
            n = n.next;
        }

      n.next = null;
    }

    public void deleteAt(int position)
    {
    
        if(head == null)
            return;


        if(position < 0)
        {
            return;
        }

        Node curr = head;
        Node prev = null;
        int i = 0;
        while(curr != null && i<position )
        {
            prev = curr;
            curr = curr.next;
            
            i++;
        }

        prev.next = curr.next;
    }

    public int search(int data)
    {
        Node n = head;
        int i = 0;
        while(n != null)
        {
                 i++;
            if(n.data == data)
            {
                return i;
            }
            n = n.next;
        }
        return -1;
    }

    public void sort()
    {
        Node n = head;
        Node n2 = null;

        while(n != null)
        {
            n2 = n.next;
            while(n2 != null)
            {
                if(n.data > n2.data)
                {
                    int temp = n.data;
                    n.data = n2.data;
                    n2.data = temp;
                }
                n2 = n2.next;
            }
            n = n.next;
        }
    }


    public void inserLast(int data)
    {
        Node n = head;
      Node newNode = new Node(data);
        while(n.next != null)
        {
         
            n = n.next;
        }
        n.next = newNode;
        newNode.next = null;
    }

    public void pop()
    {
            Node n = head.next;
           head = n;
    }
    public void printList()
    {
        Node n = head;
        while (n != null) {
            Console.Write("|"+n.data );
            n = n.next;
        }
    }
    //create stand queue
    public void queue(int data)
    {
         Node newNode = new Node(data);

        newNode.next = head;
        head = newNode;
    }
    public void deqeue()
    {
        Node n = head;
        while(n.next != null)
        {
            n = n.next;
        }
        n = null;
    }
        static void Main(string[] args)
        {
            Program list = new Program();
            /*
            list.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            list.head.next = second;
            second.next = third;
            */
            list.push(1);
            list.push(2);
            list.push(3);
            list.push(4);
            list.printList();
                   Console.WriteLine();
            Console.WriteLine("inertLast");
            list.inserLast(132);
            list.printList();
            list.delete();
            Console.WriteLine();
            Console.WriteLine("after delete");
            list.printList();

            list.inserAt(2,10);
            Console.WriteLine();
            Console.WriteLine("after insertion");
            list.printList();
            list.pop();
                 list.pop();
              Console.WriteLine();
            Console.WriteLine("after pop");
            list.printList();


                list.sort();
                  Console.WriteLine();
                  list.printList();
        }
    }
}
