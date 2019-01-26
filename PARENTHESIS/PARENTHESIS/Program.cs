using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARENTHESIS
{
    class Program
    {
        static void Main(string[] args)
        {

            string peren;
            bool check1;
            Console.WriteLine("Enter an expression of order brackett");
            peren = Convert.ToString(Console.ReadLine());
            checkparenthesis check = new checkparenthesis();
            check1 = check.balanceparenthesis(peren);
            if(check1==true)
            {
                Console.WriteLine("Expression is true");
            }
            else
            {
                    Console.WriteLine("Expression is false");
            }
        }
    }
    class stack
    {
        int[] stack2 = new int[10];
        int value = -1;
       
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
        public int pop()
        {
            if (value < 0)
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
        public bool isempty()
        {
            if (value < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int count()
        {
            int g;
            g = value;
            return g + 1;
        }
        public int getpeek()
        {
            int d = stack2[value];
            return d;
        }
        public void print()
        {

            for (int i = value; i >= 0; i--)
            {
                Console.WriteLine(stack2[i]);
            }
        }
    }
}
