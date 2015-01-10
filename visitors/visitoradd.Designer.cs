namespace ESIS.visitors
{
    partial class visitoradd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitoradd));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.card = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addrs = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.TextBox();
            this.person = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.intime = new System.Windows.Forms.DateTimePicker();
            this.outtime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comments = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.nume = new System.Windows.Forms.TextBox();
            this.viewbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(212, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(111, 74);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(212, 20);
            this.card.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // addrs
            // 
            this.addrs.Location = new System.Drawing.Point(111, 124);
            this.addrs.Name = "addrs";
            this.addrs.Size = new System.Drawing.Size(212, 20);
            this.addrs.TabIndex = 5;
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(111, 169);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(212, 20);
            this.cont.TabIndex = 6;
            // 
            // person
            // 
            this.person.Location = new System.Drawing.Point(111, 216);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(212, 20);
            this.person.TabIndex = 7;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(493, 26);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 20);
            this.date.TabIndex = 9;
            // 
            // intime
            // 
            this.intime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.intime.Location = new System.Drawing.Point(493, 74);
            this.intime.Name = "intime";
            this.intime.ShowUpDown = true;
            this.intime.Size = new System.Drawing.Size(123, 20);
            this.intime.TabIndex = 10;
            // 
            // outtime
            // 
            this.outtime.CustomFormat = "";
            this.outtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outtime.Location = new System.Drawing.Point(451, 34);
            this.outtime.Name = "outtime";
            this.outtime.ShowUpDown = true;
            this.outtime.Size = new System.Drawing.Size(145, 20);
            this.outtime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of visitors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Person to see";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "In-Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Out-Time";
            // 
            // purpose
            // 
            this.purpose.Location = new System.Drawing.Point(493, 121);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(200, 115);
            this.purpose.TabIndex = 18;
            this.purpose.Text = "";
            this.purpose.TextChanged += new System.EventHandler(this.purpose_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "purpose";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comments);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.outtime);
            this.groupBox1.Location = new System.Drawing.Point(42, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 152);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILL WHEN LEAVING";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(96, 46);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(214, 96);
            this.comments.TabIndex = 19;
            this.comments.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Comments";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(319, 482);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(92, 27);
            this.savebtn.TabIndex = 22;
            this.savebtn.Text = "save ";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(111, 266);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 23;
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(455, 482);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 27);
            this.viewbtn.TabIndex = 24;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // visitoradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 521);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intime);
            this.Controls.Add(this.date);
            this.Controls.Add(this.person);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.addrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.card);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visitoradd";
            this.Text = "Add New Visitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addrs;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.TextBox person;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker intime;
        private System.Windows.Forms.DateTimePicker outtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox purpose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox comments;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Button viewbtn;

    }
}