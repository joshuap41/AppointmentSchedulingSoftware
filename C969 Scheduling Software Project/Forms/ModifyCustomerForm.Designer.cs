namespace C969_Scheduling_Software_Project.Forms
{
    partial class ModifyCustomerForm
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
            this.ModifyCustomerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.Address2Label = new System.Windows.Forms.Label();
            this.Address2TextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ModifyCustomerInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyCustomerInformationGroupBox
            // 
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.CityListBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.PostalCodeLabel);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.PostalCodeTextBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.CityLabel);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.Address2Label);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.Address2TextBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.AddressLabel);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.AddressTextBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.NameLabel);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.NameTextBox);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.CancelButton);
            this.ModifyCustomerInformationGroupBox.Controls.Add(this.SaveButton);
            this.ModifyCustomerInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCustomerInformationGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifyCustomerInformationGroupBox.Location = new System.Drawing.Point(11, 11);
            this.ModifyCustomerInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyCustomerInformationGroupBox.Name = "ModifyCustomerInformationGroupBox";
            this.ModifyCustomerInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyCustomerInformationGroupBox.Size = new System.Drawing.Size(611, 783);
            this.ModifyCustomerInformationGroupBox.TabIndex = 1;
            this.ModifyCustomerInformationGroupBox.TabStop = false;
            this.ModifyCustomerInformationGroupBox.Text = "Cutomer Information";
            // 
            // CityListBox
            // 
            this.CityListBox.AllowDrop = true;
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.ItemHeight = 32;
            this.CityListBox.Items.AddRange(new object[] {
            "New York",
            "Toronto"});
            this.CityListBox.Location = new System.Drawing.Point(206, 288);
            this.CityListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(277, 68);
            this.CityListBox.TabIndex = 167;
            this.CityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(57, 434);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.PhoneNumberLabel.TabIndex = 17;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(205, 423);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(277, 39);
            this.PhoneNumberTextBox.TabIndex = 16;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PostalCodeLabel.Location = new System.Drawing.Point(81, 371);
            this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(119, 25);
            this.PostalCodeLabel.TabIndex = 13;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(205, 362);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(277, 39);
            this.PostalCodeTextBox.TabIndex = 12;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CityLabel.Location = new System.Drawing.Point(154, 305);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(46, 25);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City";
            // 
            // Address2Label
            // 
            this.Address2Label.AutoSize = true;
            this.Address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address2Label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Address2Label.Location = new System.Drawing.Point(99, 240);
            this.Address2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(101, 25);
            this.Address2Label.TabIndex = 7;
            this.Address2Label.Text = "Address 2";
            // 
            // Address2TextBox
            // 
            this.Address2TextBox.Location = new System.Drawing.Point(205, 229);
            this.Address2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address2TextBox.Name = "Address2TextBox";
            this.Address2TextBox.Size = new System.Drawing.Size(277, 39);
            this.Address2TextBox.TabIndex = 6;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddressLabel.Location = new System.Drawing.Point(116, 168);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(85, 25);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(205, 157);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(277, 39);
            this.AddressTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(136, 96);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(205, 87);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(277, 39);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(110, 578);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 66);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(352, 578);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(128, 66);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ModifyCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 803);
            this.Controls.Add(this.ModifyCustomerInformationGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifyCustomerForm";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.ModifyCustomerForm_Load);
            this.ModifyCustomerInformationGroupBox.ResumeLayout(false);
            this.ModifyCustomerInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ModifyCustomerInformationGroupBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.TextBox Address2TextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox CityListBox;
    }
}