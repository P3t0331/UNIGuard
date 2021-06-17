using System;
using System.Windows.Forms;
using UNIGuard.Forms;

namespace UNIGuard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewSubjectButton_Click(object sender, EventArgs e)
        {
            var subjectForm = new SubjectInput();
            subjectForm.ShowDialog();
        }

        private void NewSemesterButton_Click(object sender, EventArgs e)
        {
            var semesterForm = new SemesterForm();
            semesterForm.ShowDialog();
        }

        private void AssigmentInput_Click(object sender, EventArgs e)
        {
            var assigmentForm = new AssigmentForm();
            assigmentForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var editAssigmentForm = new AssigmentEditorForm();
            editAssigmentForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var removeSemesterForm = new Forms.Semesters.RemoveSemesterForm();
            removeSemesterForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var removeAssigmentForm = new Forms.Assigments.RemoveAssigmentForm();
            removeAssigmentForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var removeSubjectForm = new Forms.Subjects.RemoveSubjectForm();
            removeSubjectForm.ShowDialog();
        }
    }
}
