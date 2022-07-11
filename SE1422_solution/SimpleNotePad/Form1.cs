using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotePad
{
    public partial class SimpleNotPad : Form
    {
        string filePath = "";
        string fileName = "new";
        public SimpleNotPad()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to save the changes?", "Simple NotePad", MessageBoxButtons.YesNoCancel);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (DialogResult == DialogResult.No)
            {
                Application.Exit();
            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {
                filePath = "";
                textBox1.Text = "";
            }
            SimpleNotPad_Load(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|C sharp file(.cs)|*.cs";
            openFileDialog.InitialDirectory = @"Desktop";
            openFileDialog.Title = "Open file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);

            }
            this.Text = Path.GetFileName(filePath);
        }



        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|C sharp file(.cs)|*.cs";
            saveFileDialog.InitialDirectory = @"Desktop";
            saveFileDialog.FileName = "*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                this.Text = saveFileDialog.FileName;
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|C sharp file(.cs)|*.cs";
            saveFileDialog.InitialDirectory = @"Desktop";
            saveFileDialog.FileName = "*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, textBox1.Text);
                this.Text = Path.GetFileName(filePath);
            }
        }

        private void SimpleNotPad_Load(object sender, EventArgs e)
        {
            this.Text = fileName;
        }
    }
}
