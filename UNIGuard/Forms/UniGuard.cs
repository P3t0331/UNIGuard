using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
