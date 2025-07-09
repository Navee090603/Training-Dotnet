using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using WinForm_02.Model; //created by me

namespace WinForm_02
{
    public partial class Form2 : Form
    {
        public List<Student> studentList = new List<Student>();
        public Form2(List<Student> students)
        {
            InitializeComponent();
            studentList = students;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentList;
        }
    }
}
