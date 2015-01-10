namespace ESIS
{
    partial class appoint_create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appoint_create));
            this.label1 = new System.Windows.Forms.Label();
            this.appointno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Appointee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.RichTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment no";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // appointno
            // 
            this.appointno.Location = new System.Drawing.Point(145, 13);
            this.appointno.Margin = new System.Windows.Forms.Padding(4);
            this.appointno.Name = "appointno";
            this.appointno.Size = new System.Drawing.Size(106, 26);
            this.appointno.TabIndex = 1;
            this.appointno.TextChanged += new System.EventHandler(this.appointno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Member To See";
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(145, 149);
            this.staff.Margin = new System.Windows.Forms.Padding(4);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(305, 26);
            this.staff.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Appointment Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Default;
            this.date1.CustomFormat = "yyyy/MM/dd";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(426, 13);
            this.date1.Name = "date1";
            this.date1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date1.Size = new System.Drawing.Size(134, 26);
            this.date1.TabIndex = 5;
            this.date1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appointee";
            // 
            // Appointee
            // 
            this.Appointee.Location = new System.Drawing.Point(145, 103);
            this.Appointee.Name = "Appointee";
            this.Appointee.Size = new System.Drawing.Size(305, 26);
            this.Appointee.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact No";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(145, 66);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(115, 26);
            this.contact.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time for appointment";
            // 
            // timepicker
            // 
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepicker.Location = new System.Drawing.Point(426, 60);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(91, 26);
            this.timepicker.TabIndex = 11;
            this.timepicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Purpose";
            // 
            // purpose
            // 
            this.purpose.Location = new System.Drawing.Point(145, 203);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(230, 68);
            this.purpose.TabIndex = 13;
            this.purpose.Text = "";
            this.purpose.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(21, 39);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 33);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(145, 39);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 33);
            this.viewbtn.TabIndex = 17;
            this.viewbtn.Text = "view";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewbtn);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Location = new System.Drawing.Point(31, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 96);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // appoint_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timepicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Appointee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appointno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "appoint_create";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "create new appointment record";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.appointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appointno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Appointee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox purpose;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.GroupBox groupBox1;

        

    }
}

