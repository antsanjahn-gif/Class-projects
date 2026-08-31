using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_load(object sender, EventArgs e)
        {
            MessageBox.Show("the app sees this inside the age box: '" + txtAgebox.Text + "'");

            // tex from input

            string username =txtName.Text;
            string ageInput = txtAgebox.Text;


            // check if age is a number
            if (int.TryParse(ageInput, out int userAge))

            {

                // showing greeting 
                lblmsg.Text = "hello, " + username + "! You are " + userAge +" years old. ";
            }

            else
            {

                // showing eroor if not a number
                lblmsg.Text = "Please enter a valid number for your age.";



            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Leave this completely blank!
            // It is just here to satisfy Visual Studio so your app can run.
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }
    }
}
