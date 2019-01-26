using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[9] { 1, 2, 3,4, 5, 6, 7, 8, 9};
            int [] arr1=new int[10];
            int lb = 0;
            int ub = arr.Length - 1;
            int mid = arr.Length / 2;
            int loc = 0;
            int search;
            Console.WriteLine("ENTER THE ELEMENT TO BE SEARCH");
            search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; lb <= arr.Length - 1 && arr[mid] != search; i++)
            {
                if (search < arr[mid])
                {
                    ub = mid - 1;
                }
                else
                {
                    lb = mid + 1;
                }
                mid = (lb + ub) / 2;
            }
            if (arr[mid] == search)
            {
                loc = mid;
                Console.WriteLine("SEARCHING SUCESSFUL ELEMENT IS FOUND LOCATION ={0}\n ARRAY IS=", loc + 1);
                for (int k = 0; k <= 8; k++)
                { Console.WriteLine("{0}", arr[k]); }
            }
            else
            {
               
                    Console.WriteLine("LOCATION NOT FOUND");
            }
            

        }
    }
}

