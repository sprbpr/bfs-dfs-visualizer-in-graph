using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFSDFSVisualizer
{
    public partial class SecondPage : Form
    {
        private Graph Graph;    // The Graph class.

        public SecondPage(int node)
        {
            // Initialize the component of the second page.
            InitializeComponent();
            // Create and Initialize an instance of Graph class.
            Graph = new Graph(node);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Add Edge to Graph class every time the save button is pushed.
            Graph.AddEdge(int.Parse(Node1Text.Text), int.Parse(Node2Text.Text));
            Node1Text.Text = "";    // Clear Node1 input text.
            Node2Text.Text = "";    // Clear Node2 input text.
        }

        private void Go_Click(object sender, EventArgs e)
        {
            // Create and initialize an instance of the third page.
            Form ThirdPage = new ThirdPage(Graph);
            // Hide the second page.
            this.Hide();
            // Show the third page.
            ThirdPage.Show();
        }

        private void SecondPage_Load(object sender, EventArgs e)
        {

        }
    }

    public class Edge
    {
        public int StartNode;   // The start node of the edge.
        public int EndNode;     // The end node of the edge.
        public Edge(int startNode, int endNode)
        {
            // Create an instance of the Edge class with given parameter.
            StartNode = startNode;
            EndNode = endNode;
        }
    }

    public class Graph
    {
        public int Vertices;    // The number of vertices in graph.
        bool[] visited;         // List of Visited nodes in BFS or DFS algorithm.
        List<int> result;       // The list of final sequence of nodes in BFS or DFS algorithm.

        public List<int>[] adj; // The adjacency list of graph.

        public Graph(int v)
        {
            Vertices = v;                   // Initialize the number of vertices.
            adj = new List<int>[v];         // Initialize the adjacency list of graph.
            visited = new bool[Vertices];   // Initialize the the list of visited nodes.
            result = new List<int>();       // Initialize the the list of final result.

            // Initialize every element of the adjacency list.
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
                visited[i] = false;
            }

        }

        public void AddEdge(int u, int v)
        {
            // Adding edge in undirected graph.
            adj[u].Add(v);
            adj[v].Add(u);
        }

        public int[] BFS(int s)
        {
            // Create a queue for the BFS algorithm.
            Queue<int> queue = new Queue<int>();
            visited[s] = true;  // Mark the start node as a visited node.
            queue.Enqueue(s);   // Enqueue the start node.

            while (queue.Count != 0)
            {
                s = queue.Dequeue();    // Dequeue the first element of the queue.
                result.Add(s);          // Add dequeued node to result.

                // Enqueue every neighbor node of the dequeued node if it hasn't been visited.
                foreach (int next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }

            // Repeat the BFS algorithm for each unvisited node.
            for (int i = 0; i < visited.Length; i++)
                if (!visited[i])
                    BFS(i);

            // Return the result as an array.
            return result.ToArray();
        }

        public int[] DFS(int s)
        {
            // Create a stack for the DFS algorithm.
            Stack<int> stack = new Stack<int>();

            // Push the start node to the stack.
            stack.Push(s);

            while (stack.Count != 0)
            {
                // Pop the first element of the stack.
                s = stack.Pop();

                if (!visited[s])
                {
                    visited[s] = true;  // Mark the popped node as a visited node.
                    result.Add(s);      // Add the popped node to result.

                    // Sort the neighbor nodes of the popped node by their number.
                    adj[s] = adj[s].OrderByDescending(d => d).ToList();

                    // Push every neighbor node of the popped node if it hasn't been visited.
                    foreach (int i in adj[s])
                        if (!visited[i])
                            stack.Push(i);
                }
            }

            // Repeat the DFS algorithm for each unvisited node.
            for (int i = 0; i < visited.Length; i++)
                if (!visited[i])
                    DFS(i);

            // Return the result as an array.
            return result.ToArray();
        }
    }
}
