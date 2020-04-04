using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Doubly_LinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node nextNode;
            public Node prevNode;
        }

        Node headNode; 
        Node tailNode;

        public int Size { get; set; }

        public Doubly_LinkedList()
        {
            headNode = null;
            tailNode = null;
            Size = 0;
        }

        public Boolean IsEmpty()
        {
            if (headNode == null && tailNode == null)
                return true;
            return false;
        }

        //getter for headNode
        public Node GetHeadNode()
        {
            return headNode;
        }

        //getter for tailNode
        public Node GetTailNode()
        {
            return tailNode;
        }


        public void InsertAtHead(T data)
        {
            Node tmpNode = new Node();
            tmpNode.data = data;

            if (IsEmpty())
            {
                headNode = tmpNode;
                tailNode = tmpNode;
            }
            else
            {
                headNode.prevNode = tmpNode;
                tmpNode.nextNode = headNode;
                headNode = tmpNode;
            }
            Size++;

        }

        public void InsertAtEnd(T data)
        {
            Node tmpNode = new Node();
            tmpNode.data = data;

            if (IsEmpty())
            {
                headNode = tmpNode;
                tailNode = tmpNode;
            }
            else
            {
                tailNode.nextNode = tmpNode;
                tmpNode.prevNode = tailNode;
                tailNode = tmpNode;
            }
            Size++;
        }

        public void DeleteAtHead()
        {
            if (IsEmpty())
            {
                return;
            }
            if (headNode.nextNode == null)
            {
                tailNode = null;
            }
            else
            {
                headNode = headNode.nextNode;
                headNode.prevNode = null;


            }

            Size--;
            Console.Write("");

        }
        public void DeleteAtTail()
        {
            if (IsEmpty())
                return;
            if (tailNode.prevNode == null)
            {
                headNode = null;
            }
            else
            {
                tailNode = tailNode.prevNode;
                tailNode.nextNode = null;
            }
            Size--;
            
        }
        public void DeleteByValue(T data)
        {
            if (IsEmpty())
                return;

            if (headNode.data.Equals(data))
            {
                DeleteAtHead();
            }
            else
            {
                Node tmp = headNode;
                while (tmp != null)
                {
                    if (tmp.data.Equals(data))
                    {
                        Node prevNode = tmp.prevNode;
                        prevNode.nextNode = tmp.nextNode;

                        Node nextNode = tmp.nextNode;
                        if (nextNode != null)
                            nextNode.prevNode = prevNode;

                        Size--;

                        return;
                    }
                    tmp = tmp.nextNode;
                }
            }
        }
        public void PrintList()
        {
            if (IsEmpty())
                return;
            Node node = headNode;
            Console.Write("List : null <- ");

            //while (node != null)
            //{
            //    Console.Write(node.data.ToString() + " <-> ");
            //    node = node.nextNode;
            //}



            while (node.nextNode != null)
            {
                Console.Write(node.data.ToString() + " <-> ");
                node = node.nextNode;
            }

            Console.Write(node.data.ToString() + " -> null");

        }

    }
}
