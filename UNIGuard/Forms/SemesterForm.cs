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
            await saveSemesterAsync();
            MessageBox.Show("Semester successfully added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private async Task saveSemesterAsync()
        {
            /*
            var path = Environment.CurrentDirectory + "\\Data\\SemesterData.csv";
            using (var writer = new StreamWriter(path, true))
            {
                await writer.WriteLineAsync($"{semesterType.Text},{startDatePicker.Value.ToShortDateString()}" +
                    $",{endDatePicker.Value.ToShortDateString()}");
            }
            */
            await SqlCommands.AddSemester(semesterType.Text, startDatePicker.Value, endDatePicker.Value);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
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
