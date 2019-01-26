using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int con;
            int size;
            Console.Write("Enter the size of array queue:");
            size = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Size of array stack is {0}", size);
            arrayqueue que = new arrayqueue(5);
            que.isempty();
            que.enqueue(10);
            que.enqueue(20);
            n = que.dequeue();
            Console.WriteLine("Dequeue element is {0}", n);
            que.enqueue(30);

            que.enqueue(40);
            que.isempty();
            if (que.isempty() == true)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue has values");
            }
            que.enqueue(50);
            n=que.dequeue();
            Console.WriteLine("Dequeue element is {0}", n);
            int peak;
            peak = que.getpeek();
            Console.WriteLine("Peek element is {0}", peak);
            con = que.count();
            Console.WriteLine("Number of elements in queue are  {0}", con);
            Console.WriteLine("Elements are : ");
            que.print();
        }
    }
    class arrayqueue
    {
        public int []queue;
         public int head;
         public int tail;
        public int max;
        public arrayqueue()
        {

        }
        public arrayqueue(int siz)
        {
            queue = new int[siz];
            head = 0;
            tail = -1;
            max = siz;
        }
        public void enqueue(int e)
        {
            if (tail == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                tail++;
                queue[tail] = e;
            }
        }
        public int dequeue()
        {
            if (head == tail + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int h;
                h = queue[head];
                head++;
                return h ;
            }
        }
        public bool isempty()
        {
            if (tail < 0)
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
            g = head;
            return g + 1;
        }
        public int getpeek()
        {
            int d = queue[head];
            return d;
        }
        public void print()
        {
              if (head == tail + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = head; i <= tail; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }
    }
}
