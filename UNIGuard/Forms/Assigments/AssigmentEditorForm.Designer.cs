
namespace UNIGuard.Forms
{
    partial class AssigmentEditorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectBox = new System.Windows.Forms.ComboBox();
            this.AssigmentBox = new System.Windows.Forms.ComboBox();
            this.SemesterBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssigmentState = new System.Windows.Forms.ComboBox();
            this.AssigmentEndTime = new System.Windows.Forms.DateTimePicker();
            this.AssigmentEndDate = new System.Windows.Forms.DateTimePicker();
            this.AssigmentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(12, 18);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(141, 20);
            this.SemesterLabel.TabIndex = 2;
            this.SemesterLabel.Text = "Choose Semester:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Assigment:";
            // 
            // SubjectBox
            // 
            this.SubjectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectBox.FormattingEnabled = true;
            this.SubjectBox.Location = new System.Drawing.Point(164, 61);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(328, 21);
            this.SubjectBox.TabIndex = 5;
            this.SubjectBox.SelectedIndexChanged += new System.EventHandler(this.SubjectBox_SelectedIndexChanged);
            // 
            // AssigmentBox
            // 
            this.AssigmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssigmentBox.FormattingEnabled = true;
            this.AssigmentBox.Location = new System.Drawing.Point(164, 107);
            this.AssigmentBox.Name = "AssigmentBox";
            this.AssigmentBox.Size = new System.Drawing.Size(328, 21);
            this.AssigmentBox.TabIndex = 6;
            this.AssigmentBox.SelectedIndexChanged += new System.EventHandler(this.AssigmentBox_SelectedIndexChanged);
            // 
            // SemesterBox
            // 
            this.SemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Location = new System.Drawing.Point(164, 17);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(328, 21);
            this.SemesterBox.TabIndex = 7;
            this.SemesterBox.SelectedIndexChanged += new System.EventHandler(this.SemesterBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssigmentState);
            this.groupBox1.Controls.Add(this.AssigmentEndTime);
            this.groupBox1.Controls.Add(this.AssigmentEndDate);
            this.groupBox1.Controls.Add(this.AssigmentName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // AssigmentState
            // 
            this.AssigmentState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssigmentState.FormattingEnabled = true;
            this.AssigmentState.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Completed",
            "Handed over"});
            this.AssigmentState.Location = new System.Drawing.Point(241, 68);
            this.AssigmentState.Name = "AssigmentState";
            this.AssigmentState.Size = new System.Drawing.Size(229, 21);
            this.AssigmentState.TabIndex = 19;
            // 
            // AssigmentEndTime
            // 
            this.AssigmentEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AssigmentEndTime.Location = new System.Drawing.Point(241, 150);
            this.AssigmentEndTime.Name = "AssigmentEndTime";
            this.AssigmentEndTime.Size = new System.Drawing.Size(229, 20);
            this.AssigmentEndTime.TabIndex = 18;
            // 
            // AssigmentEndDate
            // 
            this.AssigmentEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AssigmentEndDate.Location = new System.Drawing.Point(241, 107);
            this.AssigmentEndDate.Name = "AssigmentEndDate";
            this.AssigmentEndDate.Size = new System.Drawing.Size(229, 20);
            this.AssigmentEndDate.TabIndex = 17;
            // 
            // AssigmentName
            // 
            this.AssigmentName.Location = new System.Drawing.Point(241, 26);
            this.AssigmentName.Name = "AssigmentName";
            this.AssigmentName.Size = new System.Drawing.Size(229, 20);
            this.AssigmentName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Change Assigment end time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Change Assigment end date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Change Assigment state:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Change Assigment name:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(417, 361);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AssigmentEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.AssigmentBox);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SemesterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AssigmentEditorForm";
            this.Text = "Assigment Editor";
            this.Load += new System.EventHandler(this.AssigmentEditorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubjectBox;
        private System.Windows.Forms.ComboBox AssigmentBox;
        private System.Windows.Forms.ComboBox SemesterBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox AssigmentState;
        private System.Windows.Forms.DateTimePicker AssigmentEndTime;
        private System.Windows.Forms.DateTimePicker AssigmentEndDate;
        private System.Windows.Forms.TextBox AssigmentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}