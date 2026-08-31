using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Autembtn_Click(object sender, EventArgs e)
        {
            Autembtn.Text = "up";

            if (Autembtn.Text == "up")
            {
                MessageBox.Show(" thank you so much for teaching us! hope you like the xtraaa code!!");
            }
        }

        private void descenditbtn_Click(object sender, EventArgs e)
        {
            descenditbtn.Text = "down";
            if (descenditbtn.Text == "down")
            {
                MessageBox.Show("DOWNNNNNNNN DOWNNN DOWNNN");
                
            }
        }

        private void mediumbtn_Click(object sender, EventArgs e)
        {
            mediumbtn.Text = "center";

            if (mediumbtn.Text == "center")
            {
                MessageBox.Show("'c#' is really fun to mess around in for sureeee");
            }

        }
    }
}
