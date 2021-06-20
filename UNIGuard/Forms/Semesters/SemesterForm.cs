using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniGuardClassLibrary;

namespace UNIGuard.Forms
{
    public partial class SemesterForm : Form
    {
        public SemesterForm()
        {
            InitializeComponent();

        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            await SaveSemesterAsync();
            MessageBox.Show("Semester successfully added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private async Task SaveSemesterAsync()
        {
            await SqlCommands.AddSemesterAsync(semesterType.Text, startDatePicker.Value, endDatePicker.Value);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void UpdateButton()
        {
            if (startDatePicker.Value < endDatePicker.Value)
            {
                buttonConfirm.Enabled = true;
                errorLabel.Visible = false;
            }
            else
            {
                buttonConfirm.Enabled = false;
                errorLabel.Visible = true;
            }
        }



        private void SemesterForm_Load(object sender, EventArgs e)
        {
            semesterType.SelectedIndex = 0;
        }
    }
}
