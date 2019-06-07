namespace C969_Scheduling_Software_Project.Forms
{
    partial class ReportsForm
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
            this.components = new System.ComponentModel.Container();
            this.ReportsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.consultantTextBox = new System.Windows.Forms.Label();
            this.ReportsTextBox = new System.Windows.Forms.TextBox();
            this.ReportTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionsByMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.ScheduleForConsultantRadioButton = new System.Windows.Forms.RadioButton();
            this.TypesByMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.reportsFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.ReportTypesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsGroupBox
            // 
            this.ReportsGroupBox.Controls.Add(this.AppointmentsDataGridView);
            this.ReportsGroupBox.Controls.Add(this.consultantTextBox);
            this.ReportsGroupBox.Controls.Add(this.ReportsTextBox);
            this.ReportsGroupBox.Controls.Add(this.ReportTypesGroupBox);
            this.ReportsGroupBox.Controls.Add(this.ExitButton);
            this.ReportsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReportsGroupBox.Location = new System.Drawing.Point(11, 11);
            this.ReportsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportsGroupBox.Name = "ReportsGroupBox";
            this.ReportsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportsGroupBox.Size = new System.Drawing.Size(1223, 805);
            this.ReportsGroupBox.TabIndex = 0;
            this.ReportsGroupBox.TabStop = false;
            this.ReportsGroupBox.Text = "Reports";
            this.ReportsGroupBox.Enter += new System.EventHandler(this.ReportsGroupBox_Enter);
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(17, 198);
            this.AppointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AppointmentsDataGridView.RowTemplate.Height = 31;
            this.AppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(1192, 513);
            this.AppointmentsDataGridView.TabIndex = 134;
            // 
            // consultantTextBox
            // 
            this.consultantTextBox.AutoSize = true;
            this.consultantTextBox.Location = new System.Drawing.Point(6, 164);
            this.consultantTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consultantTextBox.Name = "consultantTextBox";
            this.consultantTextBox.Size = new System.Drawing.Size(648, 32);
            this.consultantTextBox.TabIndex = 134;
            this.consultantTextBox.Text = "Appointments for current logged in consultant: test";
            // 
            // ReportsTextBox
            // 
            this.ReportsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsTextBox.Location = new System.Drawing.Point(17, 198);
            this.ReportsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportsTextBox.Multiline = true;
            this.ReportsTextBox.Name = "ReportsTextBox";
            this.ReportsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReportsTextBox.Size = new System.Drawing.Size(1192, 514);
            this.ReportsTextBox.TabIndex = 133;
            // 
            // ReportTypesGroupBox
            // 
            this.ReportTypesGroupBox.Controls.Add(this.DescriptionsByMonthRadioButton);
            this.ReportTypesGroupBox.Controls.Add(this.ScheduleForConsultantRadioButton);
            this.ReportTypesGroupBox.Controls.Add(this.TypesByMonthRadioButton);
            this.ReportTypesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypesGroupBox.Location = new System.Drawing.Point(633, 22);
            this.ReportTypesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportTypesGroupBox.Name = "ReportTypesGroupBox";
            this.ReportTypesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportTypesGroupBox.Size = new System.Drawing.Size(576, 138);
            this.ReportTypesGroupBox.TabIndex = 130;
            this.ReportTypesGroupBox.TabStop = false;
            this.ReportTypesGroupBox.Text = "Report Types";
            // 
            // DescriptionsByMonthRadioButton
            // 
            this.DescriptionsByMonthRadioButton.AutoSize = true;
            this.DescriptionsByMonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionsByMonthRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescriptionsByMonthRadioButton.Location = new System.Drawing.Point(51, 102);
            this.DescriptionsByMonthRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionsByMonthRadioButton.Name = "DescriptionsByMonthRadioButton";
            this.DescriptionsByMonthRadioButton.Size = new System.Drawing.Size(476, 29);
            this.DescriptionsByMonthRadioButton.TabIndex = 2;
            this.DescriptionsByMonthRadioButton.TabStop = true;
            this.DescriptionsByMonthRadioButton.Text = "Appointment descriptions by month for current year";
            this.DescriptionsByMonthRadioButton.UseVisualStyleBackColor = true;
            this.DescriptionsByMonthRadioButton.CheckedChanged += new System.EventHandler(this.DescriptionsByMonthRadioButton_CheckedChanged);
            // 
            // ScheduleForConsultantRadioButton
            // 
            this.ScheduleForConsultantRadioButton.AutoSize = true;
            this.ScheduleForConsultantRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleForConsultantRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScheduleForConsultantRadioButton.Location = new System.Drawing.Point(51, 65);
            this.ScheduleForConsultantRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScheduleForConsultantRadioButton.Name = "ScheduleForConsultantRadioButton";
            this.ScheduleForConsultantRadioButton.Size = new System.Drawing.Size(294, 29);
            this.ScheduleForConsultantRadioButton.TabIndex = 1;
            this.ScheduleForConsultantRadioButton.TabStop = true;
            this.ScheduleForConsultantRadioButton.Text = "Schedule for each Consultant";
            this.ScheduleForConsultantRadioButton.UseVisualStyleBackColor = true;
            this.ScheduleForConsultantRadioButton.CheckedChanged += new System.EventHandler(this.ScheduleForConsultantRadioButton_CheckedChanged);
            // 
            // TypesByMonthRadioButton
            // 
            this.TypesByMonthRadioButton.AutoSize = true;
            this.TypesByMonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesByMonthRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TypesByMonthRadioButton.Location = new System.Drawing.Point(51, 28);
            this.TypesByMonthRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypesByMonthRadioButton.Name = "TypesByMonthRadioButton";
            this.TypesByMonthRadioButton.Size = new System.Drawing.Size(424, 29);
            this.TypesByMonthRadioButton.TabIndex = 0;
            this.TypesByMonthRadioButton.TabStop = true;
            this.TypesByMonthRadioButton.Text = "Appointment types by month for current year ";
            this.TypesByMonthRadioButton.UseVisualStyleBackColor = true;
            this.TypesByMonthRadioButton.CheckedChanged += new System.EventHandler(this.TypesByMonthRadioButton_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(1062, 737);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(147, 61);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // reportsFormBindingSource
            // 
            this.reportsFormBindingSource.DataSource = typeof(C969_Scheduling_Software_Project.Forms.ReportsForm);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 827);
            this.Controls.Add(this.ReportsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ReportsGroupBox.ResumeLayout(false);
            this.ReportsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.ReportTypesGroupBox.ResumeLayout(false);
            this.ReportTypesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReportsGroupBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox ReportTypesGroupBox;
        private System.Windows.Forms.RadioButton DescriptionsByMonthRadioButton;
        private System.Windows.Forms.RadioButton ScheduleForConsultantRadioButton;
        private System.Windows.Forms.RadioButton TypesByMonthRadioButton;
        private System.Windows.Forms.BindingSource reportsFormBindingSource;
        private System.Windows.Forms.TextBox ReportsTextBox;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.Label consultantTextBox;
    }
}