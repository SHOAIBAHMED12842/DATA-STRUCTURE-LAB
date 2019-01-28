using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellmanford1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Graph g = new Graph(5);
                g.AddDirectedEdge(0, 1, 6);
                g.AddDirectedEdge(0, 3, 7);
                g.AddDirectedEdge(4, 0, 2);
                g.AddDirectedEdge(1, 2, 5);
                g.AddDirectedEdge(2, 1, -2);
                g.AddDirectedEdge(1, 3, 8);
                g.AddDirectedEdge(3, 2, -3);
                g.AddDirectedEdge(1, 4, -4);
                g.AddDirectedEdge(3, 4, 9);
                g.AddDirectedEdge(4, 2, 7);
                //for negative cycle
                //Graph g = new Graph(4);
                //g.AddDirectedEdge(0, 1, 4);
                //g.AddDirectedEdge(0, 3, 5);
                //g.AddDirectedEdge(3, 2, 3);
                //g.AddDirectedEdge(2, 1, -10);
                //g.AddDirectedEdge(1, 3, 5);
                g.BellmanFord(0);
            }
            catch(Exception e)
            {
                Console.WriteLine("{0}",e.Message);
            }
            
        }
    }
    class Graph
    {
        public int vertices;
        public int[,] adjmatrix;
        public int edges;

        public Graph(int v)
        {
            vertices = v;
            adjmatrix = new int[v, v];
            edges = 0;
        }
        public void AddDirectedEdge(int s, int d, int weight)
        {
            adjmatrix[s, d] = weight;
            edges++;
        }
        public int[] GetDirectedneighbours(int source)
        {
            List<int> neg = new List<int>();
            for(int i=0;i<vertices;i++)
            {
                if(adjmatrix[source,i]>0)
                {
                    neg.Add(i);
                }
            }
            return neg.ToArray();
        }
        public int[,] GetAllEdges()
        {
            int[,] Edges = new int[edges, 3];
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (adjmatrix[i, j] != 0)
                    {
                        Edges[count, 0] = i;
                        Edges[count, 1] = j;
                        Edges[count, 2] = adjmatrix[i, j];
                        count++;
                    }

                }
            }

            return Edges;
        }
        // The main function that finds shortest distances from src  
        // to all other vertices using Bellman-Ford algorithm. The  
        // function also detects negative weight cycle  
        public void BellmanFord(int src)
        {
            int[] distance = new int[vertices];

            // Step 1: Initialize distances from src to all other  
            // vertices as INFINITE  
            for (int i = 0; i < vertices; ++i)
            {
                distance[i] = int.MaxValue;
            }

            distance[src] = 0;
            int[,] Edges = GetAllEdges();
            // Step 2: Relax all edges |V| - 1 times. A simple  
            // shortest path from src to any other vertex can  
            // have at-most |V| - 1 edges  
            for (int i = 1; i < vertices; ++i)
            {
                for (int j = 0; j < edges; ++j)
                {
                    int s = Edges[j,0];
                    int d = Edges[j, 1];
                    int w = Edges[j, 2]; ;
                    if (distance[s] != int.MaxValue && distance[s] + w < distance[d])

                        distance[d] = distance[s] + w;
                }
            }
            // Step 3: check for negative-weight cycles. The above  
            // step guarantees shortest distances if graph doesn't  
            // contain negative weight cycle. If we get a shorter  
            // path, then there is a cycle.  
            for (int j = 0; j < edges; ++j)
            {
                int s = Edges[j, 0];
                int d = Edges[j, 1];
                int w = Edges[j, 2];
                if (distance[s] != int.MaxValue && distance[s] + w < distance[d])

                    Console.WriteLine("Graph contains negative weight cycle");
            }
            printArr(distance, vertices);
        }

        // print the distances with vertex  
        public void printArr(int[] distance, int v)
        {
            Console.WriteLine("Vertex     Distance from Source");
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("{0} \t\t{1}",i,distance[i]);
            }
               
        }
    }
}

