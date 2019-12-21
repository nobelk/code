using System;

namespace AllPairShortestPath
{


    public class Graph
    {
        private int[] vertices;
        private int[,] edges;

        public Graph(int numberOfVertices)
        {
            this.vertices = new int[numberOfVertices];
            this.edges = new int[numberOfVertices,numberOfVertices];

            for(int index=0; index<numberOfVertices; index++)
            {
                this.vertices[index]=index;
            }


            for(int i=0; i<numberOfVertices; i++)
            {
                for(int j=0; j<numberOfVertices; j++)
                {
                    this.edges[i,j] = int.MaxValue;
                }
            }
        }

        public void AddEdge(int u, int v, int weight)
        {
            this.edges[u,v] = weight;
        }


        public int[,] FindAllPairShortestPath()
        {
            // initialize return sp matrix
            int[,] sp = new int[this.vertices.Length, this.vertices.Length];

            for(int i=0; i<this.vertices.Length; i++)
            {
                for(int j=0; j<this.vertices.Length; j++)
                {
                    sp[i,j] = this.edges[i,j];
                }
            }

            /** Mistake 1: use multidimesional array as x[i,j] */
            /** Mistake 2: while calculating shortest paths, initialize and always use the new adjacency matrix NOT original matrix */
            for(int k=0; k<this.vertices.Length; k++)
            {
                for(int i=0; i<this.vertices.Length; i++)
                {
                    for(int j=0; j<this.vertices.Length; j++)
                    {

                        // calculate path i~>j through vertex k
                        int spThroughK = 0;
                        if(sp[i,k]==int.MaxValue
                        ||
                        sp[k,j]==int.MaxValue)
                        {
                            spThroughK = int.MaxValue;
                        }
                        else
                        {
                            spThroughK = sp[i,k] + sp[k,j];
                        }

                        // verify shortest path through i~>j
                        if(sp[i,j] > spThroughK)
                        {
                            sp[i,j] = spThroughK;
                        }

                    }
                }
            }


            return sp;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create graph");

            // Create a graph given in the above diagram.  Here vertex numbers are
            // 0, 1, 2, 3, 4, 5 with following mappings:
            // 0=r, 1=s, 2=t, 3=x, 4=y, 5=z
            Graph g = new Graph(6);
            g.AddEdge(0, 1, 5);
            g.AddEdge(0, 2, 3);
            g.AddEdge(1, 3, 6);
            g.AddEdge(1, 2, 2);
            g.AddEdge(2, 4, 4);
            g.AddEdge(2, 5, 2);
            g.AddEdge(2, 3, 7);
            g.AddEdge(3, 5, 1);
            g.AddEdge(3, 4, -1);
            g.AddEdge(4, 5, -2);


            int[,] sp = g.FindAllPairShortestPath();

            for(int i=0; i<6; i++)
            {
                Console.Write("[");
                for(int j=0; j<6; j++)
                {
                    Console.Write(sp[i,j]+" ");
                }
                Console.Write("]\n");
            }
        }
    }
}
