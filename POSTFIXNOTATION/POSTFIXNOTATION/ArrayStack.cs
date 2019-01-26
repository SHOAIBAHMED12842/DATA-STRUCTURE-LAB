using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTFIXNOTATION
{
    class ArrayStack<DT>
    {
        DT[] arr;
        int l = -1;
        public ArrayStack(int size)
        {
            arr = new DT[size];
        }
        public void push(DT element)
        {
            if (overflow())
            {
                l++;
                arr[l] = element;
                return;
            }
            throw new OverflowException("Stack Overflow");
        }
        public DT pop()
        {
            if (underflow())
            {
                DT pop = arr[l];
                l--;
                return pop;
            }
            throw new OverflowException("Postfix notation is wrong");
        }
        public DT peek()
        {
            if (underflow())
            {
                return arr[l];
            }
            throw new OverflowException("Stack is Empty");
        }
        public int count()
        {
            int count = 0;
            while (count <= l)
            {
                count++;
            }
            return count;
        }
        public void Print()
        {
            for (int i = 0; i <= l; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public bool Isempty()
        {
            if (l == arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool overflow()
        {
            if (l >= arr.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool underflow()
        {
            if (l < 0)
            {
                return false;}
            else
            {
                return true;
            }
        }
    }
}
