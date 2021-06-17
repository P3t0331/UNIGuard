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

namespace UNIGuard.Forms.Subjects
{
    public partial class RemoveSubjectForm : Form
    {
        private List<SemesterData> Semesters = new List<SemesterData>();
        private List<SubjectData> Subjects = new List<SubjectData>();
        public RemoveSubjectForm()
        {
            InitializeComponent();
        }

        private async void RemoveSubjectForm_Load(object sender, EventArgs e)
        {
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach (var semester in Semesters)
            {
                SemesterBox.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (SemesterBox.Items.Count > 0)
            {
                SemesterBox.SelectedIndex = 0;
                RemoveButton.Enabled = true;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SemesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectBox.Items.Clear();
            Subjects = await SqlCommands.GetAllSubjectsInSemesterAsync(Semesters[SemesterBox.SelectedIndex].SemesterId);
            foreach (var subject in Subjects)
            {
                SubjectBox.Items.Add($"{subject.SemesterName}");
            }
            if (SubjectBox.Items.Count > 0)
            {
                RemoveButton.Enabled = true;
                SubjectBox.SelectedIndex = 0;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                await SqlCommands.RemoveSubjectAsync(Subjects[SubjectBox.SelectedIndex]);
                Subjects = await SqlCommands.GetAllSubjectsInSemesterAsync(Semesters[SemesterBox.SelectedIndex].SemesterId);
                SubjectBox.Items.RemoveAt(SubjectBox.SelectedIndex);
                if (SubjectBox.Items.Count > 0)
                {
                    RemoveButton.Enabled = true;
                    SubjectBox.SelectedIndex = 0;
                }
                else
                {
                    RemoveButton.Enabled = false;
                }
                MessageBox.Show("Assigment succesfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error! First you need to remove assigments associated with this semester.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
