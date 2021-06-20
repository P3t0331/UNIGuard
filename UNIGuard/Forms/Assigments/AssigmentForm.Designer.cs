
namespace UNIGuard.Forms
{
    partial class AssigmentForm
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
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.SemesterPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssigmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AssigmentEndTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.AssigmentStateList = new System.Windows.Forms.ComboBox();
            this.AssigmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AssigmentEndDate = new System.Windows.Forms.DateTimePicker();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.AssigmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(12, 26);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(141, 20);
            this.SemesterLabel.TabIndex = 1;
            this.SemesterLabel.Text = "Choose Semester:";
            // 
            // SemesterPicker
            // 
            this.SemesterPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterPicker.FormattingEnabled = true;
            this.SemesterPicker.Location = new System.Drawing.Point(159, 26);
            this.SemesterPicker.Name = "SemesterPicker";
            this.SemesterPicker.Size = new System.Drawing.Size(326, 21);
            this.SemesterPicker.TabIndex = 2;
            this.SemesterPicker.SelectedIndexChanged += new System.EventHandler(this.SemesterPicker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Subject:";
            // 
            // SubjectPicker
            // 
            this.SubjectPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectPicker.Enabled = false;
            this.SubjectPicker.FormattingEnabled = true;
            this.SubjectPicker.Location = new System.Drawing.Point(159, 71);
            this.SubjectPicker.Name = "SubjectPicker";
            this.SubjectPicker.Size = new System.Drawing.Size(326, 21);
            this.SubjectPicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assigment end date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assigment Name:";
            // 
            // AssigmentGroupBox
            // 
            this.AssigmentGroupBox.Controls.Add(this.AssigmentEndTime);
            this.AssigmentGroupBox.Controls.Add(this.label5);
            this.AssigmentGroupBox.Controls.Add(this.AssigmentStateList);
            this.AssigmentGroupBox.Controls.Add(this.AssigmentNameTextBox);
            this.AssigmentGroupBox.Controls.Add(this.label4);
            this.AssigmentGroupBox.Controls.Add(this.AssigmentEndDate);
            this.AssigmentGroupBox.Controls.Add(this.label3);
            this.AssigmentGroupBox.Controls.Add(this.label2);
            this.AssigmentGroupBox.Location = new System.Drawing.Point(16, 138);
            this.AssigmentGroupBox.Name = "AssigmentGroupBox";
            this.AssigmentGroupBox.Size = new System.Drawing.Size(469, 145);
            this.AssigmentGroupBox.TabIndex = 7;
            this.AssigmentGroupBox.TabStop = false;
            this.AssigmentGroupBox.Visible = false;
            // 
            // AssigmentEndTime
            // 
            this.AssigmentEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AssigmentEndTime.Location = new System.Drawing.Point(167, 81);
            this.AssigmentEndTime.Name = "AssigmentEndTime";
            this.AssigmentEndTime.Size = new System.Drawing.Size(296, 20);
            this.AssigmentEndTime.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Assigment end date:";
            // 
            // AssigmentStateList
            // 
            this.AssigmentStateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssigmentStateList.FormattingEnabled = true;
            this.AssigmentStateList.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Completed",
            "Handed over",
            "Reminder"});
            this.AssigmentStateList.Location = new System.Drawing.Point(167, 110);
            this.AssigmentStateList.Name = "AssigmentStateList";
            this.AssigmentStateList.Size = new System.Drawing.Size(296, 21);
            this.AssigmentStateList.TabIndex = 12;
            // 
            // AssigmentNameTextBox
            // 
            this.AssigmentNameTextBox.Location = new System.Drawing.Point(167, 16);
            this.AssigmentNameTextBox.Name = "AssigmentNameTextBox";
            this.AssigmentNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.AssigmentNameTextBox.TabIndex = 8;
            this.AssigmentNameTextBox.TextChanged += new System.EventHandler(this.SubjectCodeTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose State:";
            // 
            // AssigmentEndDate
            // 
            this.AssigmentEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AssigmentEndDate.Location = new System.Drawing.Point(167, 48);
            this.AssigmentEndDate.Name = "AssigmentEndDate";
            this.AssigmentEndDate.Size = new System.Drawing.Size(296, 20);
            this.AssigmentEndDate.TabIndex = 9;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 289);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(410, 289);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(19, 105);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(460, 20);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "There was no subject found in this semester! Add it first!";
            // 
            // AssigmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 324);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AssigmentGroupBox);
            this.Controls.Add(this.SubjectPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SemesterPicker);
            this.Controls.Add(this.SemesterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AssigmentForm";
            this.Text = "Add Assigment";
            this.Load += new System.EventHandler(this.AssigmentForm_Load);
            this.AssigmentGroupBox.ResumeLayout(false);
            this.AssigmentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox SemesterPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubjectPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox AssigmentGroupBox;
        private System.Windows.Forms.DateTimePicker AssigmentEndDate;
        private System.Windows.Forms.TextBox AssigmentNameTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ComboBox AssigmentStateList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AssigmentEndTime;
        private System.Windows.Forms.Label label5;
    }
}