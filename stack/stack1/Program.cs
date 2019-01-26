using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;int con;
            Console.WriteLine("Size of array stack is 10");
            arraystack stack1 = new arraystack();
            stack1.isempty();
            if (stack1.isempty() == true)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack has values");
            }
            stack1.push(56);
            stack1.push(96);
            stack1.push(40);
            stack1.print();
            n = stack1.pop();
            Console.WriteLine("POP element is {0}", n);
            stack1.push(32);
            stack1.push(60);
            n = stack1.pop();
            stack1.print();
            Console.WriteLine("POP element is {0}", n);
            stack1.isempty();
            if (stack1.isempty() == true)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack has values");
            }
            int peak;
            peak = stack1.getpeek();
            Console.WriteLine("Peek element is {0}", peak);
            con = stack1.count();
            Console.WriteLine("Number of elements in stack are  {0}", con);
            stack1.print();
        }
    }
    class arraystack
    {
        int[] stack2 = new int[10];
        int value = -1;
        bool check;
        public void push(int e)
        {
            if (value > 10)
            {
                Console.Write("Stack is overflow");
            }
            else
            {
                value++;
                stack2[value] = e;
               
            }    
        }
        public bool isempty()
        {
            if(value<0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int pop()
        {
            if(value<0)
            {
                Console.Write("Stack is underflow");
                return -1;
            }
            else
            {
                int s = stack2[value];
                value--;
                return s;
            }
           
        }
        public int count()
        {
            int g;
            g = value ;
            return g+1;
        }
        public int getpeek()
        {
            int d = stack2[value];
            return d;
        }
        public void print()
        {
            
            for (int i = value; i >=0; i--)
            {
                Console.WriteLine(stack2[i]);
            }
        }
    }
}
