using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabinkarp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long J;
            string s="SHOAIB";
            J = hash(s, s.Length, 10, 997);
            Console.WriteLine(J);
            J = hash(s, s.Length, 10, 997);
            Console.WriteLine(J);
            long k=rabinkarp(s, "ahmed");
            if(k==0)
            {
                Console.WriteLine("match");
            }
            else
            {
                Console.WriteLine(" not match");
            }
            long P = rabinkarp(s, "SHOAIB");
            if (P == 0)
            {
                Console.WriteLine("match");
            }
            else
            {
                Console.WriteLine(" not match");
            }
           
        }
        static long rabinkarp(string t,string p)
        {
            int M = p.Length;
            int R = 10;
            int Q = 420921;
            int RM = 1;
            for(int i=1;i<=M-1;i++)
            {
                RM = (R * RM) % Q;
            }
            long pathhash = hash(p, M, R, Q);
            //Console.WriteLine("{0}", pathhash);
            //return -1;
            int n = t.Length;
            long txthash = hash(t, M, R, Q);
            if(pathhash==txthash)
            {
                return 0;
            }
            for(int i=M;i<n;i++)
            {
                txthash = (txthash + Q - RM * t[i - M] % Q) % Q;
                txthash = (txthash * R + t[i]) % Q;
                if(pathhash==txthash)
                {
                    return i - M + 1;
                }
            }
            return -1;
        }
        static private long hash(string key,int M,int R,int Q)
        {
            long h = 0;
            for(int j=0;j<M;j++)
            {
                h=(R*h+key[j]%Q);
            }
            return h;
        }
    }
}
