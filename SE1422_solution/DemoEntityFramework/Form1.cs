using DemoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void load()
        {
            using (var context = new Lab2Context())
            {
                dataGridView1.DataSource = context.Students.ToList();
                List<string>listMajor = context.Majors.Select(x=>x.Title).ToList();
                listMajor.Add("None");
                cbMajor.DataSource = listMajor;
                cbMajor.SelectedIndex = listMajor.Count-1;
                cbYOB.DataSource = context.Students.Select(x=>x.Dob.Value.Year).Distinct().ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }
        private static string GetMajorCodeByTitle(string title)
        {
            using (var context = new Lab2Context())
            {
                foreach (var major in context.Majors)
                {
                    if (major.Title == title) return major.Code;
                }
            }
            return null;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            using (var context = new Lab2Context())
            {
                List<Student> students = new List<Student>();
                students = context.Students.ToList();
                students= students.Where(x=>x.Name.Contains(textBox1.Text)).ToList();
                students = students.Where(x => x.Dob.Value.Year == Convert.ToInt32(cbYOB.SelectedValue)).ToList();
                if (!cbMajor.SelectedValue.ToString().Equals("None")) ;
                {
                    students = students.Where(x => x.Major == GetMajorCodeByTitle(cbMajor.SelectedValue.ToString())).ToList();
                }
                dataGridView1.DataSource = students;
            }
            
        }
    }
}
