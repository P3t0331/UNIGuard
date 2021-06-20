using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UniGuardClassLibrary;

namespace UNIGuard.Forms
{
    public partial class AssigmentEditorForm : Form
    {
        private List<SemesterData> Semesters = new List<SemesterData>();
        private List<SubjectData> Subjects = new List<SubjectData>();
        private List<AssigmentData> Assigments = new List<AssigmentData>();
        public AssigmentEditorForm()
        {
            InitializeComponent();
        }

        private async void AssigmentEditorForm_Load(object sender, EventArgs e)
        {
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach (var semester in Semesters)
            {
                SemesterBox.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (SemesterBox.Items.Count > 0)
            {
                SemesterBox.SelectedIndex = 0;
            }
            else
            {
                EditButton.Enabled = false;
            }

        }

        private async void SemesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            SubjectBox.Items.Clear();
            AssigmentBox.Items.Clear();
            Subjects = await SqlCommands.GetAllSubjectsInSemesterAsync(Semesters[SemesterBox.SelectedIndex].SemesterId);
            foreach (var subject in Subjects)
            {
                SubjectBox.Items.Add($"{subject.SubjectFaculty.Trim()}: {subject.SubjectName.Trim()}");
            }
            if (SubjectBox.Items.Count > 0 )
            {
                SubjectBox.SelectedIndex = 0;
            }
            else
            {
                EditButton.Enabled = false;
            }

        }

        private async void SubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssigmentBox.Items.Clear();
            Assigments = await SqlCommands.GetAllAssigmentsInSubjectAsync(Subjects[SubjectBox.SelectedIndex].Id);
            foreach(var assigment in Assigments)
            {
                AssigmentBox.Items.Add($"{assigment.AssigmentName}");
            }
            if (AssigmentBox.Items.Count > 0)
            {
                AssigmentBox.SelectedIndex = 0;
            }
            if (AssigmentBox.Items.Count > 0)
            {
                groupBox1.Visible = true;
                EditButton.Enabled = true;
            } 
            else
            {
                groupBox1.Visible = false;
                EditButton.Enabled = false;
            }
        }

        private void AssigmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssigmentName.Text = AssigmentBox.Text.Trim();
            if (Assigments[AssigmentBox.SelectedIndex].AssigmentState.Contains("Not Started"))
            {
                AssigmentState.SelectedIndex = 0;
            }
            else if (Assigments[AssigmentBox.SelectedIndex].AssigmentState.Contains("In Progress"))
            {
                AssigmentState.SelectedIndex = 1;
            }
            else if (Assigments[AssigmentBox.SelectedIndex].AssigmentState.Contains("Completed"))
            {
                AssigmentState.SelectedIndex = 2;
            }
            else if (Assigments[AssigmentBox.SelectedIndex].AssigmentState.Contains("Handed over"))
            {
                AssigmentState.SelectedIndex = 3;
            }
            else if (Assigments[AssigmentBox.SelectedIndex].AssigmentState.Contains("Reminder"))
            {
                AssigmentState.SelectedIndex = 4;
            }
            AssigmentEndDate.Value = Assigments[AssigmentBox.SelectedIndex].AssigmentEndDate;
            AssigmentEndTime.Value = Assigments[AssigmentBox.SelectedIndex].AssigmentEndDate;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            DateTime time = AssigmentEndDate.Value.Date + AssigmentEndTime.Value.TimeOfDay;
            await SqlCommands.UpdateAssigmentAsync(Assigments[AssigmentBox.SelectedIndex].AssigmentId, AssigmentName.Text,
                AssigmentState.Text, time);
            Close();
        }
    }
}
