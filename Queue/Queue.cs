using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Queue
    {
        // Queue fields...
        int front;
        int rear;
        public int[] arr;

        // Queue constructor
        public Queue(int QueueLength)
        {
            this.front = -1;
            this.rear = -1;
            this.arr = new int[QueueLength];
        }

        // enqueue method
        public void enqueue(int item) {
            if(this.isFull())
                Console.WriteLine("Error the queue is full...");
            else {
                if (this.front == -1)
                    this.front = 0;
                this.rear++;
                this.arr[this.rear] = item;
            }
        }

        // dequeue method
        public void dequeue()
        {
            if (this.isEmpty())
                Console.WriteLine("Error the queue is empty...");
            else {
                this.arr[this.front] = 0;
                this.front++;
            }
        }

        // isFull method
        public bool isFull() {
            if (this.rear == this.arr.Length - 1)
                return true;
            else
                return false;
        }

        // isEmpty method
        public bool isEmpty()
        {
            if (this.front == -1)
                return true;
            else
                return false;
        }

        // display method
        public void display() {
            foreach (var item in this.arr)
            {
                Console.WriteLine("  ___");
                Console.WriteLine(" | " + item + " | ");
            }
            Console.WriteLine("________________________________");
        }

        // peek method
        public void peek()
        {
            if (!this.isEmpty())
                Console.WriteLine("retrieved element: " + this.arr[this.front]);
            else
            {
                Console.WriteLine("queue Underflow...");
            }
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(3);
            myQueue.enqueue(1);
            myQueue.enqueue(2);
            myQueue.enqueue(3);
            myQueue.peek();
            myQueue.display();
            myQueue.dequeue();
            myQueue.display();
            myQueue.peek();
        }
    }
}
