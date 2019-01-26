using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVEOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.Write("Enter the number to which factorial is find:");
            number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            RECURSIVEop rec = new RECURSIVEop();
            Console.WriteLine("Factorial of {0} is {1}", number,rec.GetFactorail(number));
            int num3;
            Console.Write("Enter the number to which NOD is count:");
            num3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("NOD of {0} is {1} ", num3, rec.CountNOD(num3, 0));
            int num4;
            Console.Write("Enter the number to which base 2 is found:");
            num4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Base 2 of {0} is {1} ", num4, rec.BaseConverter(num4));
            int num1;
            int num2;
            Console.Write("Enter 2 numbers to which GCD is find:");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2, rec.GetGCD(num1, num2));   
        }
    }
    class RECURSIVEop
    {
        public int GetFactorail(int num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                return num = num * GetFactorail(num - 1);
            }
        }
        public int CountNOD(int num4,int count)
        {
            
            
            if (num4 ==0)
            {
                return count;
            }
            else
            {
            
                return CountNOD(num4 / 10,++count);
            }

        }
        public int BaseConverter(int num4)
        {
            if (num4 == 0)
            { 
                return 0; 
            }
              else
            {
                return (num4 % 2 + 10 *BaseConverter(num4 / 2));
            }
        }
        public int GetGCD(int num1, int num2)
        {
            if (num2 != 0)
            {
                return GetGCD(num2, num1 % num2);
            }
            else
            {
                return num1;
            }
        }
    }
}
