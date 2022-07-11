using Lab1_LinQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapListItemControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> listStudent = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text document|*.txt";
            openFileDialog.InitialDirectory = @"C:\Users\ADMIN\source\repos\SE1422_solution\BaitapListItemControl";
            openFileDialog.Title = "Open file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                Student student = new Student();
                student.ReadFromFile(openFileDialog.FileName);
                listStudent = student.students;

                dataGridView1.DataSource = listStudent;

                //load year of birth.
                List<Int32> list = new List<Int32>();
                //list = student.GetStudentYearOfBirth();
                //list.Sort();
                YearOfBirth.DataSource = student.GetStudentYearOfBirth();
                YearOfBirth.SelectedIndex = student.GetStudentYearOfBirth().Count - 1;
                //foreach (Int32 year in list)
                //{
                //    YearOfBirth.Items.Add(year);
                //}
                //load year of admission.

                //List<Int32> listYearAdmission = new List<Int32>();
                //listYearAdmission = student.GetStudentYearOfAdmission();
                //listYearAdmission.Sort();
                //foreach(Int32 yearAdmission in listYearAdmission)
                //{
                //    YearAdmission.Items.Add(yearAdmission);
                //}
                YearAdmission.DataSource = student.GetStudentYearOfAdmission();
                YearAdmission.SelectedIndex = student.GetStudentYearOfAdmission().Count - 1;
                //load list major
                listMajor.DataSource = student.GetListMajor();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Student student = new Student();
            //student.FilterStudent(textBox2.Text,textBox3.Text,YearOfBirth.Text,YearAdmission.Text,listMajor.Text);
            //dataGridView1.DataSource=student.students;
            List<Student> studentSearch = listStudent;
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                studentSearch = studentSearch.Where(student => student.Id == Convert.ToInt32(textBox2.Text)).ToList();
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                studentSearch = studentSearch.Where(s => s.Name.ToLower().Contains(textBox3.Text.ToLower())).ToList();
            }
            //if (!YearOfBirth.SelectedText.Equals("All"))
            //{
            //    studentSearch = studentSearch.Where(s => s.Dob.Year == Convert.ToInt32(YearOfBirth.SelectedText)).ToList();
            //}
            if (!YearOfBirth.SelectedValue.Equals("All"))
            {
                studentSearch = studentSearch.Where(s => s.Dob.Year == Convert.ToInt32(YearOfBirth.SelectedValue)).ToList();
            }
            if (!YearAdmission.SelectedValue.Equals("All"))
            {
                studentSearch = studentSearch.Where(s=> s.YearAddmission == Convert.ToInt32(YearAdmission.SelectedValue)).ToList();
            }
            studentSearch = studentSearch.Where(s => listMajor.SelectedItems.Contains(s.Major)).ToList();
            dataGridView1.DataSource = studentSearch;
        }

        
    }
}
