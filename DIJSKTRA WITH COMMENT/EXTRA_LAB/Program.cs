using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijsktra
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=0;
            //PriorityQueue q=new PriorityQueue();
            //q.enqueue(new Vertex(0, 10));
            //q.enqueue(new Vertex(1, 24));
            //q.enqueue(new Vertex(2, 30));
            //q.enqueue(new Vertex(3, 40));
            //Vertex min = q.ExtractMin();
            //Console.WriteLine("ID: {0} WEIGHT:{1}", min.id, min.weight);
            //Vertex min1 = q.ExtractMin();
            //Console.WriteLine("ID: {0} WEIGHT:{1}", min1.id, min1.weight);
            //q.enqueue(3);
            //q.enqueue(5);
            //q.enqueue(7);
            //q.enqueue(4);
            //q.enqueue(2);
            //a = q.ExtractMin();
            //Console.WriteLine("Min extract {0}", a);
            Graph g = new Graph(5);
            g.AddDirectedEdge(0, 1, 10);
            g.AddDirectedEdge(0, 2, 5);
            g.AddDirectedEdge(1, 3, 1);
            g.AddDirectedEdge(1, 2, 2);
            g.AddDirectedEdge(2, 1, 3);
            g.AddDirectedEdge(2, 3, 9);
            g.AddDirectedEdge(2, 4, 2);
            g.AddDirectedEdge(3, 4, 4);
            g.AddDirectedEdge(4, 3, 6);
            g.AddDirectedEdge(4, 0, 7);

            g.DijkstraShortestPath(0);

        }
    }

    public class Vertex
    {
        public int id;
        public int weight;
        public bool visited = false;

        public Vertex(int IDs, int w)
        {
            id = IDs;
            weight = w;
        }
    }

    public class PriorityQueue
    {
        List<Vertex> elements;
     //also used linked list.......
        public PriorityQueue()
        {
            elements = new List<Vertex>();
        }
        public Vertex ExtractMin()
        {
            //x=find the location of minimum element.......
            int x = FindMin();
            //y=store the element at xth location
            Vertex y = elements[x];
            //remove the element from xth location....
            elements.RemoveAt(x);
            //return y
            return y;
        }
        private int FindMin()
        {
            if(elements.Count<0)
            {
                return -1;
            }
            //initially:first element is minimum.......
            int min = elements[0].weight;
            int loc=0;
            //iterarte each element......
            for(int i=1;i<elements.Count;i++)
            {
                //if the element is less than minimum,
                if(min>elements[i].weight)
                {
                    //update min and update location......
                    min = elements[i].weight;
                    loc = i;
                }
                
            }
            //return location
            return loc;
        }
        public bool isempty()
        {
            return elements.Count == 0 ? true : false;
        }
        public void enqueue(Vertex e)
        {
            //add at last..
            //list.add()...
            elements.Add(e);
            
        }

        public Vertex dequeue()
        {
            Vertex x = elements[0];
            //remove at 0th location
            elements.RemoveAt(0);
         
            return x;
        }
    }

    public class Graph
    {
        int numberOfVerticies;
        private int[,] adjMatrix;

        public Graph(int numOfVertices)
        {
            this.numberOfVerticies = numOfVertices;
            adjMatrix = new int[numberOfVerticies, numberOfVerticies];
        }

        public void AddDirectedEdge(int source, int destination, int weight = 0)
        {
            adjMatrix[source, destination] = weight;
        }

        public int[] GetDirectedNeighbours(int source)
        {
            List<int> neg = new List<int>();

            for (int i = 0; i < numberOfVerticies; i++)
            {
                if (adjMatrix[source, i] > 0)
                    neg.Add(i);
            }

            return neg.ToArray();
        }

        public void DijkstraShortestPath(int source)
        {
            //initialize:.......
            PriorityQueue pq = new PriorityQueue();
          
            //create an array for distance.........
            Vertex[] distance = new Vertex[numberOfVerticies];
            // for each vertex.......
            for(int i=0;i<numberOfVerticies;i++)
            {
                //create an object:vertex.......
                //set weight to infinity..
                distance[i] = new Vertex(i, int.MaxValue);   
            }
            //set source=0......
            distance[source].weight = 0;

            //for each vertex.....
            foreach(Vertex a in distance)
            {
                //store each vertex in priority p.queue...........
                pq.enqueue(a);
            }
             //while p.queue is not empty.......
            while(!pq.isempty())
            {
                //extract min....
                Vertex v = pq.ExtractMin();
                //get neighbours.........
                int[] neg = GetDirectedNeighbours(v.id);
                
                foreach(int n in neg)
                {
                    int sw=v.weight  ;//source weight
                    int dw = distance[n].weight;//destination weight
                        int ew=adjMatrix[v.id,n]    ;//edge weight
                    //relax each neighbours..........
                    if(dw>sw+ew)
                    {
                        distance[n].weight = sw + ew;
                    }
                }
               
            }
            foreach (Vertex x in distance)
            {
                Console.WriteLine("ID:{0} WEIGHT:{1}", x.id, x.weight);
                Console.WriteLine();
            }
            
        }
    }
}
