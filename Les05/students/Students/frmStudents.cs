using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            Student student1 = new Student(1, "Tess", "Tickles", new DateTime(1985, 10, 30), "Programmeren");
            Student student2 = new Student(2, "Hugh", "Jass", new DateTime(1990, 1, 25), "Programmeren");
            Student student3 = new Student(3, "Mike", "Rotch", new DateTime(1995, 5, 6), "Besturingssystemen");

            cbxStudents.Items.Add(student1);
            cbxStudents.Items.Add(student2);
            cbxStudents.Items.Add(student3);
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
            // school aanmaken
            //School school = new School();
            //MessageBox.Show(school.Name);
            MessageBox.Show(School.Name);
        }

        private void CbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)cbxStudents.SelectedItem;

            txtName.Text = student.LastName + " " + student.FirstName;
            txtAge.Text = student.CalculateAge().ToString();
            txtCourse.Text = student.Course;
        }


    }
}
