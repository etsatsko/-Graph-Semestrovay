using System;

namespace Graph_semestrovay
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            var v1 = new Node(1);
            var v2 = new Node(2);
            var v3 = new Node(3);
            var v4 = new Node(4);
            var v5 = new Node(5);
        
            graph.AddNodes(v1);
            graph.AddNodes(v2);
            graph.AddNodes(v3);
            graph.AddNodes(v4);
            graph.AddNodes(v5);
           
              graph.AddEdges(v1, v2);
            graph.AddEdges(v2, v3);
            graph.AddEdges(v1, v3);
            graph.AddEdges(v3, v4);
            graph.AddEdges(v1, v4);

            // Print
            var matrix = graph.GetMatrix();

            for (int i = 0; i < graph.NodeCount; i++)
            {
                Console.Write($"  | {i + 1} |");
            }

            Console.WriteLine();

            for (int i = 0; i < graph.NodeCount; i++)
                Console.Write("_______");

            Console.WriteLine();

            for (int i = 0; i < graph.NodeCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.NodeCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
