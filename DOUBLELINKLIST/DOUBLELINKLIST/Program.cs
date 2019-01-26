using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOUBLELINKLIST
{
    class Program
    {
        static void Main(string[] args)
        {int item;
            DOUBLElinklist node1 = new DOUBLElinklist();
            Console.WriteLine("Welcom to the grocery mart\nHere are the items you want to parchase in priority");
            Console.WriteLine("ITEM 1:EGGS\nITEM 2:BREAD\nITEM 3:BUTTER\nITEM 4:YOUGART\nITEM 5:MILK\nITEM 6:JUICE\nITEM 7:DATES\nITEM 8:OATS\nITEM 9:ICECREAM\nITEM 10:RICE");
            for (int i = 9; i >= 0; i--)
            {
                node1.addatfirst(i + 1);
            }
            for (int j = 0; j <= 10; j++)
            {
                if (j != 10)
                {
                    Console.Write("Enter the item no you want to purchase:");
                    item = Convert.ToInt16(Console.ReadLine());
                    node1.deletenodebykey(item);
                    Console.WriteLine("Item list is");
                    node1.print();
                }
                else
                {
                    Console.WriteLine("Finshed");
                }
            }
            //node1.addatfirst(10);
            //node1.addatfirst(20);
            //node1.addatfirst(30);
            //node1.addatfirst(40);
            //node1.print();
            //node1.deletenodebykey(40);
            //node1.print();
            //node1.search(60);
            //node1.insertafter(70,80);
            ////node1.deleteatstart();
            //node1.print();
            //node1.getlastnode();
        }
    }
    public class NODE
    {
        public int data;
        public NODE PREV;
        public NODE NEXT;
        public NODE()
        {
            data = 0;
            PREV = null;
            NEXT = null;
        }
        public NODE(int d)
        {
            data = d;
            PREV = null;
            NEXT = null;
        }
    }
    public class DOUBLElinklist
    {
        public NODE header;
        public NODE tail;

        public DOUBLElinklist()
        {
            
            header = null;
            tail = null;

        }
        public void addatfirst(int e)
        {
            NODE addf = new NODE(e);
            addf.data = e;
            addf.NEXT = header;
            addf.PREV = null;
            if(header!=null)
            {
                header.PREV = addf;
            }
            header = addf;
            //Console.WriteLine("{0}",e);
        }
      
        public void deletetnext()
        {
            header.NEXT= header.NEXT.NEXT;
            //if (next == null)
            //{
            //    return 0;
            //}
            //else
            //{
            //  NODE p=
            //    return 1;
            //}

        }
       

        public void deletenodebykey(int i)
        {
            NODE temp = header;
            if (temp != null && temp.data == i)
            {
                header = temp.NEXT;
                return;
            }
            while (temp != null && temp.data != i)
            {
                temp = temp.NEXT;
            }
            if (temp == null)
            {
                Console.WriteLine("NOT DELETING ITEM");
                return;
            }
            if(temp.NEXT!=null)
            {
                temp.NEXT.PREV = temp.PREV;
            }
            if (temp.PREV != null)
            {
                temp.PREV.NEXT = temp.NEXT;
            }
        }
       
    
        public void print()
        {
            NODE current = new NODE();
            current = header;


            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.NEXT;
            }


        }
        public void TRAVERSE(NODE E)
        {
            E = header;
            while (E.NEXT != null)
            {
                Console.WriteLine(E.NEXT.data);
                E = E.NEXT;
            }
        }

    }

}
