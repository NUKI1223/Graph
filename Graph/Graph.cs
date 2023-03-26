using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        List<Vertex> V = new List<Vertex>();
        List<Edge> E = new List<Edge>();
        public int VertexCount => V.Count;
        public int EdgeCount => E.Count;
        public void AddVertex(params Vertex[] vertex)
        {
            foreach (var item in vertex)
            {
                V.Add(item);
            }
            
        }
        
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }
        public int[,] GetMatrix()
        {
            var matrix = new int[V.Count, V.Count];
            foreach (var edge in E)
            {
                var row = edge.From.Number-1;
                var collum = edge.To.Number-1;
                matrix[row, collum] = edge.Weight;
            }


            return matrix;
        }
        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var result = new List<Vertex>();
            foreach (var edge in E)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }
        public bool Wave(Vertex start, Vertex finish)
        {
            
            var list = new List<Vertex>();
            
            list.Add(start);
            for (int i = 0; i < list.Count; i++)
            {

                var vertex = list[i];
                foreach (var v in GetVertexList(vertex))
                {
                    if (!v.IsVisited)
                    {
                        v.IsVisited = true;
                        list.Add(v);
                    }
                    

                }
            }
            
            return list.Contains(finish);
        }
    }
}
