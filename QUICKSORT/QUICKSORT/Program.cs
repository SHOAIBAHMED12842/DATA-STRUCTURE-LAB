using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QUICKSORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int LENGTH;
            Console.Write("ENTER THE LENGTH IN WHICH RANDOM NUMBER IS DISPLAY UPTO 100:");
            LENGTH = Convert.ToInt32(Console.ReadLine());
            TIME(LENGTH);
        }
        public int[] GenerateRandom(int n)
        {
            Random rand = new Random();

            int[] ARRAY = new int[n];
            for (int R = 0; R < ARRAY.Length; R++)
            {
                ARRAY[R] = rand.Next(100);
            }
            return ARRAY;

        }
        public static void Quick_SortA(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = PartitionA(arr, left, right);

                if (pivot > 1)
                {
                    Quick_SortA(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_SortA(arr, pivot + 1, right);
                }
            }

        }
        public static int PartitionA(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        public static void Quick_SortD(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = PartitionD(arr, left, right);

                if (pivot > 1)
                {
                    Quick_SortD(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_SortD(arr, pivot + 1, right);
                }
            }

        }

        public static int PartitionD(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            while (true)
            {

                while (arr[left] > pivot)
                {
                    left++;
                }

                while (arr[right] < pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        public static void TIME(int N)
        {
            Program myran = new Program();
            int[] ARRAY = new int[N];
            ARRAY = myran.GenerateRandom(N);

            Console.WriteLine("RANDOM ARRAY : ");
            for (int i = 0; i < ARRAY.Length; i++)
            {
                Console.Write(" " + ARRAY[i]);
            }
            Console.WriteLine();
            Stopwatch QUICKSORTA = new Stopwatch();
            QUICKSORTA.Start();
            Quick_SortA(ARRAY, 0, ARRAY.Length - 1);

            Console.WriteLine();
            Console.WriteLine("QUICKSORT in Ascending order : ");

            for (int i = 0; i < ARRAY.Length; i++)
            {
                Console.Write(" " + ARRAY[i]);
            }
            QUICKSORTA.Stop();
            Stopwatch QUICKSORTD = new Stopwatch();
            QUICKSORTD.Start();
            Quick_SortD(ARRAY, 0, ARRAY.Length - 1);

            Console.WriteLine();
            Console.WriteLine("QUICKSORT in decending order : ");

            for (int i = 0; i < ARRAY.Length; i++)
            {
                Console.Write(" " + ARRAY[i]);
            }
            QUICKSORTD.Stop();
            Console.WriteLine();
            Console.WriteLine("Time comparision for {0} numbers:", N);
            Console.WriteLine("QUICKSORT in Ascending order :{0} seconds", QUICKSORTA.Elapsed);
            Console.WriteLine("QUICKSORT in decending order :{0} seconds", QUICKSORTD.Elapsed);
        }


    }
}
