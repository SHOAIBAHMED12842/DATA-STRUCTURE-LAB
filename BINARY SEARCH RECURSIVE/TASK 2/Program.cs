using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Program
    {
       public static void Main()
        {
            int[] arr = new int[9]{1,2,3,4,5,6,7,8,9};
            int lb = 0;
            int ub = arr.Length - 1;
            int x;
            Console.WriteLine("ENTER THE ELEMENT TO BE FOUND");
            x = Convert.ToInt16(Console.ReadLine());
            int result = binarySearch(arr, lb, ub, x);
            if (result != -1)
            {
                Console.WriteLine("Element found at :{0} ", result + 1);
            }
            else
            {
                Console.WriteLine("Element not found ");
            }
        }
        static int binarySearch(int[] arr, int l,int u, int x)
        {if (u >= l)
            {int mid = l + (u - l) / 2;
                if (arr[mid] == x)
                {
                    return mid;}
                else   if (arr[mid] > x)
                {
                    return binarySearch(arr, l, mid - 1, x);}
                else
                {
                    return binarySearch(arr, mid + 1, u, x);}          
            }
            return -1;
        }
    }
}
