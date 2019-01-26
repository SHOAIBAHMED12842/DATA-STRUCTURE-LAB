using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPairOfStringIsCorrectOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cont = 0;
                Console.WriteLine("Enter pairs of bracket to check whether the pair is orderd of not: ");
                string str = Console.ReadLine();
                ArrayStack<char> obj = new ArrayStack<char>(str.Length);
                for (int i = 0; i < str.Length; i++)
                {
                    cont = 0;
                    if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                        obj.push(str[i]);
                    else if (str[i] == ')' || str[i] == '}' || str[i] == ']')
                    {
                        char PC = obj.pop();
                        if (PC == '(' && str[i] == ')' || PC == '{' && str[i] == '}' || PC == '[' && str[i] == ']')
                        {
                            cont = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (obj.count() == 0 && cont == 1)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            catch (OverflowException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
