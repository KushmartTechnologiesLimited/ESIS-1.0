namespace ESIS.Finances
{
    partial class PaymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentDetails));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordNewTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Export = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.admNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.feesItemComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findButton = new System.Windows.Forms.Button();
            this.toDateCheckbox = new System.Windows.Forms.CheckBox();
            this.fromDateCheckBox = new System.Windows.Forms.CheckBox();
            this.itemCheckBox = new System.Windows.Forms.CheckBox();
            this.admNoCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordNewTransactionToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordNewTransactionToolStripMenuItem
            // 
            this.recordNewTransactionToolStripMenuItem.Name = "recordNewTransactionToolStripMenuItem";
            this.recordNewTransactionToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.recordNewTransactionToolStripMenuItem.Text = "Record New Transaction";
            this.recordNewTransactionToolStripMenuItem.Click += new System.EventHandler(this.recordNewTransactionToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameLabel,
            this.Export});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(118, 17);
            this.userNameLabel.Text = "toolStripStatusLabel1";
            // 
            // Export
            // 
            this.Export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem});
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(53, 20);
            this.Export.Text = "Export";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            // 
            // feeDataGrid
            // 
            this.feeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeDataGrid.Location = new System.Drawing.Point(31, 29);
            this.feeDataGrid.Name = "feeDataGrid";
            this.feeDataGrid.Size = new System.Drawing.Size(945, 251);
            this.feeDataGrid.TabIndex = 4;
            this.feeDataGrid.AutoSizeColumnsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler(this.feeDataGrid_AutoSizeColumnsModeChanged);
            this.feeDataGrid.DataSourceChanged += new System.EventHandler(this.feeDataGrid_DataSourceChanged);
            this.feeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feeDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find By Adm No: ";
            // 
            // admNoTextBox
            // 
            this.admNoTextBox.Location = new System.Drawing.Point(331, 1);
            this.admNoTextBox.Name = "admNoTextBox";
            this.admNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.admNoTextBox.TabIndex = 6;
            this.admNoTextBox.TextChanged += new System.EventHandler(this.admNoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fees Item";
            // 
            // feesItemComboBox
            // 
            this.feesItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feesItemComboBox.FormattingEnabled = true;
            this.feesItemComboBox.Location = new System.Drawing.Point(522, 0);
            this.feesItemComboBox.Name = "feesItemComboBox";
            this.feesItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.feesItemComboBox.TabIndex = 8;
            this.feesItemComboBox.SelectedIndexChanged += new System.EventHandler(this.feesItemComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Day collected";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1273, 1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 21);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(982, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2015, 1, 6, 13, 50, 8, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.toDateCheckbox);
            this.panel1.Controls.Add(this.fromDateCheckBox);
            this.panel1.Controls.Add(this.itemCheckBox);
            this.panel1.Controls.Add(this.admNoCheckBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1026, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 202);
            this.panel1.TabIndex = 14;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(111, 132);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(79, 23);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // toDateCheckbox
            // 
            this.toDateCheckbox.AutoSize = true;
            this.toDateCheckbox.Location = new System.Drawing.Point(191, 95);
            this.toDateCheckbox.Name = "toDateCheckbox";
            this.toDateCheckbox.Size = new System.Drawing.Size(63, 17);
            this.toDateCheckbox.TabIndex = 4;
            this.toDateCheckbox.Text = "To date";
            this.toDateCheckbox.UseVisualStyleBackColor = true;
            this.toDateCheckbox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // fromDateCheckBox
            // 
            this.fromDateCheckBox.AutoSize = true;
            this.fromDateCheckBox.Location = new System.Drawing.Point(40, 95);
            this.fromDateCheckBox.Name = "fromDateCheckBox";
            this.fromDateCheckBox.Size = new System.Drawing.Size(73, 17);
            this.fromDateCheckBox.TabIndex = 3;
            this.fromDateCheckBox.Text = "From date";
            this.fromDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemCheckBox
            // 
            this.itemCheckBox.AutoSize = true;
            this.itemCheckBox.Location = new System.Drawing.Point(191, 58);
            this.itemCheckBox.Name = "itemCheckBox";
            this.itemCheckBox.Size = new System.Drawing.Size(72, 17);
            this.itemCheckBox.TabIndex = 2;
            this.itemCheckBox.Text = "Fees Item";
            this.itemCheckBox.UseVisualStyleBackColor = true;
            // 
            // admNoCheckBox
            // 
            this.admNoCheckBox.AutoSize = true;
            this.admNoCheckBox.Location = new System.Drawing.Point(40, 55);
            this.admNoCheckBox.Name = "admNoCheckBox";
            this.admNoCheckBox.Size = new System.Drawing.Size(64, 17);
            this.admNoCheckBox.TabIndex = 1;
            this.admNoCheckBox.Text = "Adm No";
            this.admNoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Specialise your query";
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feesItemComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feeDataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaymentDetails";
            this.Text = "PaymentDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordNewTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel userNameLabel;
        private System.Windows.Forms.DataGridView feeDataGrid;
        private System.Windows.Forms.ToolStripDropDownButton Export;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox feesItemComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.CheckBox toDateCheckbox;
        private System.Windows.Forms.CheckBox fromDateCheckBox;
        private System.Windows.Forms.CheckBox itemCheckBox;
        private System.Windows.Forms.CheckBox admNoCheckBox;
        private System.Windows.Forms.Label label5;
    }
}