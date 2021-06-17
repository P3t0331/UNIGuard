
namespace UNIGuard.Forms.Assigments
{
    partial class RemoveAssigmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AssigmentBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SemesterBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Assigment to remove";
            // 
            // AssigmentBox
            // 
            this.AssigmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssigmentBox.FormattingEnabled = true;
            this.AssigmentBox.Location = new System.Drawing.Point(71, 99);
            this.AssigmentBox.Name = "AssigmentBox";
            this.AssigmentBox.Size = new System.Drawing.Size(254, 21);
            this.AssigmentBox.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(309, 153);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(12, 153);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 5;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Semester to remove from";
            // 
            // SemesterBox
            // 
            this.SemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Location = new System.Drawing.Point(71, 32);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(254, 21);
            this.SemesterBox.TabIndex = 7;
            this.SemesterBox.SelectedIndexChanged += new System.EventHandler(this.SemesterBox_SelectedIndexChanged);
            // 
            // RemoveAssigmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 188);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AssigmentBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemoveAssigmentForm";
            this.Text = "Remove Assigment";
            this.Load += new System.EventHandler(this.RemoveAssigmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AssigmentBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SemesterBox;
    }
}