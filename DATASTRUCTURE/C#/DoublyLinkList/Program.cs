using System;

namespace DoublyLinkList
{

 public class Program
    {
        Node head;

  public void printList()
    {
        Node n = head;
        while (n != null) {
            Console.Write("|"+n.data );
            n = n.next;
        }
    }

    public void printReverse()
    {
        Node n = head;
        while(n.next != null){
            n = n.next;
        }
        while(n != null)
        {
           Console.Write("|"+n.data);
            n = n.prev;
        }
    }

        static void Main(string[] args)
        {
                Program list = new Program();

                list.head = new Node(1);
                Node second = new Node(2);
                Node third = new Node(3);
                list.head.prev = null;
                list.head.next = second;
                second.next = third;
                third.prev = second;
                second.prev = list.head;

                Console.WriteLine(third.prev.data);
                list.printList();
                        Console.WriteLine();
                list.printReverse();
        }
    }
}
