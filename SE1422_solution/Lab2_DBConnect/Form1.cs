using Lab2_DBConnect.DataAccess;
using Lab2_DBConnect.Logics;
using Lab2_DBConnect.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_DBConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormAction();
        }
        public void FormAction()
        {
            comboBox1.SelectionChangeCommitted += (sender, e) =>
            {
                Major major = (Major)comboBox1.SelectedItem;
                if (major.Code == "All")
                {
                    dataGridView1.DataSource = StudentManager.GetAllStudents();
                }
                else
                {
                    dataGridView1.DataSource = StudentManager.GetStudentByMajor(major.Code);
                }
            };
            //if dataGridView1 selected row changed, then show detail of selected student
            dataGridView1.SelectionChanged += (sender, e) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Student student = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                    LoadDataToFields(student, false);
                }
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentManager.GetAllStudents();
            List<Major> majors = StudentManager.getAllMajors();
            majors.Insert(0, new Major("All", "All"));
            comboBox1.DataSource = majors.ToList();
            IdTextBox.Enabled = false;
            MajorEdit.DataSource = majors;
            MaleButton.Checked = true;
        }

        private void LoadDataToFields(Student student, bool isIdEnable)
        {
            IdTextBox.Text = student.Id.ToString();
            IdTextBox.Enabled = isIdEnable;
            NameTextBox.Text = student.Name;
            if (student.Gender)
            {
                FemaleButton.Checked = true;
            }
            else
            {
                MaleButton.Checked = true;
            }
            MajorEdit.SelectedItem = student.Major;
            DobPicker.Value = student.Dob;
            numericUpDownSchoalrship.Value = Convert.ToDecimal(student.Scholarship);
            CbIsActive.Checked = student.Active;
        }
        private Student GetStudentFromField()
        {
            Student student = new Student();
            try
            {
                student.Id = Convert.ToInt32(IdTextBox.Text);
            }
            catch (Exception ex)
            {

            };
            student.Name = NameTextBox.Text;
            student.Major = (Major)MajorEdit.SelectedItem;
            student.Dob = DobPicker.Value;
            student.Scholarship = Convert.ToDouble(numericUpDownSchoalrship.Value);
            student.Active = CbIsActive.Checked;
            student.Gender = MaleButton.Checked ? false : true;
            return student;
        }
        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please choose a student to edit");
            }
            else
            {
                try
                {
                    Student s = GetStudentFromField();
                    if (StudentManager.UpdateStudent(s) == 0)
                    {
                        MessageBox.Show("Update fail.");
                    }
                    else
                    {
                        MessageBox.Show("Update successfully");
                        dataGridView1.DataSource = StudentManager.GetAllStudents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please choose a student to edit");
                }
            }
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            LoadDataToFields(new Student(), false);
            dataGridView1.DataSource = StudentManager.GetAllStudents();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = GetStudentFromField();
                if (StudentManager.InsertStudent(s) == 0)
                {
                    MessageBox.Show("Insert fail.");
                }
                else
                {
                    MessageBox.Show("Insert successfully");
                    dataGridView1.DataSource = StudentManager.GetAllStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Major is not All.");
            }

        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = GetStudentFromField();
                if (StudentManager.DeleteStudent(s)==0)
                {
                    MessageBox.Show("Please choose a student to delete.");
                }
                else
                {
                    MessageBox.Show("Delete successfully.");
                    dataGridView1.DataSource= StudentManager.GetAllStudents();
                }
            }catch (Exception ex)
            {

            }
        }
    }
}
