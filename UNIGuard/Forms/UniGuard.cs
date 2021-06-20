using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIGuard.Forms;
using UniGuardClassLibrary;

namespace UNIGuard
{
    public partial class MainForm : Form
    {
        private List<SemesterData> Semesters = new List<SemesterData>();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a new form for adding a new subject
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSubjectButton_Click(object sender, EventArgs e)
        {
            var subjectForm = new SubjectInput();
            subjectForm.ShowDialog();
        }

        /// <summary>
        /// Opens a new form for adding a new semester
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void NewSemesterButton_Click(object sender, EventArgs e)
        {
            var semesterForm = new SemesterForm();
            semesterForm.ShowDialog();
            await RefreshSemesters();
        }

        /// <summary>
        /// Opens a new form for adding a new assigment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssigmentInput_Click(object sender, EventArgs e)
        {
            var assigmentForm = new AssigmentForm();
            assigmentForm.ShowDialog();
        }

        /// <summary>
        /// Opens a new form for editing assigment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            var editAssigmentForm = new AssigmentEditorForm();
            editAssigmentForm.ShowDialog();
        }

        /// <summary>
        /// Opens a new form for removing semester
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button4_Click(object sender, EventArgs e)
        {
            var removeSemesterForm = new Forms.Semesters.RemoveSemesterForm();
            removeSemesterForm.ShowDialog();
            await RefreshSemesters();
        }

        /// <summary>
        /// Opens a new form for removing assigment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            var removeAssigmentForm = new Forms.Assigments.RemoveAssigmentForm();
            removeAssigmentForm.ShowDialog();
        }

        /// <summary>
        /// Opens a new form for removing subjects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            var removeSubjectForm = new Forms.Subjects.RemoveSubjectForm();
            removeSubjectForm.ShowDialog();
        }

        /// <summary>
        /// Toggles monitoring the assigment deadlines (every 1 hour)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleMonitoringBtn_Click(object sender, EventArgs e)
        {
            if(MonitoringLabel.Visible)
            {
                MonitoringLabel.Visible = false;
                NotMonitoringLabel.Visible = true;
                MonitoringTimer.Enabled = false;
            }
            else
            {
                MonitoringLabel.Visible = true;
                NotMonitoringLabel.Visible = false;
                MonitoringTimer.Enabled = true;
            }
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            await RefreshSemesters();
        }

        /// <summary>
        /// Opens settings groupbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsBox.Visible)
            {
                settingsBox.Visible = false;
            }
            else
            {
                settingsBox.Visible = true;
            }
            
        }

        /// <summary>
        /// Refreshes the available semesters to monitor.
        /// </summary>
        /// <returns></returns>
        public async Task RefreshSemesters()
        {
            ActiveSemesterBox.Items.Clear();
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach (var semester in Semesters)
            {
                ActiveSemesterBox.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (ActiveSemesterBox.Items.Count > 0)
            {
                ActiveSemesterBox.SelectedIndex = 0;
                ToggleMonitoringBtn.Enabled = true;
            }
            else
            {
                ToggleMonitoringBtn.Enabled = false;
                if (MonitoringTimer.Enabled)
                {
                    MonitoringTimer.Enabled = false;
                    NotMonitoringLabel.Visible = true;
                    MonitoringLabel.Visible = false;
                }
            }
        }

        /// <summary>
        /// Main logic of checking the assigments
        /// Assigment not started - Start getting notifications every hour when there is 5 days left.
        /// Assigment In Progress - Start getting notifications every hour when there is 1 day left.
        /// Assigment completed but not handed over - Start getting notifications every hour when there is 2 hours left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MonitoringTimer_Tick(object sender, EventArgs e)
        {
            var assigmentsThisSemester = await SqlCommands.GetAllAssigmentsInSemesterAsync
                (Semesters[ActiveSemesterBox.SelectedIndex].SemesterId);
            TimeSpan timeLeft;
            string finalText = "";
            foreach(var assigment in assigmentsThisSemester)
            {
                timeLeft = assigment.AssigmentEndDate - DateTime.Now;
                if (assigment.AssigmentState == "Not Started" && timeLeft.TotalDays <= 5 && timeLeft.TotalDays > 0)
                {
                    var subjectName = SqlCommands.GetAssigmentSubjectName(assigment.SubjectId);
                    finalText += $"{subjectName}: {assigment.AssigmentName} -> You have not started yet. Approx." +
                        $" {timeLeft.Hours} hour(s) remaining\n" +
                        $"------------------------------------\n";
                }
                else if (assigment.AssigmentState == "In Progress" &&
                    timeLeft.TotalDays <= 1 && timeLeft.TotalDays > 0)
                {
                    var subjectName = SqlCommands.GetAssigmentSubjectName(assigment.SubjectId);
                    finalText += $"{subjectName}: {assigment.AssigmentName} -> You should hurry up" +
                        $" with this assigment. Approx. {timeLeft.Hours} hour(s) remaining\n" +
                        $"------------------------------------\n";

                }
                else if (assigment.AssigmentState == "Completed" && 
                    timeLeft.TotalHours <= 2 && timeLeft.TotalHours > 0)
                {
                    var subjectName = SqlCommands.GetAssigmentSubjectName(assigment.SubjectId);
                    finalText += $"{subjectName}: {assigment.AssigmentName} -> The assigment is still not handed" +
                        $" over. Approx. {timeLeft.Hours} hour(s) remaining\n" +
                        $"------------------------------------\n";
                }

            }
            if (finalText != "")
            {
                MessageBox.Show(finalText, "Monitoring Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
