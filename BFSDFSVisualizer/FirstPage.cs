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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            // Initialize the component of the first page.
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Create  an instance of the second page.
            Form SecondPage = new SecondPage(int.Parse(NodeText.Text));
            // Hide the first page.
            this.Hide();
            // Show the second page.
            SecondPage.Show();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
