using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEQUE
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int size;
            Console.Write("Enter the size of array deque:");
            size = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Size of array stack is {0}", size);
            ArrayDeque deque = new ArrayDeque(size);
            deque.isEmpty();
            deque.insertFront(51);
            deque.insertFront(52);
            deque.insertFront(53);
            deque.insertFront(54);

            deque.isEmpty();
            deque.insertLast(61);
            deque.insertLast(62);
            deque.insertLast(63);
            deque.insertLast(64);

            deque.deletefirst();
            deque.deleteLast();
            deque.deletefirst();
            deque.deleteLast();
            deque.deletefirst();
            deque.deleteLast();
            deque.getFront();
            deque.getRear();
            deque.isFull();
            int element;
            int position;
            Console.WriteLine("");
            Console.Write("Enter the element which add in deque:");
            element = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Enter the position in  which element to be add in deque:");
            position = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            deque.add(position, element);
            int remove1;
            Console.Write("Enter the element  to remove in deque:");
            remove1 = Convert.ToInt16(Console.ReadLine());
            deque.remove(remove1);
        }
    }
    class ArrayDeque
    {
        public int[] deque1;
        public int front;
        public int rear;
        public int max;
        public ArrayDeque()
        {
            
        }
        public ArrayDeque(int e)
        {
             deque1 = new int[e];
             front=(e/2)-1;
             rear = (e/2);
             max = e;

        }
        public void insertFront(int h)
        {
            if(front<0)
            {
                Console.WriteLine("Deque is full");
            }
            else
            {
                deque1[front]=h ;
                 front--;
                 Console.WriteLine("insert first is {0}", h);
            }
        }
        public void insertLast(int d)
        {
            if (rear > deque1.Length-1)
            {
                Console.WriteLine("Deque is full");
            }
            else
            {
               
               deque1[rear]=d;
               rear++;
               Console.WriteLine("insert last is {0}", d);     
            }
        }
        public void deletefirst()
        {
            if (front>deque1.Length-1||(((front==(max/2)-1)&&(rear==max/2))))
            {
                Console.WriteLine("Deque is empty");
            }
            else if(((front==(max/2))&&(rear==(max/2))&&(deque1[front]==deque1[rear])))
            {
                Console.WriteLine("Deque is empty");
            }
            else
            {
                front++;
                int s = deque1[front];
               
                Console.WriteLine("delete first is {0}", s);
            }
        }
        public void deleteLast()
        {
          if (rear<0||(((front==(max/2)-1)&&(rear==max/2))))
            {
                Console.WriteLine("Deque is empty");
            }
            
            else
            { 
                int h;
                rear--;
                h = deque1[rear];
               Console.WriteLine("delete last is {0}", h);
            }
        }
        public void getFront()
        {
            if (front > deque1.Length - 1 || (deque1[rear] == deque1[front])||(((front == (max / 2) - 1) && (rear == max / 2))))
            {
                Console.WriteLine("Deque get front has garbage value");
            }
            else
            {
                 front++;
            int d = deque1[ front];
            Console.WriteLine("Get front is {0}", d);
            }
        }
        public void getRear()
        {
            if (rear < 0 ||(deque1[front-1]==deque1[rear-1])|| (((front == (max / 2) - 1) && (rear == max / 2))))
            {
                Console.WriteLine("Deque get rear has garbage value");
            }
            else
            {
                rear--;
                int d = deque1[rear];
                Console.WriteLine("get rear is {0}", d);
            }
            
        }
        public void isEmpty()
        {
            if (((front == (max / 2)-1) && (deque1[front] == 0))&&((rear==(max/2)&&(deque1[rear]==0))))
            {
                Console.WriteLine("Deque is empty");
            }
            else
            {
                    Console.WriteLine("Deque has values");
               
            }
        }
        public void isFull()
        {
            if (rear == deque1.Length)
            {
                Console.WriteLine("Deque is full");
            }
            else
            {
                Console.WriteLine("Deque is not full");

            }
        }
        public void add(int i,int x)
        {
            int j = 0;
           if(i<max/2)
           {
              
               j = (j == 0) ? deque1.Length - 1 : j - 1;
               for(int s=0;s<=i-1;s++)
               {
                   deque1[(j + s) % deque1.Length] = deque1[(j + s + 1) % deque1.Length];
               }
           }
           else
           {
               for (int s = max; s > i; s--)
               {
                   deque1[(j + s) % deque1.Length] = deque1[(j + s - 1) % deque1.Length];
               }
           }
           deque1[(j + i) % deque1.Length] = x;
           max++;
            for(int h=0;h<deque1.Length;h++ )
            {
                Console.WriteLine("Element {0} is {1}",h,deque1[h]);
            }
        }
        public void remove(int i)
        {
            int j = 0;
            int x = deque1[(j + i) % deque1.Length];
            if (i < max / 2)
            {
                for (int k = i; k > 0; k--)
                {
                    deque1[(j + k) % deque1.Length] = deque1[(j + k - 1) % deque1.Length];
                    j = (j + 1) % deque1.Length;
                }
            }
            else
            { 
                for (int k = i; k < max - 1; k++)
                    deque1[(j + k) % deque1.Length] = deque1[(j + k + 1) % deque1.Length];
            }
            max--;
            for (int h = 0; h < deque1.Length; h++)
            {
                Console.WriteLine("Element {0} is {1}", h, deque1[h]);
            }
        }

        
    }
}
