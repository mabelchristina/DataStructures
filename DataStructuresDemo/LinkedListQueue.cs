using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class LinkedListQueue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head= node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next= node;
            }
            Console.WriteLine("{0} is inserted into Queue", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if(this.head==null)
            {
                Console.WriteLine("Queue is empty, deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is element dequeue ", this.head.data);
            this.head = this.head.next;
        }
    }
}
