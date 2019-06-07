namespace C969_Scheduling_Software_Project.Forms
{
    partial class MainScreenForm
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
            this.AppointmentScheduler = new System.Windows.Forms.Label();
            this.AppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentsModifyButton = new System.Windows.Forms.Button();
            this.AppointmentsDeleteButton = new System.Windows.Forms.Button();
            this.AppointmentsAddButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomersAddButton = new System.Windows.Forms.Button();
            this.CustomersModifyButton = new System.Windows.Forms.Button();
            this.CustomersDeleteButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AppointmentsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.CustomersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentScheduler
            // 
            this.AppointmentScheduler.AutoSize = true;
            this.AppointmentScheduler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentScheduler.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AppointmentScheduler.Location = new System.Drawing.Point(12, 11);
            this.AppointmentScheduler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppointmentScheduler.Name = "AppointmentScheduler";
            this.AppointmentScheduler.Size = new System.Drawing.Size(437, 44);
            this.AppointmentScheduler.TabIndex = 105;
            this.AppointmentScheduler.Text = "Appointment Scheduler";
            // 
            // AppointmentsGroupBox
            // 
            this.AppointmentsGroupBox.Controls.Add(this.groupBox1);
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsDataGridView);
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsModifyButton);
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsDeleteButton);
            this.AppointmentsGroupBox.Controls.Add(this.AppointmentsAddButton);
            this.AppointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AppointmentsGroupBox.Location = new System.Drawing.Point(935, 94);
            this.AppointmentsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentsGroupBox.Name = "AppointmentsGroupBox";
            this.AppointmentsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AppointmentsGroupBox.Size = new System.Drawing.Size(945, 631);
            this.AppointmentsGroupBox.TabIndex = 135;
            this.AppointmentsGroupBox.TabStop = false;
            this.AppointmentsGroupBox.Text = "Appointments";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllAppointmentsRadioButton);
            this.groupBox1.Controls.Add(this.CurrentWeekRadioButton);
            this.groupBox1.Controls.Add(this.CurrentMonthRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(45, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(841, 66);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment View Types";
            // 
            // AllAppointmentsRadioButton
            // 
            this.AllAppointmentsRadioButton.AutoSize = true;
            this.AllAppointmentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllAppointmentsRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllAppointmentsRadioButton.Location = new System.Drawing.Point(7, 30);
            this.AllAppointmentsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllAppointmentsRadioButton.Name = "AllAppointmentsRadioButton";
            this.AllAppointmentsRadioButton.Size = new System.Drawing.Size(177, 28);
            this.AllAppointmentsRadioButton.TabIndex = 132;
            this.AllAppointmentsRadioButton.TabStop = true;
            this.AllAppointmentsRadioButton.Text = "All Appointments";
            this.AllAppointmentsRadioButton.UseVisualStyleBackColor = true;
            this.AllAppointmentsRadioButton.CheckedChanged += new System.EventHandler(this.AllAppointmentsRadioButton_CheckedChanged);
            // 
            // CurrentWeekRadioButton
            // 
            this.CurrentWeekRadioButton.AutoSize = true;
            this.CurrentWeekRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWeekRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentWeekRadioButton.Location = new System.Drawing.Point(203, 30);
            this.CurrentWeekRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentWeekRadioButton.Name = "CurrentWeekRadioButton";
            this.CurrentWeekRadioButton.Size = new System.Drawing.Size(297, 28);
            this.CurrentWeekRadioButton.TabIndex = 134;
            this.CurrentWeekRadioButton.TabStop = true;
            this.CurrentWeekRadioButton.Text = "Appointments in the next Week";
            this.CurrentWeekRadioButton.UseVisualStyleBackColor = true;
            this.CurrentWeekRadioButton.CheckedChanged += new System.EventHandler(this.CurrentWeekRadioButton_CheckedChanged);
            // 
            // CurrentMonthRadioButton
            // 
            this.CurrentMonthRadioButton.AutoSize = true;
            this.CurrentMonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMonthRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentMonthRadioButton.Location = new System.Drawing.Point(522, 30);
            this.CurrentMonthRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentMonthRadioButton.Name = "CurrentMonthRadioButton";
            this.CurrentMonthRadioButton.Size = new System.Drawing.Size(301, 28);
            this.CurrentMonthRadioButton.TabIndex = 133;
            this.CurrentMonthRadioButton.TabStop = true;
            this.CurrentMonthRadioButton.Text = "Appointments in the next Month";
            this.CurrentMonthRadioButton.UseVisualStyleBackColor = true;
            this.CurrentMonthRadioButton.CheckedChanged += new System.EventHandler(this.CurrentMonthRadioButton_CheckedChanged);
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(0, 116);
            this.AppointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AppointmentsDataGridView.RowTemplate.Height = 31;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(946, 368);
            this.AppointmentsDataGridView.TabIndex = 131;
            this.AppointmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellClick);
            this.AppointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellContentClick);
            this.AppointmentsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AppointmentsDataGridView_CellFormatting);
            // 
            // AppointmentsModifyButton
            // 
            this.AppointmentsModifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppointmentsModifyButton.Location = new System.Drawing.Point(474, 539);
            this.AppointmentsModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentsModifyButton.Name = "AppointmentsModifyButton";
            this.AppointmentsModifyButton.Size = new System.Drawing.Size(166, 55);
            this.AppointmentsModifyButton.TabIndex = 129;
            this.AppointmentsModifyButton.Text = "Modify";
            this.AppointmentsModifyButton.UseVisualStyleBackColor = true;
            this.AppointmentsModifyButton.Click += new System.EventHandler(this.AppointmentsModifyButton_Click);
            // 
            // AppointmentsDeleteButton
            // 
            this.AppointmentsDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsDeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppointmentsDeleteButton.Location = new System.Drawing.Point(648, 539);
            this.AppointmentsDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentsDeleteButton.Name = "AppointmentsDeleteButton";
            this.AppointmentsDeleteButton.Size = new System.Drawing.Size(166, 55);
            this.AppointmentsDeleteButton.TabIndex = 128;
            this.AppointmentsDeleteButton.Text = "Delete";
            this.AppointmentsDeleteButton.UseVisualStyleBackColor = true;
            this.AppointmentsDeleteButton.Click += new System.EventHandler(this.AppointmentsDeleteButton_Click);
            // 
            // AppointmentsAddButton
            // 
            this.AppointmentsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsAddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppointmentsAddButton.Location = new System.Drawing.Point(304, 539);
            this.AppointmentsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentsAddButton.Name = "AppointmentsAddButton";
            this.AppointmentsAddButton.Size = new System.Drawing.Size(166, 55);
            this.AppointmentsAddButton.TabIndex = 127;
            this.AppointmentsAddButton.Text = "Add";
            this.AppointmentsAddButton.UseVisualStyleBackColor = true;
            this.AppointmentsAddButton.Click += new System.EventHandler(this.AppointmentsAddButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price Per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.CustomersDataGridView);
            this.CustomersGroupBox.Controls.Add(this.CustomersAddButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersModifyButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersDeleteButton);
            this.CustomersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CustomersGroupBox.Location = new System.Drawing.Point(21, 94);
            this.CustomersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CustomersGroupBox.Size = new System.Drawing.Size(880, 631);
            this.CustomersGroupBox.TabIndex = 134;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            this.CustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(0, 116);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            this.CustomersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CustomersDataGridView.RowTemplate.Height = 31;
            this.CustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersDataGridView.Size = new System.Drawing.Size(880, 370);
            this.CustomersDataGridView.TabIndex = 130;
            this.CustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellContentClick);
            this.CustomersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellContentClick);
            // 
            // CustomersAddButton
            // 
            this.CustomersAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomersAddButton.Location = new System.Drawing.Point(266, 539);
            this.CustomersAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersAddButton.Name = "CustomersAddButton";
            this.CustomersAddButton.Size = new System.Drawing.Size(165, 58);
            this.CustomersAddButton.TabIndex = 126;
            this.CustomersAddButton.Text = "Add";
            this.CustomersAddButton.UseVisualStyleBackColor = true;
            this.CustomersAddButton.Click += new System.EventHandler(this.CustomersAddButton_Click_1);
            // 
            // CustomersModifyButton
            // 
            this.CustomersModifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomersModifyButton.Location = new System.Drawing.Point(442, 539);
            this.CustomersModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersModifyButton.Name = "CustomersModifyButton";
            this.CustomersModifyButton.Size = new System.Drawing.Size(165, 58);
            this.CustomersModifyButton.TabIndex = 128;
            this.CustomersModifyButton.Text = "Modify";
            this.CustomersModifyButton.UseVisualStyleBackColor = true;
            this.CustomersModifyButton.Click += new System.EventHandler(this.CustomersModifyButton_Click_1);
            // 
            // CustomersDeleteButton
            // 
            this.CustomersDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersDeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomersDeleteButton.Location = new System.Drawing.Point(614, 539);
            this.CustomersDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersDeleteButton.Name = "CustomersDeleteButton";
            this.CustomersDeleteButton.Size = new System.Drawing.Size(165, 58);
            this.CustomersDeleteButton.TabIndex = 127;
            this.CustomersDeleteButton.Text = "Delete";
            this.CustomersDeleteButton.UseVisualStyleBackColor = true;
            this.CustomersDeleteButton.Click += new System.EventHandler(this.CustomersDeleteButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(20, 750);
            this.GenerateReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(239, 58);
            this.GenerateReportButton.TabIndex = 133;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1595, 750);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 58);
            this.ExitButton.TabIndex = 132;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 868);
            this.Controls.Add(this.AppointmentsGroupBox);
            this.Controls.Add(this.CustomersGroupBox);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AppointmentScheduler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.AppointmentsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.CustomersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AppointmentScheduler;
        private System.Windows.Forms.GroupBox AppointmentsGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button AppointmentsModifyButton;
        private System.Windows.Forms.Button AppointmentsDeleteButton;
        private System.Windows.Forms.Button AppointmentsAddButton;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.Button CustomersAddButton;
        private System.Windows.Forms.Button CustomersModifyButton;
        private System.Windows.Forms.Button CustomersDeleteButton;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllAppointmentsRadioButton;
        private System.Windows.Forms.RadioButton CurrentWeekRadioButton;
        private System.Windows.Forms.RadioButton CurrentMonthRadioButton;
    }
}