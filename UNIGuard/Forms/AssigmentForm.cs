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
    public partial class AssigmentForm : Form
    {
        private List<SemesterData> Semesters = new List<SemesterData>();
        private List<SubjectData> Subjects = new List<SubjectData>();
        public AssigmentForm()
        {
            InitializeComponent();
        }

        private async void AssigmentForm_Load(object sender, EventArgs e)
        {
            Semesters = await SqlCommands.GetAllSemesters();
            Subjects = await SqlCommands.GetAllSubjects();

            foreach (var semester in Semesters)
            {
                SemesterPicker.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (SemesterPicker.Items.Count > 0 )
            {
                SemesterPicker.SelectedIndex = 0;
            }
        }

        private void SemesterPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectPicker.Items.Clear();
            foreach (var subject in Subjects)
            {
                if (subject.SemesterId == Semesters[SemesterPicker.SelectedIndex].SemesterId)
                {
                    SubjectPicker.Items.Add(subject.SemesterName);
                }
            }
            if (SubjectPicker.Items.Count > 0)
            {
                SubjectPicker.Enabled = true;
                AssigmentGroupBox.Visible = true;
                SubjectPicker.SelectedIndex = 0;
                subjectCodeTextBox.Text = "";
                WarningLabel.Visible = false;
            } else
            {
                SubjectPicker.Enabled = false;
                AssigmentGroupBox.Visible = false;
                SaveButton.Enabled = false;
                WarningLabel.Visible = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void subjectCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (subjectCodeTextBox.Text.Length != 0)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }
    }
}
