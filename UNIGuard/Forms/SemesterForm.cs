using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private async Task saveSemesterAsync()
        {
            using (var writer = new StreamWriter(Environment.CurrentDirectory + "\\Data\\SemesterData.csv", true))
            {
                await writer.WriteLineAsync($"{startDatePicker.Value.Day}.{startDatePicker.Value.Month}" +
                    $".{startDatePicker.Value.Year},{endDatePicker.Value.Day}.{endDatePicker.Value.Month}" +
                    $".{endDatePicker.Value.Year}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
