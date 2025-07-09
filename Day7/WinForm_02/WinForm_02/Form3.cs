using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_02.Model;//created by me

namespace WinForm_02
{
    public partial class Form3 : Form
    {
        public Form3(List<Student> students)
        {
            var sortedList = students
                         .OrderByDescending(s => s.Mark)
                         .Select((s, index) => new
                         {
                             Rank = index + 1,
                             Name = s.Name,
                             Marks = s.Mark
                         })
                         .ToList();

            // Bind the result to the DataGridView
            dataGridViewRanks.DataSource = sortedList;
        }

        private void dataGridViewRanks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
