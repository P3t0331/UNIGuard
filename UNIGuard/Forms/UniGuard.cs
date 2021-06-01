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
    }
}
