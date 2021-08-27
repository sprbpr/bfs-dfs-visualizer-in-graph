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
    public partial class FourthPage : Form
    {
        Graph Graph;    // The Graph class.
        int StartNode;  // The chosen start node from the user.

        public FourthPage(Graph gragh, int startNode)
        {
            // Initialize the component of the fourth page.
            InitializeComponent();
            // Initialize an instance of Graph class with created graph.
            Graph = gragh;
            // Initialize the start node with given number by user.
            StartNode = startNode;
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            // Create and initialize an instance of the final page.
            Form FinalPage = new FinalPage(Graph, Graph.BFS(StartNode));
            // Hide the fourth page.
            this.Hide();
            // Show the final page.
            FinalPage.Show();
        }

        private void DFS_Click(object sender, EventArgs e)
        {
            // Create and initialize an instance of the final page.
            Form FinalPage = new FinalPage(Graph, Graph.DFS(StartNode));
            // Hide the fourth page.
            this.Hide();
            // Show the final page.
            FinalPage.Show();
        }

        private void FourthPage_Load(object sender, EventArgs e)
        {

        }
    }
}
