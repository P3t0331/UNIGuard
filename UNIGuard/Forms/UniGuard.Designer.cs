
namespace UNIGuard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.assigmentInput = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.MonitoringLabel = new System.Windows.Forms.Label();
            this.NotMonitoringLabel = new System.Windows.Forms.Label();
            this.ToggleMonitoringBtn = new System.Windows.Forms.Button();
            this.ActiveSemesterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.MonitoringTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewSubjectButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Semester";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NewSemesterButton_Click);
            // 
            // assigmentInput
            // 
            this.assigmentInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.assigmentInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assigmentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigmentInput.Location = new System.Drawing.Point(38, 142);
            this.assigmentInput.Name = "assigmentInput";
            this.assigmentInput.Size = new System.Drawing.Size(187, 51);
            this.assigmentInput.TabIndex = 2;
            this.assigmentInput.Text = "Add Assigment";
            this.assigmentInput.UseVisualStyleBackColor = true;
            this.assigmentInput.Click += new System.EventHandler(this.AssigmentInput_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(145, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit Assigment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(267, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove Semester";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(267, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Remove Assigment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(267, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "Remove Subject";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.Location = new System.Drawing.Point(181, 25);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(135, 20);
            this.SemesterLabel.TabIndex = 7;
            this.SemesterLabel.Text = "Monitoring status:";
            // 
            // MonitoringLabel
            // 
            this.MonitoringLabel.AutoSize = true;
            this.MonitoringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitoringLabel.ForeColor = System.Drawing.Color.Green;
            this.MonitoringLabel.Location = new System.Drawing.Point(199, 45);
            this.MonitoringLabel.Name = "MonitoringLabel";
            this.MonitoringLabel.Size = new System.Drawing.Size(93, 20);
            this.MonitoringLabel.TabIndex = 8;
            this.MonitoringLabel.Text = "Monitoring";
            this.MonitoringLabel.Visible = false;
            // 
            // NotMonitoringLabel
            // 
            this.NotMonitoringLabel.AutoSize = true;
            this.NotMonitoringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotMonitoringLabel.ForeColor = System.Drawing.Color.Red;
            this.NotMonitoringLabel.Location = new System.Drawing.Point(181, 45);
            this.NotMonitoringLabel.Name = "NotMonitoringLabel";
            this.NotMonitoringLabel.Size = new System.Drawing.Size(126, 20);
            this.NotMonitoringLabel.TabIndex = 9;
            this.NotMonitoringLabel.Text = "Not Monitoring";
            // 
            // ToggleMonitoringBtn
            // 
            this.ToggleMonitoringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleMonitoringBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToggleMonitoringBtn.Enabled = false;
            this.ToggleMonitoringBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleMonitoringBtn.Location = new System.Drawing.Point(146, 126);
            this.ToggleMonitoringBtn.Name = "ToggleMonitoringBtn";
            this.ToggleMonitoringBtn.Size = new System.Drawing.Size(208, 51);
            this.ToggleMonitoringBtn.TabIndex = 10;
            this.ToggleMonitoringBtn.Text = "Toggle Monitoring";
            this.ToggleMonitoringBtn.UseVisualStyleBackColor = true;
            this.ToggleMonitoringBtn.Click += new System.EventHandler(this.ToggleMonitoringBtn_Click);
            // 
            // ActiveSemesterBox
            // 
            this.ActiveSemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveSemesterBox.FormattingEnabled = true;
            this.ActiveSemesterBox.Location = new System.Drawing.Point(146, 99);
            this.ActiveSemesterBox.Name = "ActiveSemesterBox";
            this.ActiveSemesterBox.Size = new System.Drawing.Size(208, 21);
            this.ActiveSemesterBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose semester to monitor:";
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.button2);
            this.settingsBox.Controls.Add(this.button1);
            this.settingsBox.Controls.Add(this.assigmentInput);
            this.settingsBox.Controls.Add(this.button3);
            this.settingsBox.Controls.Add(this.button4);
            this.settingsBox.Controls.Add(this.button5);
            this.settingsBox.Controls.Add(this.button6);
            this.settingsBox.Location = new System.Drawing.Point(12, 219);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(485, 294);
            this.settingsBox.TabIndex = 13;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            this.settingsBox.Visible = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(13, 190);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(117, 23);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "Toggle settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // MonitoringTimer
            // 
            this.MonitoringTimer.Interval = 3600000;
            this.MonitoringTimer.Tick += new System.EventHandler(this.MonitoringTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 571);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveSemesterBox);
            this.Controls.Add(this.ToggleMonitoringBtn);
            this.Controls.Add(this.NotMonitoringLabel);
            this.Controls.Add(this.MonitoringLabel);
            this.Controls.Add(this.SemesterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "UNIGuard Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.settingsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button assigmentInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label MonitoringLabel;
        private System.Windows.Forms.Label NotMonitoringLabel;
        private System.Windows.Forms.Button ToggleMonitoringBtn;
        private System.Windows.Forms.ComboBox ActiveSemesterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer MonitoringTimer;
    }
}

