using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        Label label1;
        TextBox textBox1;
        Button button1;
        public Form1()
        {
            InitializeComponent();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();

            label1.Text = "My first windows app";
            //label1.Visible = false;
            label1.ForeColor = Color.Red;
            label1.Size = new Size(200, 200) ;
            label1.Font = new Font("Arial" ,20);
            button1 = new Button();
            textBox1.Text = "Context";// gan du lieu cho cac controll
            button1.Text = "submit";
            textBox1.Location = new Point(label1.Location.X,label1.Location.Y+label1.Size.Height);
            button1.Location = new Point(textBox1.Location.X+textBox1.Size.Width+20,textBox1.Location.Y);
            this.Controls.Add(label1);
            this.Controls.Add((TextBox)textBox1);
            this.Controls.Add(button1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
