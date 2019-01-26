using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelist
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;
            singlelinklist node1 = new singlelinklist();
            Console.WriteLine("Welcom to the grocery mart\nHere are the items you want to parchase in priority");
Console.WriteLine("ITEM 1:EGGS\nITEM 2:BREAD\nITEM 3:BUTTER\nITEM 4:YOUGART\nITEM 5:MILK\nITEM 6:JUICE\nITEM 7:DATES\nITEM 8:OATS\nITEM 9:ICECREAM\nITEM 10:RICE");
for (int i = 9; i>=0;i--)
{
    node1.addatfirst(i + 1);
}
for (int j = 0; j <= 10;j++ )
{
     if(j!=10)
    {
        Console.Write("Enter the item no you want to purchase:");
        item = Convert.ToInt16(Console.ReadLine());
        node1.deletenodebykey(item );
        Console.WriteLine("Item list is");
        node1.print();
    }
     else
     {
         Console.WriteLine("Finshed");
     }
}
   
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
        public NODE next;
        public NODE()
        {
            data = 0;
            next = null;
        }
        public NODE(int d)
        {
            data = d;
            next = null;
        }
    }
    public class singlelinklist
    {
        public NODE header;
        
     
       public singlelinklist()
        {
            header = new NODE();
            
        }
        public void addatfirst(int e)
        {
            NODE addf = new NODE(e);
            addf.data = e;
            addf.next = header.next;
            header.next = addf;
            //Console.WriteLine("{0}",e);
        }
        public void addatlast(int j)
        {
            //NODE temp = header;
            //while(temp.next!=null)
            //{
            //    temp = temp.next;
            //}
            NODE addl = new NODE(j);
            if(header==null)
            {
                header = addl;
                return;
            }
            NODE lastnode=getlastnode() ;
            lastnode.next = addl;
        }
        public void  deletetnext()
        {
            header.next = header.next.next;
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
        public NODE getlastnode()
        {
            NODE temp = header;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
           
        }
        
        public void deletenodebykey(int i)
        {
           NODE temp = header;
           NODE prev = null;  
	    if (temp != null && temp.data == i) {  
	        header = temp.next;  
	        return;  
	    }  
	    while (temp != null && temp.data != i) {  
	        prev = temp;  
	        temp = temp.next;  
	    }
        if (temp == null)
        {
            Console.WriteLine("NOT DELETING ITEM");
            return;
        }
            prev.next = temp.next;  
        }
        public NODE search(int e)
        {
            NODE t = header;
            while(t!=null)
            {
                if(t.data==e)
                {
                    Console.WriteLine("Data is found");
                    return t;
                }
               
                t = t.next;
            }
            return null;
        }
        public void insertafter(int e,int x)
        {
            //if(prevnode==null)
            //{
            //    Console.WriteLine("Previous node cannnot be null");
            //    return;
            //}
            NODE inafter = search(x);
            while (inafter != null)
            {
                NODE n = new NODE(e);
                n.next = inafter.next;
                inafter.next = n;
            }
            //inafter.next = prevnode.next;
            //prevnode.next = inafter;
        }
        public void print()
        {
            NODE current = new NODE();
            current = header;
          

           while (current.next != null)
           {
               Console.WriteLine(current.next.data);
               current = current.next;
           }
           
           
        }
        public void TRAVERSE(NODE E)
        {
           E = header;
            while(E.next!=null)
            {
                Console.WriteLine(E.next.data);
                E = E.next;
            }
        }
        
    }

}
