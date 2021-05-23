using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.StacksAndQueues
{
    //how to initialize a stack

    class program
    {
        static void Main(string[] args)
        {
            StackDemo stack = new StackDemo(3);
            stack.push("stack");
            stack.push("a");
            stack.push("is");
            stack.push("this");
            stack.push("hello");
        }
    }
    class StackDemo
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public StackDemo(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;

        }

        public void push(string m)
        {
            if (isFull())
            {
                Console.WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty.");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        public string peek()
        {
            return stackArray[top];
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }

        private bool isEmpty()
        {
            return (top == -1);
        }



        //EXAMPLES
        private static void DemoStack2()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            Console.WriteLine("Default content of stack");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nPopping '{0}'", names.Pop());
            Console.WriteLine("Peek at next item to display what will" +
                              " be destacked: {0}", names.Peek());
            Console.WriteLine("Now, after peek, popping '{0}'", names.Pop());


            Stack<string> stack2 = new Stack<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                Console.WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with " +
                              "duplicates and nulls:");
            foreach (string name in stack3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nstack2.Contains(\"Dana\") = {0}",
                stack2.Contains("Dana"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }


        private static void Count(int a)
        {
            Console.WriteLine("a = " + a + " on the stack");
            if (a < 3)
            {
                Count(a + 1);
            }
            Console.WriteLine("a = " + a + " off the stack");

        }

    }


}

