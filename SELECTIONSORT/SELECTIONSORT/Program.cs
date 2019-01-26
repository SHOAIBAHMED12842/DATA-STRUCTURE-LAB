using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECTIONSORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int range;
            Console.Write("ENTER THE RANGE IN WHICH RANDOM NUMBER IS DISPLAY:");
            range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int[] ARRAY = new int[10];
            ARRAY = GenerateRandom(range);
            Console.WriteLine("RANDOM NUMBERS ");
            Console.WriteLine("\n");
            for (int S = 0; S < ARRAY.Length; S++)
            {
                Console.Write("{1}\t", S + 1, ARRAY[S]);
            }
            Console.WriteLine("\n");
            int[] ARRAY1 = new int[10];
            ARRAY1 = SELECTIONSORT(ARRAY);

            Console.WriteLine("AFTER SELECTION SORT");
            Console.WriteLine("\n");
            for (int S = 0; S < ARRAY1.Length; S++)
            {
                Console.Write("{1}\t", S + 1, ARRAY1[S]);
            }
            Console.WriteLine("\n");
        }
        static int[] GenerateRandom(int n)
        {
            Random rand = new Random();

            int[] ARRAY = new int[10];
            for (int R = 0; R < ARRAY.Length; R++)
            {
                ARRAY[R] = rand.Next(n);
            }
            return ARRAY;

        }
        static int[] SELECTIONSORT(int[] array)
        {
            int variable;
            for (int R = 0; R < array.Length - 1; R++)
            {
                for (int IN = R+1; IN < array.Length; IN++)
                {
                    if (array[R] > array[IN])
                    {
                        variable = array[IN ];
                        array[IN] = array[R];
                        array[R] = variable;
                       
                    }
                    
                }
            }
            return array;
        }
    }




}
