namespace Lab2_DBConnect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtEdit = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.CbIsActive = new System.Windows.Forms.CheckBox();
            this.numericUpDownSchoalrship = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.MajorEdit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DobPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoalrship)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(820, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Major";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtDelete);
            this.panel1.Controls.Add(this.BtEdit);
            this.panel1.Controls.Add(this.BtAdd);
            this.panel1.Controls.Add(this.BtRefresh);
            this.panel1.Controls.Add(this.CbIsActive);
            this.panel1.Controls.Add(this.numericUpDownSchoalrship);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MajorEdit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DobPicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FemaleButton);
            this.panel1.Controls.Add(this.MaleButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(915, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 414);
            this.panel1.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 86);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 27);
            this.NameTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name";
            // 
            // BtDelete
            // 
            this.BtDelete.Location = new System.Drawing.Point(213, 382);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(94, 29);
            this.BtDelete.TabIndex = 15;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Location = new System.Drawing.Point(87, 382);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(94, 29);
            this.BtEdit.TabIndex = 14;
            this.BtEdit.Text = "Edit";
            this.BtEdit.UseVisualStyleBackColor = true;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(213, 347);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(94, 29);
            this.BtAdd.TabIndex = 13;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtRefresh
            // 
            this.BtRefresh.Location = new System.Drawing.Point(87, 347);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(94, 29);
            this.BtRefresh.TabIndex = 12;
            this.BtRefresh.Text = "Refresh";
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // CbIsActive
            // 
            this.CbIsActive.AutoSize = true;
            this.CbIsActive.Location = new System.Drawing.Point(137, 301);
            this.CbIsActive.Name = "CbIsActive";
            this.CbIsActive.Size = new System.Drawing.Size(72, 24);
            this.CbIsActive.TabIndex = 11;
            this.CbIsActive.Text = "Active";
            this.CbIsActive.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSchoalrship
            // 
            this.numericUpDownSchoalrship.Location = new System.Drawing.Point(118, 257);
            this.numericUpDownSchoalrship.Name = "numericUpDownSchoalrship";
            this.numericUpDownSchoalrship.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownSchoalrship.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Scholarship";
            // 
            // MajorEdit
            // 
            this.MajorEdit.FormattingEnabled = true;
            this.MajorEdit.Location = new System.Drawing.Point(114, 215);
            this.MajorEdit.Name = "MajorEdit";
            this.MajorEdit.Size = new System.Drawing.Size(151, 28);
            this.MajorEdit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Major";
            // 
            // DobPicker
            // 
            this.DobPicker.Location = new System.Drawing.Point(84, 175);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.Size = new System.Drawing.Size(250, 27);
            this.DobPicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "DOB";
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(190, 136);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(78, 24);
            this.FemaleButton.TabIndex = 4;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(84, 134);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(63, 24);
            this.MaleButton.TabIndex = 3;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(84, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(89, 27);
            this.IdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoalrship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MajorEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DobPicker;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.CheckBox CbIsActive;
        private System.Windows.Forms.NumericUpDown numericUpDownSchoalrship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}
