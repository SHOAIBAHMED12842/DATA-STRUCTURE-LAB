using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace INSERTIONSORT
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
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
            ARRAY1 = INSERTIONSORT(ARRAY);
            sw.Stop();
            
            Console.WriteLine("AFTER INSERTION SORT");
            Console.WriteLine("time\n");
            for (int S = 0; S < ARRAY1.Length; S++)
            {
                Console.Write("{1}\t", S + 1, ARRAY1[S]);
                
            }
            Console.WriteLine("time\n");
            Console.WriteLine("\ntime{0}", sw.Elapsed.TotalMilliseconds);
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
       public static int[] INSERTIONSORT(int[] array)
        {
            int variable;
           
            for (int R = 0; R < array.Length - 1; R++)
            {
               
                for (int IN = R + 1; IN > 0; IN--)
                {
                    if (array[IN - 1] > array[IN])
                    {
                        variable = array[IN - 1];
                        array[IN - 1] = array[IN];
                        array[IN] = variable;
                    }
                }
            }
            
           
           
            return array;
        }
    }
    
        
       
    
}
