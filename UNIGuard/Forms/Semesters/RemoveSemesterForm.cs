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

namespace UNIGuard.Forms.Semesters
{
    public partial class RemoveSemesterForm : Form
    {

        private List<SemesterData> Semesters = new List<SemesterData>();
        public RemoveSemesterForm()
        {
            InitializeComponent();
        }

        private async void RemoveSemesterForm_Load(object sender, EventArgs e)
        {
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach(var semester in Semesters)
            {
                SemestersBox.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
            if (SemestersBox.Items.Count > 0)
            {
                RemoveButton.Enabled = true;
                SemestersBox.SelectedIndex = 0;
            }
            else
            {
                RemoveButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                await SqlCommands.RemoveSemesterAsync(Semesters[SemestersBox.SelectedIndex]);
                SemestersBox.Items.RemoveAt(SemestersBox.SelectedIndex);
                Semesters = await SqlCommands.GetAllSemestersAsync();
                if (SemestersBox.Items.Count > 0)
                {
                    RemoveButton.Enabled = true;
                    SemestersBox.SelectedIndex = 0;
                }
                else
                {
                    RemoveButton.Enabled = false;
                }
                MessageBox.Show("Semester succesfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error! First you need to remove assigments and" +
                    " subjects associated with this semester.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
