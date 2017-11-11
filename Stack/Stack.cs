using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Stack
    {
        // stack fields...
        int top;
        public int[] arr;

        // stack constructor
        public Stack(int stackLength) {
            this.top = -1;
            this.arr = new int[stackLength];
        }

        // push method
        public void push(int item) {
            if (top == arr.Length - 1)
                Console.WriteLine("Stack Overflow");
            else {
                top++;
                arr[top] = item;
            }            
        }

        // pop method
        public void pop() {
            if (this.top == -1)
                Console.WriteLine("no items to pop. Stack Underflow!");
            else {
                this.arr[top] = 0;
                this.top--;
            }
        }

        // isEmpty method
        public bool isEmpty() {
            if (this.top == -1)
                return true;
            else
                return false;
        }

        // isFull method
        public bool isFull() {
            if (this.top == this.arr.Length - 1)
                return true;
            else
                return false;
        }

        // peek method
        public void peek() {
            if (!this.isEmpty())
                Console.WriteLine("retrieved element: " + this.arr[this.top]);
            else {
                Console.WriteLine("Stack Underflow...");
            }
        }

        // display method
        public void display() {
            for (int i = this.arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("  ___");
                Console.WriteLine(" | " + this.arr[i] + " | ");
            }
            Console.WriteLine("________________________________");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(3);
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.display();
            myStack.pop();
            myStack.display();
        }
    }
}
