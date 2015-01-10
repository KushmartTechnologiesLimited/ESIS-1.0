namespace ESIS.Finances
{
    partial class RecordTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.admNoText = new System.Windows.Forms.TextBox();
            this.admissionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bankSlipCheckBox = new System.Windows.Forms.CheckBox();
            this.mpesaCheckBox = new System.Windows.Forms.CheckBox();
            this.paidTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.namecomboBox = new System.Windows.Forms.ComboBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by Admission Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admNoText
            // 
            this.admNoText.Location = new System.Drawing.Point(158, 5);
            this.admNoText.Name = "admNoText";
            this.admNoText.Size = new System.Drawing.Size(151, 20);
            this.admNoText.TabIndex = 1;
            this.admNoText.TextChanged += new System.EventHandler(this.admNoText_TextChanged);
            // 
            // admissionButton
            // 
            this.admissionButton.Location = new System.Drawing.Point(323, 5);
            this.admissionButton.Name = "admissionButton";
            this.admissionButton.Size = new System.Drawing.Size(69, 21);
            this.admissionButton.TabIndex = 2;
            this.admissionButton.Text = "Find";
            this.admissionButton.UseVisualStyleBackColor = true;
            this.admissionButton.Click += new System.EventHandler(this.admissionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.classTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 308);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datePicker);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.detailsTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bankSlipCheckBox);
            this.panel2.Controls.Add(this.mpesaCheckBox);
            this.panel2.Controls.Add(this.paidTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.balanceTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.paymentComboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 214);
            this.panel2.TabIndex = 4;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(135, 167);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(144, 30);
            this.detailsTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Additional Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Payment Method";
            // 
            // bankSlipCheckBox
            // 
            this.bankSlipCheckBox.AutoSize = true;
            this.bankSlipCheckBox.Location = new System.Drawing.Point(208, 139);
            this.bankSlipCheckBox.Name = "bankSlipCheckBox";
            this.bankSlipCheckBox.Size = new System.Drawing.Size(71, 17);
            this.bankSlipCheckBox.TabIndex = 7;
            this.bankSlipCheckBox.Text = "Bank Slip";
            this.bankSlipCheckBox.UseVisualStyleBackColor = true;
            // 
            // mpesaCheckBox
            // 
            this.mpesaCheckBox.AutoSize = true;
            this.mpesaCheckBox.Location = new System.Drawing.Point(135, 138);
            this.mpesaCheckBox.Name = "mpesaCheckBox";
            this.mpesaCheckBox.Size = new System.Drawing.Size(57, 17);
            this.mpesaCheckBox.TabIndex = 6;
            this.mpesaCheckBox.Text = "mpesa";
            this.mpesaCheckBox.UseVisualStyleBackColor = true;
            this.mpesaCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // paidTextBox
            // 
            this.paidTextBox.Location = new System.Drawing.Point(135, 103);
            this.paidTextBox.Name = "paidTextBox";
            this.paidTextBox.Size = new System.Drawing.Size(144, 20);
            this.paidTextBox.TabIndex = 5;
            this.paidTextBox.Leave += new System.EventHandler(this.paidTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount Paid :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(135, 75);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(144, 20);
            this.balanceTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(135, 19);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(144, 21);
            this.paymentComboBox.TabIndex = 1;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payment For: ";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(158, 51);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(146, 20);
            this.classTextBox.TabIndex = 3;
            this.classTextBox.TextChanged += new System.EventHandler(this.classTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Academic Level";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(47, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 44);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(258, 364);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(106, 45);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print and Save";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Or Last Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(500, 5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(175, 20);
            this.nameText.TabIndex = 8;
            // 
            // namecomboBox
            // 
            this.namecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namecomboBox.FormattingEnabled = true;
            this.namecomboBox.Location = new System.Drawing.Point(410, 28);
            this.namecomboBox.Name = "namecomboBox";
            this.namecomboBox.Size = new System.Drawing.Size(354, 21);
            this.namecomboBox.TabIndex = 9;
            this.namecomboBox.SelectedIndexChanged += new System.EventHandler(this.namecomboBox_SelectedIndexChanged);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(711, 5);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 10;
            this.nameButton.Text = "Find";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(770, 28);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 18;
            this.displayListBox.Location = new System.Drawing.Point(441, 52);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(404, 292);
            this.displayListBox.TabIndex = 12;
            this.displayListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(441, 344);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(404, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Date Paid";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(135, 49);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 12;
            // 
            // RecordTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 421);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.namecomboBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admissionButton);
            this.Controls.Add(this.admNoText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RecordTransaction";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Fees";
            this.Load += new System.EventHandler(this.RecordTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admNoText;
        private System.Windows.Forms.Button admissionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox bankSlipCheckBox;
        private System.Windows.Forms.CheckBox mpesaCheckBox;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.ComboBox namecomboBox;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label10;
    }
}