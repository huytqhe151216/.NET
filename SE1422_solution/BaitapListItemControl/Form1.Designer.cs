namespace BaitapListItemControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearAddmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholarshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.listMajor = new System.Windows.Forms.ListBox();
            this.YearAdmission = new System.Windows.Forms.ComboBox();
            this.YearOfBirth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.yearAddmissionDataGridViewTextBoxColumn,
            this.scholarshipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(802, 349);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearAddmissionDataGridViewTextBoxColumn
            // 
            this.yearAddmissionDataGridViewTextBoxColumn.DataPropertyName = "YearAddmission";
            this.yearAddmissionDataGridViewTextBoxColumn.HeaderText = "YearAddmission";
            this.yearAddmissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearAddmissionDataGridViewTextBoxColumn.Name = "yearAddmissionDataGridViewTextBoxColumn";
            this.yearAddmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearAddmissionDataGridViewTextBoxColumn.Width = 125;
            // 
            // scholarshipDataGridViewTextBoxColumn
            // 
            this.scholarshipDataGridViewTextBoxColumn.DataPropertyName = "Scholarship";
            this.scholarshipDataGridViewTextBoxColumn.HeaderText = "Scholarship";
            this.scholarshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scholarshipDataGridViewTextBoxColumn.Name = "scholarshipDataGridViewTextBoxColumn";
            this.scholarshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.scholarshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Lab1_LinQ.Student);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Admission Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Major";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.listMajor);
            this.panel1.Controls.Add(this.YearAdmission);
            this.panel1.Controls.Add(this.YearOfBirth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(832, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 397);
            this.panel1.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(226, 365);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listMajor
            // 
            this.listMajor.FormattingEnabled = true;
            this.listMajor.ItemHeight = 20;
            this.listMajor.Location = new System.Drawing.Point(244, 241);
            this.listMajor.Name = "listMajor";
            this.listMajor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMajor.Size = new System.Drawing.Size(150, 104);
            this.listMajor.TabIndex = 13;
            // 
            // YearAdmission
            // 
            this.YearAdmission.FormattingEnabled = true;
            this.YearAdmission.Location = new System.Drawing.Point(244, 201);
            this.YearAdmission.Name = "YearAdmission";
            this.YearAdmission.Size = new System.Drawing.Size(151, 28);
            this.YearAdmission.TabIndex = 12;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.FormattingEnabled = true;
            this.YearOfBirth.Location = new System.Drawing.Point(244, 161);
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Size = new System.Drawing.Size(151, 28);
            this.YearOfBirth.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearAddmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholarshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listMajor;
        private System.Windows.Forms.ComboBox YearAdmission;
        private System.Windows.Forms.ComboBox YearOfBirth;
        private System.Windows.Forms.Button searchButton;
    }
}
