
namespace UNIGuard.Forms
{
    partial class SubjectInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectInput));
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.semesterPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.subjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.lectureCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lectureGroupBox = new System.Windows.Forms.GroupBox();
            this.seminarCheckBox = new System.Windows.Forms.CheckBox();
            this.seminarGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.autoFillButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.manualAddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectEndTextBox = new System.Windows.Forms.TextBox();
            this.facultyPicker = new System.Windows.Forms.ComboBox();
            this.lectureGroupBox.SuspendLayout();
            this.seminarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(12, 23);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(141, 20);
            this.SemesterLabel.TabIndex = 0;
            this.SemesterLabel.Text = "Choose Semester:";
            // 
            // semesterPicker
            // 
            this.semesterPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterPicker.FormattingEnabled = true;
            this.semesterPicker.Location = new System.Drawing.Point(183, 25);
            this.semesterPicker.Name = "semesterPicker";
            this.semesterPicker.Size = new System.Drawing.Size(322, 21);
            this.semesterPicker.TabIndex = 1;
            this.semesterPicker.SelectedIndexChanged += new System.EventHandler(this.SemesterPicker_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semester start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semester end date:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(172, 55);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(0, 20);
            this.startDateLabel.TabIndex = 5;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(172, 75);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(0, 20);
            this.endDateLabel.TabIndex = 6;
            // 
            // subjectCodeTextBox
            // 
            this.subjectCodeTextBox.Location = new System.Drawing.Point(183, 105);
            this.subjectCodeTextBox.Name = "subjectCodeTextBox";
            this.subjectCodeTextBox.Size = new System.Drawing.Size(322, 20);
            this.subjectCodeTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject Name:";
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Enabled = false;
            this.subjectNameTextBox.Location = new System.Drawing.Point(183, 215);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(322, 20);
            this.subjectNameTextBox.TabIndex = 10;
            // 
            // lectureCheckBox
            // 
            this.lectureCheckBox.AutoSize = true;
            this.lectureCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureCheckBox.Location = new System.Drawing.Point(15, 278);
            this.lectureCheckBox.Name = "lectureCheckBox";
            this.lectureCheckBox.Size = new System.Drawing.Size(172, 24);
            this.lectureCheckBox.TabIndex = 12;
            this.lectureCheckBox.Text = "Subject has lectures";
            this.lectureCheckBox.UseVisualStyleBackColor = true;
            this.lectureCheckBox.CheckedChanged += new System.EventHandler(this.LectureCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lecture start day";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Every week";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(129, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Every 2 weeks";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lectureGroupBox
            // 
            this.lectureGroupBox.Controls.Add(this.radioButton1);
            this.lectureGroupBox.Controls.Add(this.dateTimePicker1);
            this.lectureGroupBox.Controls.Add(this.radioButton2);
            this.lectureGroupBox.Controls.Add(this.label5);
            this.lectureGroupBox.Location = new System.Drawing.Point(15, 308);
            this.lectureGroupBox.Name = "lectureGroupBox";
            this.lectureGroupBox.Size = new System.Drawing.Size(489, 91);
            this.lectureGroupBox.TabIndex = 17;
            this.lectureGroupBox.TabStop = false;
            this.lectureGroupBox.Visible = false;
            // 
            // seminarCheckBox
            // 
            this.seminarCheckBox.AutoSize = true;
            this.seminarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seminarCheckBox.Location = new System.Drawing.Point(16, 405);
            this.seminarCheckBox.Name = "seminarCheckBox";
            this.seminarCheckBox.Size = new System.Drawing.Size(180, 24);
            this.seminarCheckBox.TabIndex = 18;
            this.seminarCheckBox.Text = "Subject has seminars";
            this.seminarCheckBox.UseVisualStyleBackColor = true;
            this.seminarCheckBox.CheckedChanged += new System.EventHandler(this.SeminarCheckBox_CheckedChanged);
            // 
            // seminarGroupBox
            // 
            this.seminarGroupBox.Controls.Add(this.radioButton3);
            this.seminarGroupBox.Controls.Add(this.dateTimePicker2);
            this.seminarGroupBox.Controls.Add(this.radioButton4);
            this.seminarGroupBox.Controls.Add(this.label6);
            this.seminarGroupBox.Location = new System.Drawing.Point(15, 435);
            this.seminarGroupBox.Name = "seminarGroupBox";
            this.seminarGroupBox.Size = new System.Drawing.Size(489, 91);
            this.seminarGroupBox.TabIndex = 18;
            this.seminarGroupBox.TabStop = false;
            this.seminarGroupBox.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Every week";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(140, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(129, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Every 2 weeks";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seminar start day";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(429, 532);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_ClickAsync);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 532);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // autoFillButton
            // 
            this.autoFillButton.Location = new System.Drawing.Point(429, 153);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.Size = new System.Drawing.Size(75, 23);
            this.autoFillButton.TabIndex = 21;
            this.autoFillButton.Text = "Autofill";
            this.autoFillButton.UseVisualStyleBackColor = true;
            this.autoFillButton.Click += new System.EventHandler(this.AutoFillButton_ClickAsync);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Subject Faculty:";
            // 
            // manualAddButton
            // 
            this.manualAddButton.Location = new System.Drawing.Point(183, 153);
            this.manualAddButton.Name = "manualAddButton";
            this.manualAddButton.Size = new System.Drawing.Size(83, 23);
            this.manualAddButton.TabIndex = 23;
            this.manualAddButton.Text = "Manual";
            this.manualAddButton.UseVisualStyleBackColor = true;
            this.manualAddButton.Click += new System.EventHandler(this.ManualAddButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Subject Extent:";
            // 
            // subjectEndTextBox
            // 
            this.subjectEndTextBox.Enabled = false;
            this.subjectEndTextBox.Location = new System.Drawing.Point(183, 241);
            this.subjectEndTextBox.Multiline = true;
            this.subjectEndTextBox.Name = "subjectEndTextBox";
            this.subjectEndTextBox.Size = new System.Drawing.Size(322, 31);
            this.subjectEndTextBox.TabIndex = 26;
            // 
            // facultyPicker
            // 
            this.facultyPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyPicker.FormattingEnabled = true;
            this.facultyPicker.Items.AddRange(new object[] {
            "LAW - Faculty of Law",
            "MED - Faculty of Medicine",
            "SCI - Faculty of Science",
            "PHIL - Faculty of Arts",
            "PED - Faculty of Education",
            "PHARM - Faculty of Pharmacy",
            "ECON - Faculty of Economics and Administration",
            "FI - Faculty of Informatics",
            "FSS - Faculty of Social Studies",
            "FSPS  - Faculty of Sports Studies"});
            this.facultyPicker.Location = new System.Drawing.Point(183, 130);
            this.facultyPicker.Name = "facultyPicker";
            this.facultyPicker.Size = new System.Drawing.Size(322, 21);
            this.facultyPicker.TabIndex = 28;
            // 
            // SubjectInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(517, 567);
            this.Controls.Add(this.facultyPicker);
            this.Controls.Add(this.subjectEndTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.manualAddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.autoFillButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.seminarGroupBox);
            this.Controls.Add(this.seminarCheckBox);
            this.Controls.Add(this.lectureGroupBox);
            this.Controls.Add(this.lectureCheckBox);
            this.Controls.Add(this.subjectNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectCodeTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semesterPicker);
            this.Controls.Add(this.SemesterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectInput";
            this.Text = "Add Subject";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.lectureGroupBox.ResumeLayout(false);
            this.lectureGroupBox.PerformLayout();
            this.seminarGroupBox.ResumeLayout(false);
            this.seminarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox semesterPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox subjectCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.CheckBox lectureCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox lectureGroupBox;
        private System.Windows.Forms.CheckBox seminarCheckBox;
        private System.Windows.Forms.GroupBox seminarGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button autoFillButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button manualAddButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subjectEndTextBox;
        private System.Windows.Forms.ComboBox facultyPicker;
    }
}