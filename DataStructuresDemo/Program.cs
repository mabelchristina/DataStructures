using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListDemo linkedListDemo = new LinkedListDemo();
            //linkedListDemo.Add(56);
            //linkedListDemo.Add(30);
            //linkedListDemo.Add(70);
            //linkedListDemo.Display();
            //////linkedListDemo.AddInReverseOrder(70);
            //////linkedListDemo.AddInReverseOrder(30);
            //////linkedListDemo.AddInReverseOrder(56);
            ////linkedListDemo.InsertAtParticularPosition(1, 30);
            ////Console.WriteLine("After inserting at a particular position");
            ////linkedListDemo.Display();
            ////linkedListDemo.RemoveFirstNode();
            ////Console.WriteLine("After deleting firt node");
            ////linkedListDemo.Display();
            //linkedListDemo.RemoveLastNode();
            //Console.WriteLine("After deleting last node");
            //linkedListDemo.Display();
            //Console.WriteLine("Searching");
            //linkedListDemo.Search(30);
            //linkedListDemo.Display();

            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(56);
            //linkedListStack.push(30);
            //linkedListStack.push(70);
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
