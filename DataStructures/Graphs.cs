using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Example
    {
        /*public static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            Graph graph = new Graph(6);

            graph.AddEdge(six, four);
            graph.AddEdge(four, five);
            graph.AddEdge(four, three);
            graph.AddEdge(three, two);
            graph.AddEdge(five, two);
            graph.AddEdge(two, one);
            graph.AddEdge(five, one);

        }*/
        public static void Main(string[] args)
        {

        }
    }

    class Graph
    {
        bool[,] adjacencyMatrix;

        int NumberOfVertices { get; set; }

        public Graph(int size)
        {
            NumberOfVertices = size;
            adjacencyMatrix = new bool[size, size];
        }

        public void AddEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = true;
            adjacencyMatrix[j, i] = true;
        }

        public void RemoveEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = false;
            adjacencyMatrix[j, i] = false;
        }

        public bool IsAdjacent(int i, int j)
        {
            return adjacencyMatrix[i, j];
        }
    }


    //used for Graphs as an adjacency list
    /*class Node
    {
        public List<object> Neighbors { get; set; }
        public int Data;
        public Node(int data)
        {
            Data = data;
        }
    }*/

    /*class Graph
    {
        public int NumberOfVertices { get; set; }

        public List<Node> Vertices { get; set; }

        public Graph(int size)
        {
            NumberOfVertices = size;
            Vertices = new List<Node>();

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Vertices[i] = new Node();
            }
        }

        public void AddEdge(Node source, Node destination)
        {
            source.Neighbors.Add(destination);
            destination.Neighbors.Add(source);
        }
        public void RemoveEdge(Node source, Node destination)
        {
            source.Neighbors.Remove(destination);
            destination.Neighbors.Remove(source);
        }

        public bool isAdjacent(Node node1, Node node2)
        {
            return node1.Neighbors.Contains(node2);
        }
    }*/
}
