using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFSDFSVisualizer
{
    public partial class FinalPage : Form
    {
        private Graph Graph;                    // The Graph class.
        private int[] NodeSequense;             // The final sequence of nodes in chosen algorithm.
        private PointF Center;                  // The center of the page.
        private const float BaseRadius = 240;   // The distance between each node and the center of the page.

        public FinalPage(Graph graph, int[] nodeSequense)
        {
            // Initialize the component of the final page.
            InitializeComponent();
            // Determine the center of the page.
            Center = new PointF(this.ClientSize.Width / 2F, this.ClientSize.Height / 2F);
            // Initialize an instance of Graph class with created graph.
            Graph = graph;
            // Initialize the final sequence of nodes in chosen algorithm.
            NodeSequense = nodeSequense;
        }

        private void FinalPage_Paint(object sender, PaintEventArgs e)
        {
            // Draw all the edges in graph.
            DrawEdges(Color.Black, e);
            // Draw all the nodes in graph.
            DrawNodes(Color.LightBlue, Color.DarkBlue, e);
            // Color the nodes in order of the final result.
            foreach (int nn in NodeSequense)
            {
                DrawNode(nn, Color.LightGreen, Color.DarkGreen, e);
                Thread.Sleep(2000);
            }
        }

        private void DrawNodes(Color nodeColor, Color numberColor, PaintEventArgs e)
        {
            // Draw all the nodes in graph.
            for (int i = 0; i < Graph.Vertices; i++)
                DrawNode(i, nodeColor, numberColor, e);
        }

        private void DrawNode(int nodeNumber, Color nodeColor, Color numberColor, PaintEventArgs e)
        {
            // Color the given node.
            DrawFilledCircle((float)(nodeNumber * 2 * Math.PI / Graph.Vertices), nodeColor, e);
            // Rewrite the node number.
            DrawString(nodeNumber.ToString(), (float)(nodeNumber * 2 * Math.PI / Graph.Vertices), numberColor, e);
        }

        private void DrawEdges(Color color, PaintEventArgs e)
        {
            for(int i = 0; i < Graph.adj.Count(); i++)
                foreach (int n2 in Graph.adj[i])
                    DrawEdge(i, n2, color, e);
        }

        private void DrawEdge(int node1, int node2, Color color, PaintEventArgs e)
        {
            // Draw all the edges in graph.
            PointF Node1 = FindPoint(node1);
            PointF Node2 = FindPoint(node2);
            e.Graphics.DrawLine(new Pen(Color.Black), Node1, Node2);
        }

        private PointF FindPoint(int node)
        {
            // Return the position of the given node in the page.
            return new PointF(Center.X +
                (float)(BaseRadius * Math.Cos((float)(node * 2 * Math.PI / Graph.Vertices))),
                           Center.Y -
                (float)(BaseRadius * Math.Sin((float)(node * 2 * Math.PI / Graph.Vertices))));
        }

        private void DrawFilledCircle(float t, Color color, PaintEventArgs e)
        {
            const float radius = 20;    // The radius of each node.
            // Determine the circle by a rectangle.
            PointF rectOrigin = 
                new PointF(Center.X + (float)(BaseRadius * Math.Cos(t)) - radius,
                           Center.Y - (float)(BaseRadius * Math.Sin(t)) - radius);
            RectangleF rectangle = new RectangleF(rectOrigin, new SizeF(radius * 2F, radius * 2F));
            // Color the circle of the node.
            e.Graphics.FillEllipse(new SolidBrush(color), rectangle);
        }

        private void DrawString(string number, float t, Color color, PaintEventArgs e)
        {
            const int marigin = 10;                     // The margin of the string in the cirle of the node.
            const int size = 15;                        // The font size.
            FontFamily ff = new FontFamily("Arial");    // Determine the font of the node number.
            // Determine the box of string.
            PointF rectOrigin =
                new PointF(Center.X + (float)(BaseRadius * Math.Cos(t)) - marigin,
                           Center.Y - (float)(BaseRadius * Math.Sin(t)) - marigin);
            // Write the number of the node in the center of the node.
            e.Graphics.DrawString(number, new Font(ff, size), new SolidBrush(color), rectOrigin);
        }

        private void FinalPage_Load(object sender, EventArgs e)
        {

        }
    }
}
