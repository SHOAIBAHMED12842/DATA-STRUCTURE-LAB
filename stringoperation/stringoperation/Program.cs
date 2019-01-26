using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            stringOP str1 = new stringOP();
            string sb1 = "Usman Institute";
            string sb2 = "OF";
            int i;
            i = str1.strlength(sb1);
            Console.WriteLine("LENGTH OF STRING {0} IS {1}", sb1, i);
            string sb3 = "  Technology ";
            string concat;
            concat = str1.strconcat(sb1, sb3);
            Console.WriteLine("Concatination of STRING is {0}",concat);
            string substring;
            substring = str1.substring(concat, 2, 4);
            Console.WriteLine("SUBSTRING of {0} is {1}", concat, substring);
            string insert = str1.InsertStr(concat, sb2, 15);
            Console.WriteLine("INSERTING {0} in {1} at {2} postion is {3}",sb2,concat,15,insert);
            string delete = str1.DeleteStr(insert,0,5);
            Console.WriteLine("Delete of STRING is {0}", delete);
            Console.WriteLine("NAIVE ALGORITHAM");
            str1.Naive("Usman", "man");
            Console.WriteLine("RABINKARP ALGORITHAM");
            str1.RabinKarp("Usman", "man", 256, 997);

        }
    }
    class stringOP
    {
        public int strlength(string text)
        {
            int length = 0;
            foreach(char n in text)
            {
                length++;
            }
            return length;
        }
        public string strconcat(string text1,string text2)
        {
            StringBuilder sb = new StringBuilder(text1);
            sb.Append(text2);
            return sb.ToString();
        }
        public string substring(string data, int start, int end)
        {
            //int a = data.Length;
            //char[] arr=new char[a];
            StringBuilder sb = new StringBuilder();
            for(int i=start;i<=end;i++)
            {
                sb.Append(data[i]);
                //arr = data.ToCharArray();
            }
            return sb.ToString();
        }
        public string InsertStr(string data, string text, int position)
        {
            string s1, s2, s3;
            if (position >= -1)
            {
                if (position < data.Length - 1)
                {
                    s1 = substring(data, 0, position);
                    s2 = substring(data, position + 1, strlength(data) - 1);
                    s3 = strconcat(s1, text);
                    s3 = strconcat(s3, s2);
                }
                else if (position == data.Length - 1)
                {
                    s3 = strconcat(data, text);
                }
                else
                {
                    s3 = "Insertion is not possible because position is greater than the length of data";
                }
            }
            else
            {
                s3 = "Insertion is not possible because position is to small";
            }
            return s3;
        }
        public string DeleteStr(string data, int position, int length)
        {
            string s1, s2, s3;
            if ((position >= 0 && position < strlength(data)) && length + position < strlength(data))
            {
                s1 = substring(data, 0, position - 1);
                s2 = substring(data, position + length, strlength(data) - 1);
                s3 = strconcat(s1, s2);
            }
            else if ((position >= 0 && position < strlength(data)) && length + position >= strlength(data))
            {
                s3 = substring(data, 0, position - 1);
            }
            else if (position < 0)
            {
                s3 = "Invalid position";
            }
            else
            {
                s3 = "Deletion is not possible because position is greater than the length of data";
            }
            return s3;
        }
        public void Naive(string data, string Pattren)
        {
            int n = data.Length;
            int m = Pattren.Length;
            int i = 0;
            for (int s = 0; s <= n - m; s++)
            {
                for (i = 0; i < m; i++)
                {
                    if (Pattren[i] != data[s + i])
                    {
                        break;
                    }
                }
                if (i == m)
                {
                    Console.WriteLine("Enter pattren ocuur with shift {0}", s);
                }
            }
        }
        public void RabinKarp(string Data, string Pattern, int d, int q)
        {
            int M = strlength(Pattern);
            int N = strlength(Data);
            int i, j;
            int p = 0;
            int t = 0;
            int h = 1;

            // The value of h would be "pow(d, M-1)%q" 
            for (i = 0; i < M - 1; i++)
                h = (h * d) % q;

            // Calculate the hash value of pattern and first 
            // window of text 
            for (i = 0; i < M; i++)
            {
                p = (d * p + Pattern[i]) % q;
                t = (d * t + Data[i]) % q;
            }

            // Slide the pattern over text one by one 
            for (i = 0; i <= N - M; i++)
            {

                // Check the hash values of current window of text 
                // and pattern. If the hash values match then only 
                // check for characters on by one 
                if (p == t)
                {
                    /* Check for characters one by one */
                    for (j = 0; j < M; j++)
                    {
                        if (Data[i + j] != Pattern[j])
                            break;
                    }

                    // if p == t and pat[0...M-1] = txt[i, i+1, ...i+M-1] 
                    if (j == M)
                        Console.WriteLine("Pattern found at shift {0}", i);
                }

                // Calculate hash value for next window of text: Remove 
                // leading digit, add trailing digit 
                if (i < N - M)
                {
                    t = (d * (t - Data[i] * h) + Data[i + M]) % q;

                    // We might get negative value of t, converting it 
                    // to positive 
                    if (t < 0)
                        t = (t + q);
                }
            }
        }
    }
}
