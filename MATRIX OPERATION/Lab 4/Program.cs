using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;
            Console.Write("Rows:");
            r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Coloumn:");
            c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            int[,] matrix1 = new int[r, c];
            Program mat = new Program();
            matrix1 = mat.getelements(r, c);

            int[,] matrix2 = new int[r, c];
            Console.WriteLine("Enter 2nd matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());

                }
                Console.WriteLine("");
            }
            Console.WriteLine("1st matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", matrix1[i, j]);

                }
                Console.WriteLine("");
            }
            Console.WriteLine("2nd matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", matrix2[i, j]);

                }
                Console.WriteLine("");
            }
            int[,] matrix3 = new int[r, c];
            matrix3 = mat.addmatrix(matrix1, matrix2);
            Console.WriteLine("ADDTION");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", matrix3[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }
            int[,] transmat = new int[r, c];
            Console.WriteLine("TRANPOSE OF 2ND MATRIX");
            transmat = mat.gentranspose(matrix2);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", transmat[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }
            mat.checkidentity(matrix1);
            mat.sumrow(matrix2);
            mat.sumcol(matrix2);
        }
        public int[,] getelements(int r, int c)
        {
            int[,] matrix = new int[r, c];
            Console.WriteLine("Enter First Matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    matrix[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            return matrix;
        }
        public int[,] addmatrix(int[,] matrix1, int[,] matrix2)
        {

            int[,] matrix3 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];

                }
            }
            return matrix3;
        }
        public int[,] gentranspose(int[,] matrix3)
        {
            int[,] matrix4 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix4[i, j] = matrix3[j, i];

                }
            }
            return matrix4;
        }
        public void checkidentity(int[,] matrix1)
        {
            bool flag = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && matrix1[i, j] != 1)
                    {

                        flag = false;
                        break;

                    }
                    if (i != j && matrix1[i, j] != 0)
                    {
                        flag = false;
                        break;
                    }
                }

            }
            if (flag == false)
            {
                Console.WriteLine("1st matrix is not identity matrix");
            }
            else
            {
                Console.WriteLine("1st matrix is  identity matrix");
            }
        }
        public void sumrow(int[,] matrix2)
        {
            int[] rowsum = new int[3];
            Console.WriteLine("SUM OF ROWS OF SECOND MATRIX IS:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rowsum[i]=rowsum[i]+matrix2[i,j];

                }
                Console.WriteLine("SUM OF {0} ROW IS {1}", i + 1, rowsum[i]);
            }
        }
        public void sumcol(int[,] matrix2)
        {
            int[] colsum = new int[3];
            Console.WriteLine("SUM OF COL OF SECOND MATRIX IS:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    colsum[j] = colsum[j] + matrix2[i, j];

                }
                Console.WriteLine("SUM OF {0} COL IS {1}", i + 1, colsum[i]);
            }
        }

    }

}


