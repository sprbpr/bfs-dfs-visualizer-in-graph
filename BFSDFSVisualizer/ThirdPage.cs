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
    public partial class ThirdPage : Form
    {
        Graph Graph;    // The Graph class.

        public ThirdPage(Graph gragh)
        {
            // Initialize the component of the third page.
            InitializeComponent();
            // Initialize an instance of Graph class with created graph.
            Graph = gragh;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            // Create and initialize an instance of the fourth page.
            Form FourthPage = new FourthPage(Graph, int.Parse(StartText.Text));
            // Hide the third page.
            this.Hide();
            // Show the fourth page.
            FourthPage.Show();
        }

        private void ThirdPage_Load(object sender, EventArgs e)
        {

        }
    }
}
