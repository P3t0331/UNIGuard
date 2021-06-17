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

namespace UNIGuard.Forms.Assigments
{
    public partial class RemoveAssigmentForm : Form
    {
        private List<AssigmentData> Assigments = new List<AssigmentData>();
        private List<SemesterData> Semesters = new List<SemesterData>();
        public RemoveAssigmentForm()
        {
            InitializeComponent();
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            await SqlCommands.RemoveAssigmentAsync(Assigments[AssigmentBox.SelectedIndex]);
            Assigments = await SqlCommands.GetAllAssigmentsInSemesterAsync(Semesters[SemesterBox.SelectedIndex].SemesterId);
            AssigmentBox.Items.RemoveAt(AssigmentBox.SelectedIndex);
            if (AssigmentBox.Items.Count > 0)
            {
                RemoveButton.Enabled = true;
                AssigmentBox.SelectedIndex = 0;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
            MessageBox.Show("Assigment succesfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void RemoveAssigmentForm_Load(object sender, EventArgs e)
        {
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach (var semester in Semesters)
            {
                SemesterBox.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (SemesterBox.Items.Count > 0)
            {
                RemoveButton.Enabled = true;
                SemesterBox.SelectedIndex = 0;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
        }

        private async void SemesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssigmentBox.Items.Clear();
            Assigments = await SqlCommands.GetAllAssigmentsInSemesterAsync(Semesters[SemesterBox.SelectedIndex].SemesterId);
            foreach (var assigment in Assigments)
            {
                var subjectName = SqlCommands.GetAssigmentSubjectName(assigment.SubjectId);
                AssigmentBox.Items.Add($"{subjectName.Trim()}: {assigment.AssigmentName.Trim()} " +
                    $"(Deadline:{assigment.AssigmentEndDate.Day}." +
                    $"{assigment.AssigmentEndDate.Month}.{assigment.AssigmentEndDate.Year})");
            }
            if (AssigmentBox.Items.Count > 0)
            {
                RemoveButton.Enabled = true;
                AssigmentBox.SelectedIndex = 0;
            } else
            {
                RemoveButton.Enabled = false;
            }
        }
    }
}
