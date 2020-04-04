using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Doubly_LinkedList<int> doubly_LinkedList = new Doubly_LinkedList<int>();

            for(int i =1;i<=3;i++)
            doubly_LinkedList.InsertAtHead(i);

            doubly_LinkedList.InsertAtEnd(0);
            doubly_LinkedList.InsertAtEnd(-1);

            doubly_LinkedList.PrintList();

             
            Console.WriteLine();
            Console.WriteLine("Size: " + doubly_LinkedList.Size);


            Console.WriteLine();

            doubly_LinkedList.DeleteAtHead();

            doubly_LinkedList.DeleteAtTail();

            doubly_LinkedList.PrintList();


           

            Console.ReadLine();
        }
    }
}
