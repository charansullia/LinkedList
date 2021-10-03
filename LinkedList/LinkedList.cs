using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        internal void add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next!=null)
                {
                   temp= temp.next;
                }
                   temp.next = node;
            }
            Console.WriteLine("{0} inserted to LinkedList",node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
        internal Node RemovaLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            Console.WriteLine("{0} Removed LatNode From LinkedList");
            return head;
        }

    }
}
