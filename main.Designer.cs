namespace ESIS
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.applaunch = new System.Windows.Forms.Button();
            this.visitbtn = new System.Windows.Forms.Button();
            this.classbtn = new System.Windows.Forms.Button();
            this.ttbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applaunch
            // 
            this.applaunch.Location = new System.Drawing.Point(263, 209);
            this.applaunch.Name = "applaunch";
            this.applaunch.Size = new System.Drawing.Size(84, 29);
            this.applaunch.TabIndex = 0;
            this.applaunch.Text = "Appointments";
            this.applaunch.UseVisualStyleBackColor = true;
            this.applaunch.Click += new System.EventHandler(this.applaunch_Click);
            // 
            // visitbtn
            // 
            this.visitbtn.Location = new System.Drawing.Point(41, 209);
            this.visitbtn.Name = "visitbtn";
            this.visitbtn.Size = new System.Drawing.Size(97, 29);
            this.visitbtn.TabIndex = 1;
            this.visitbtn.Text = "Visitors\' Pass ";
            this.visitbtn.UseVisualStyleBackColor = true;
            this.visitbtn.Click += new System.EventHandler(this.visitbtn_Click);
            // 
            // classbtn
            // 
            this.classbtn.Location = new System.Drawing.Point(462, 209);
            this.classbtn.Name = "classbtn";
            this.classbtn.Size = new System.Drawing.Size(75, 29);
            this.classbtn.TabIndex = 2;
            this.classbtn.Text = "rooms";
            this.classbtn.UseVisualStyleBackColor = true;
            this.classbtn.Click += new System.EventHandler(this.classbtn_Click);
            // 
            // ttbtn
            // 
            this.ttbtn.Location = new System.Drawing.Point(263, 272);
            this.ttbtn.Name = "ttbtn";
            this.ttbtn.Size = new System.Drawing.Size(84, 28);
            this.ttbtn.TabIndex = 3;
            this.ttbtn.Text = "Timetable";
            this.ttbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "EASY SCHOOL FRONT DESK PORTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbtn);
            this.Controls.Add(this.classbtn);
            this.Controls.Add(this.visitbtn);
            this.Controls.Add(this.applaunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Front Desk";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applaunch;
        private System.Windows.Forms.Button visitbtn;
        private System.Windows.Forms.Button classbtn;
        private System.Windows.Forms.Button ttbtn;
        private System.Windows.Forms.Label label1;
    }
}