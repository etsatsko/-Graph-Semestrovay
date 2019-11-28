using System;
using System.Collections.Generic;
using System.Text;

namespace Graph_semestrovay
{
    class Graph
    {
        List<Node> Nodes = new List<Node>();
        List<Edge> Edges = new List<Edge>();

        public int NodeCount => Nodes.Count;
        public int EdgeCount => Edges.Count;

        public void AddNodes(Node node)
        {
            Nodes.Add(node);
        }

        public void AddEdges(Node from, Node to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }


        public int[,] GetMatrix()
        {
            var matrix = new int[Nodes.Count, Nodes.Count];

            foreach(var edge in Edges)
            {
                var row = edge.From.Number-1;
                var column = edge.To.Number-1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }
    }
}
