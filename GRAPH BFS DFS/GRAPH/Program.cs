using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAPH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement adjacency  list by adjacency matrix ");
            GRAPH1 graph = new GRAPH1(6);
            graph.Addedges(1, 2);
            graph.Addedges(1, 3);
            graph.Addedges(2, 3);
            graph.Addedges(3, 4);
            graph.Addedges(3, 5);
            graph.Addedges(4, 5);
            Console.WriteLine("Adjacency matrix");
            graph.PrintMatrix();
            Console.WriteLine("DFS");
            graph.DFS(1);
            Console.WriteLine("BFS");
            graph.BFS(1);
            Console.WriteLine("Implement adjacency list by linkedlist ");
            graphlinkedlist graphli = new graphlinkedlist(6);
            graphli.addedge(1, 2);
            graphli.addedge(1, 3);
            graphli.addedge(2, 3);
            graphli.addedge(3, 4);
            graphli.addedge(3, 5);
            graphli.addedge(4, 5);
            Console.WriteLine("DFS");
            graphli.DFS(1);
            Console.WriteLine("BFS");
            graphli.BFS(1);
            Console.WriteLine("Implement adjacency  list by list ");
            graphlist graphl = new graphlist(6);
            graphl.addedge(1, 2);
            graphl.addedge(1, 3);
            graphl.addedge(2, 4);
            graphl.addedge(3, 4);
            graphl.addedge(4, 1);
            Console.WriteLine("DFS");
            graphl.DFS(1);
            Console.WriteLine("BFS");
            graphl.BFS(1);
            

        }
    }
    public class graphlinkedlist
    {
        public int numvertices;
        public LinkedList<Int32>[] adj;
        public graphlinkedlist(int v)
        {
            numvertices = v;
            adj = new LinkedList<Int32>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }
        public void addedge(int c, int v)
        {
            adj[c].AddLast(v);
        }
        public void DFS(int v)
        {
            bool[] visited = new bool[numvertices];
            Stack<Int32> stack = new Stack<int>();
            visited[v] = true;
            stack.Push(v);
            while (stack.Count != 0)
            {
                v = stack.Pop();
                Console.WriteLine("NEXT:{0}", v);
                foreach (int i in adj[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
        public void BFS(int v)
        {
            bool[] visited = new bool[numvertices];
            Queue<Int32> queue = new Queue<int>();
            visited[v] = true;
            queue.Enqueue(v);
            while (queue.Count != 0)
            {
                v = queue.Dequeue();
                Console.WriteLine("NEXT:{0}", v);
                foreach (int i in adj[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
    public class graphlist
    {
        public int numvertices;
        public List<Int32>[] adj;
        public graphlist(int v)
        {
            numvertices = v;
            adj = new List<Int32>[v];
            for(int i=0;i<v;i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void addedge(int c,int v)
        {
            adj[c].Add(v);
        }
        public void DFS(int v)
        {
            bool[] visited = new bool[numvertices];
            Stack<Int32> stack = new Stack<int>();
            visited[v] = true;
            stack.Push(v);
            while(stack.Count!=0)
            {
                v = stack.Pop();
                Console.WriteLine("NEXT:{0}", v);
                foreach(int i in adj[v])
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
        public void BFS(int v)
        {
            bool[] visited = new bool[numvertices];
            Queue<Int32> queue = new Queue<int>();
            visited[v] = true;
            queue.Enqueue(v);
            while (queue.Count != 0)
            {
                v = queue.Dequeue();
                Console.WriteLine("NEXT:{0}", v);
                foreach (int i in adj[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
    public class GRAPH1
    {
      //public Vertex[] vertices;
        public int[,] adjmatrix;
        public int vertices;
        public GRAPH1(int v)
        {
            vertices = v;
            adjmatrix = new int[v, v];
            
        }
        public void Addedges(int source,int destination)
        {
            adjmatrix[source, destination] = 1;
            adjmatrix[destination,source] = 1;
        }
        public int[] GetNeighbours(int v)
        {
            List<int> neg = new List<int>();
            for (int i = 0; i < vertices;i++ )
            {
                if(adjmatrix[v,i]==1)
                {
                    neg.Add(i);
                }
            }
                return neg.ToArray();
        }
        public void DFS(int v)
        {
            List<int> visted=new List<int>();
            Stack<Int32> stack = new Stack<int>();
            
            stack.Push(v);
            visted.Add(v);
            while(stack.Count>0)
            {
                int thisvertex=stack.Pop();
                Console.WriteLine("VISITED:{0}",thisvertex);
                int [] neg=GetNeighbours(thisvertex);
                foreach(int n in neg)
                {
                    if(!visted.Contains(n))
                    {
                        stack.Push(n);
                        visted.Add(n);
                    }
                }
            }
        }
        public void BFS(int v)
        {
            Queue<int> queue = new Queue<int>();
            List<int> blist = new List<int>();
            queue.Enqueue(v);
            blist.Add(v);
            while (queue.Count > 0)
            {
                int thisVertex = queue.Dequeue();
                Console.WriteLine("Visited {0}", thisVertex);
                int[] neg = GetNeighbours(thisVertex);
                foreach (int n in neg)
                {
                    if (!blist.Contains(n))
                    {
                        queue.Enqueue(n);
                        blist.Add(n);
                    }

                }

            }
        }
        public void PrintMatrix()
        {
            for(int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    Console.Write("{0} \t", adjmatrix[i, j]);
                   
                }
                Console.WriteLine("\n");
            }
        }

    }
    
}
