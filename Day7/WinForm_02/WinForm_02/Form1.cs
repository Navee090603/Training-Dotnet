using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_02.Model; //created by me
using System.Windows.Forms;

namespace WinForm_02
{
    public partial class Form1 : Form
    {
        //creating  List
        public List<Student> studentList = new List<Student> ();

        public Form1()
        {
            InitializeComponent();
        }

        //label
        private void studentId_Click(object sender, EventArgs e)
        {

        }

        private void studentName_Click(object sender, EventArgs e)
        {

        }

        private void studentMark_Click(object sender, EventArgs e)
        {

        }

        //textbox
        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void mark_TextChanged(object sender, EventArgs e)
        {

        }

        //button
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //creating object to get the details
                Student student = new Student
                {
                    ID = id.Text,
                    Name = name.Text,
                    Mark = float.Parse(mark.Text)
                };

                //adding to the 

                studentList.Add(student);

                //confirmation Message
                MessageBox.Show("Details Added!");

                //clearing the message

                id.Clear();
                name.Clear();
                mark.Clear();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Mark.", "Input Error");
            }

            foreach (var item in studentList)
            {
                Console.WriteLine(item.Name);
            }


        }

        private void view_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(studentList);
            form2.Show();

        }

        private void rank_Click(object sender, EventArgs e)
        {

        }
    }
}
