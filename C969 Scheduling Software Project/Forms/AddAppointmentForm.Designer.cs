namespace C969_Scheduling_Software_Project.Forms
{
    partial class AddAppointmentForm
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
            this.AddAppointmentGroupBox = new System.Windows.Forms.GroupBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TypeListBox = new System.Windows.Forms.ListBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddAppointmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAppointmentGroupBox
            // 
            this.AddAppointmentGroupBox.Controls.Add(this.EndTimePicker);
            this.AddAppointmentGroupBox.Controls.Add(this.StartTimePicker);
            this.AddAppointmentGroupBox.Controls.Add(this.TypeListBox);
            this.AddAppointmentGroupBox.Controls.Add(this.EndTimeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.StartTimeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.TypeLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.DescriptionLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.DescriptionTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.CustomerIdLabel);
            this.AddAppointmentGroupBox.Controls.Add(this.CustomerIdTextBox);
            this.AddAppointmentGroupBox.Controls.Add(this.SaveButton);
            this.AddAppointmentGroupBox.Controls.Add(this.CancelButton);
            this.AddAppointmentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddAppointmentGroupBox.Location = new System.Drawing.Point(9, 9);
            this.AddAppointmentGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAppointmentGroupBox.Name = "AddAppointmentGroupBox";
            this.AddAppointmentGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAppointmentGroupBox.Size = new System.Drawing.Size(464, 491);
            this.AddAppointmentGroupBox.TabIndex = 10;
            this.AddAppointmentGroupBox.TabStop = false;
            this.AddAppointmentGroupBox.Text = "Add Appointment";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(139, 299);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(299, 39);
            this.EndTimePicker.TabIndex = 168;
            this.EndTimePicker.Value = new System.DateTime(2019, 5, 30, 17, 0, 0, 0);
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(139, 246);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(299, 39);
            this.StartTimePicker.TabIndex = 167;
            this.StartTimePicker.Value = new System.DateTime(2019, 5, 30, 9, 0, 0, 0);
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // TypeListBox
            // 
            this.TypeListBox.AllowDrop = true;
            this.TypeListBox.FormattingEnabled = true;
            this.TypeListBox.ItemHeight = 32;
            this.TypeListBox.Items.AddRange(new object[] {
            "General Doctor",
            "Specialist"});
            this.TypeListBox.Location = new System.Drawing.Point(134, 174);
            this.TypeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeListBox.Name = "TypeListBox";
            this.TypeListBox.Size = new System.Drawing.Size(305, 68);
            this.TypeListBox.TabIndex = 166;
            this.TypeListBox.SelectedIndexChanged += new System.EventHandler(this.TypeListBox_SelectedIndexChanged);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EndTimeLabel.Location = new System.Drawing.Point(31, 310);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(102, 25);
            this.EndTimeLabel.TabIndex = 163;
            this.EndTimeLabel.Text = "End Time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StartTimeLabel.Location = new System.Drawing.Point(24, 249);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(108, 25);
            this.StartTimeLabel.TabIndex = 161;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TypeLabel.Location = new System.Drawing.Point(75, 186);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(57, 25);
            this.TypeLabel.TabIndex = 159;
            this.TypeLabel.Text = "Type";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 131);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.DescriptionLabel.TabIndex = 157;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(138, 120);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(303, 39);
            this.DescriptionTextBox.TabIndex = 156;
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CustomerIdLabel.Location = new System.Drawing.Point(15, 74);
            this.CustomerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(118, 25);
            this.CustomerIdLabel.TabIndex = 155;
            this.CustomerIdLabel.Text = "Customer Id";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Enabled = false;
            this.CustomerIdTextBox.Location = new System.Drawing.Point(138, 63);
            this.CustomerIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(303, 39);
            this.CustomerIdTextBox.TabIndex = 154;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(123, 395);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 61);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(292, 395);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(147, 61);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 535);
            this.Controls.Add(this.AddAppointmentGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.AddAppointmentGroupBox.ResumeLayout(false);
            this.AddAppointmentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddAppointmentGroupBox;
        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
    }
}