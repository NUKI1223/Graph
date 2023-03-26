using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            var graph = new Graph();
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(6);

            graph.AddVertex(v1, v2, v3, v4, v5, v6, v7);
            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);
            GraphMatrix(graph);
            Console.WriteLine();
            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            Console.WriteLine(graph.Wave(v1, v5));
            Console.WriteLine(graph.Wave(v2,v4));
        }

        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number+": ");
            foreach (var v in graph.GetVertexList(vertex))
            {
                Console.Write(v.Number+", ");
            }
            Console.WriteLine();
        }

        private static void GraphMatrix(Graph graph)
        {
            var matrix = graph.GetMatrix();

            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________________");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($" | {i + 1} | ");

            }
            Console.WriteLine();
        }
    }
}
