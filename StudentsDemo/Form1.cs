using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentDal _studentDal = new StudentDal();

        private void Form1_Load(object sender, EventArgs e)
        {
           dgwStudent.DataSource = _studentDal.GetAll();
        }
        
        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxFNameUpdate.Text = dgwStudent.CurrentRow.Cells[1].Value.ToString();
            tbxLnameUpdate.Text = dgwStudent.CurrentRow.Cells[2].Value.ToString();
            tbxnumUpdate.Text = dgwStudent.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           _studentDal.Add(new Student
           {
               FirsName = tbxFirstName.Text,
               LastName = tbxLastname.Text,
               Number =Convert.ToInt32(tbxNumber.Text) 
           });
           dgwStudent.DataSource = _studentDal.GetAll();
            MessageBox.Show("student added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _studentDal.Update(new Student
            {
               Id = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value),
               FirsName = tbxFNameUpdate.Text,
               LastName = tbxLnameUpdate.Text,
               Number = Convert.ToInt32(tbxnumUpdate.Text)
            });
            dgwStudent.DataSource = _studentDal.GetAll();
            MessageBox.Show("student updated!");
    }
    }
}
