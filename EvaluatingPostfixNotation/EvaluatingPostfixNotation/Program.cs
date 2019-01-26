using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatingPostfixNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double f, s, r;
                bool check = true;
                Console.Write("Enter a postfix notation: ");
                string str = Console.ReadLine();
                ArrayStack<double> obj = new ArrayStack<double>(str.Length);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '^')
                    {
                        s = obj.pop();
                        f = obj.pop();
                        if (str[i] == '+')
                        {
                            r = f + s;
                        }
                        else if (str[i] == '-')
                        {
                            r = f - s;
                        }
                        else if (str[i] == '*')
                        {
                            r = f * s;
                        }
                        else if (str[i] == '/')
                        {
                            r = f / s;
                        }
                        else
                        {
                            r = Math.Pow(f, s);
                        }
                    }
                    else if (char.IsDigit(str[i]))
                    {
                        r = char.GetNumericValue(str[i]);
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                    obj.push(r);
                }
                if (obj.count() == 1 && check)
                {
                    Console.WriteLine("Answer of the post fix notation is: {0}", Math.Round(obj.pop()));
                }
                else
                {
                    Console.WriteLine("Wrong Notation");
                }
            }
            catch(OverflowException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
