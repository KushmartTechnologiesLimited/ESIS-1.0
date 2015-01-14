namespace ESIS.Config
{
    partial class BillStudents
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
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.feeItemComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classListBox = new System.Windows.Forms.ListBox();
            this.classItemRemoveButton = new System.Windows.Forms.Button();
            this.feeItemRemoveButton = new System.Windows.Forms.Button();
            this.streamComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillButton = new System.Windows.Forms.Button();
            this.feeItemButton = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 15;
            this.itemListBox.Location = new System.Drawing.Point(401, 59);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(441, 409);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // feeItemComboBox
            // 
            this.feeItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feeItemComboBox.FormattingEnabled = true;
            this.feeItemComboBox.Location = new System.Drawing.Point(53, 87);
            this.feeItemComboBox.Name = "feeItemComboBox";
            this.feeItemComboBox.Size = new System.Drawing.Size(272, 23);
            this.feeItemComboBox.TabIndex = 1;
            this.feeItemComboBox.SelectedIndexChanged += new System.EventHandler(this.feeItemComboBox_SelectedIndexChanged);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(53, 168);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(272, 23);
            this.classComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Fee Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Class";
            // 
            // classListBox
            // 
            this.classListBox.FormattingEnabled = true;
            this.classListBox.ItemHeight = 15;
            this.classListBox.Location = new System.Drawing.Point(56, 287);
            this.classListBox.Name = "classListBox";
            this.classListBox.Size = new System.Drawing.Size(272, 184);
            this.classListBox.TabIndex = 5;
            // 
            // classItemRemoveButton
            // 
            this.classItemRemoveButton.Location = new System.Drawing.Point(132, 479);
            this.classItemRemoveButton.Name = "classItemRemoveButton";
            this.classItemRemoveButton.Size = new System.Drawing.Size(137, 31);
            this.classItemRemoveButton.TabIndex = 6;
            this.classItemRemoveButton.Text = "Remove Item";
            this.classItemRemoveButton.UseVisualStyleBackColor = true;
            this.classItemRemoveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // feeItemRemoveButton
            // 
            this.feeItemRemoveButton.Location = new System.Drawing.Point(574, 479);
            this.feeItemRemoveButton.Name = "feeItemRemoveButton";
            this.feeItemRemoveButton.Size = new System.Drawing.Size(123, 27);
            this.feeItemRemoveButton.TabIndex = 7;
            this.feeItemRemoveButton.Text = "Remove Item";
            this.feeItemRemoveButton.UseVisualStyleBackColor = true;
            this.feeItemRemoveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // streamComboBox
            // 
            this.streamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamComboBox.FormattingEnabled = true;
            this.streamComboBox.Items.AddRange(new object[] {
            "All"});
            this.streamComboBox.Location = new System.Drawing.Point(53, 235);
            this.streamComboBox.Name = "streamComboBox";
            this.streamComboBox.Size = new System.Drawing.Size(275, 23);
            this.streamComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stream";
            // 
            // BillButton
            // 
            this.BillButton.Location = new System.Drawing.Point(305, 505);
            this.BillButton.Name = "BillButton";
            this.BillButton.Size = new System.Drawing.Size(204, 50);
            this.BillButton.TabIndex = 12;
            this.BillButton.Text = "Bill";
            this.BillButton.UseVisualStyleBackColor = true;
            this.BillButton.Click += new System.EventHandler(this.BillButton_Click);
            // 
            // feeItemButton
            // 
            this.feeItemButton.Location = new System.Drawing.Point(342, 87);
            this.feeItemButton.Name = "feeItemButton";
            this.feeItemButton.Size = new System.Drawing.Size(31, 27);
            this.feeItemButton.TabIndex = 13;
            this.feeItemButton.Text = ">";
            this.feeItemButton.UseVisualStyleBackColor = true;
            this.feeItemButton.Click += new System.EventHandler(this.feeItemButton_Click);
            // 
            // classButton
            // 
            this.classButton.Location = new System.Drawing.Point(342, 201);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(31, 27);
            this.classButton.TabIndex = 14;
            this.classButton.Text = ">";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // BillStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.feeItemButton);
            this.Controls.Add(this.BillButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.streamComboBox);
            this.Controls.Add(this.feeItemRemoveButton);
            this.Controls.Add(this.classItemRemoveButton);
            this.Controls.Add(this.classListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.feeItemComboBox);
            this.Controls.Add(this.itemListBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BillStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Students";
            this.Load += new System.EventHandler(this.BillStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.ComboBox feeItemComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox classListBox;
        private System.Windows.Forms.Button classItemRemoveButton;
        private System.Windows.Forms.Button feeItemRemoveButton;
        private System.Windows.Forms.ComboBox streamComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BillButton;
        private System.Windows.Forms.Button feeItemButton;
        private System.Windows.Forms.Button classButton;
    }
}