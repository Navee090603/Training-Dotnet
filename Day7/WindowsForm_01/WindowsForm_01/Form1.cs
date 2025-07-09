using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


        //button

        public void Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "Naveen" && password == "123")
            {
                MessageBox.Show("Login successful!\n\nEmp ID: 1806664\nName: Naveen T\nSalary: ₹75,000\nProject: Healthcare CRM");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

   
        //username and password
  
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        //label
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
