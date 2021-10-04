using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class LinkedListDemo
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into LL", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if(this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if(this.head==null)
            {
                return newestNode;
            }
            if(position==0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count<position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        public void RemoveFirstNode()
        {
            if(this.head==null)
            {
                head = null;
            }
            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
            {
                this.head = null; 
            }
            Node NewNode = head;
            while(NewNode.next.next!=null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            NewNode = head;
        }
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
    }
}
