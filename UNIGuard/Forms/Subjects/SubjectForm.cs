using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using UniGuardClassLibrary;

namespace UNIGuard.Forms
{
    public partial class SubjectInput : Form
    {
        private List<SemesterData> Semesters = new List<SemesterData>();

        public SubjectInput()
        {
            InitializeComponent();
            
        }
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            await LoadListBoxAsync();
            semesterPicker.SelectedIndex = 0;
            facultyPicker.SelectedIndex = 7;
        }

        private void SemesterPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Semesters.Count != 0)
            {
                startDateLabel.Text = Semesters[semesterPicker.SelectedIndex].StartDate.ToShortDateString();
                endDateLabel.Text = Semesters[semesterPicker.SelectedIndex].EndDate.ToShortDateString();
            }
        }

        private async Task LoadListBoxAsync()
        {
            Semesters = await SqlCommands.GetAllSemestersAsync();
            foreach (var semester in Semesters)
            {
                semesterPicker.Items.Add($"{semester.SemesterType} {semester.StartDate.Year}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SaveButton_ClickAsync(object sender, EventArgs e)
        {
            if (subjectCodeTextBox.Text == "")
            {
                MessageBox.Show("Subject code is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await SaveSubjectAsync();
                Close();
            }

        }

        private async Task SaveSubjectAsync()
        {
            var chosenSemester = Semesters[semesterPicker.SelectedIndex];
            var code = subjectCodeTextBox.Text;
            await SqlCommands.AddSubjectAsync(code, chosenSemester.SemesterId);
        }

        private void CheckSubjectAsync()
        {
            HtmlAgilityPack.HtmlDocument site = new HtmlAgilityPack.HtmlDocument();
            string semesterText = Classes.ThreadHelperClass.GetText(this, semesterPicker);
            string facultyText = Classes.ThreadHelperClass.GetText(this, facultyPicker);
            string semesterUrl = "";
            if (semesterText.Contains("Spring"))
            {
                semesterUrl = "jaro" + semesterText.Split(' ')[1]; ;
            }
            else if (semesterText.Contains("Winter"))
            {
                semesterUrl = "podzim" + semesterText.Split(' ')[1]; ;
            }
            facultyText = facultyText.Split(' ')[0];
            string siteUrl = $"https://is.muni.cz/predmet/{facultyText}/{semesterUrl}/{subjectCodeTextBox.Text}";
            using (var client = new WebClient())
            using (var stream = client.OpenRead(siteUrl))
            using (var textReader = new StreamReader(stream, Encoding.UTF8, true))
            {
                string text = textReader.ReadToEnd();
                site.LoadHtml(text);
                var notPublishedOrNotFound = site.DocumentNode.SelectSingleNode("//*[@id=\"app_content\"]/div/h3/text()");
                if (notPublishedOrNotFound == null)
                {
                    var subjectName = site.DocumentNode.SelectSingleNode("//*[@id=\"app_content\"]/h2").InnerText; 
                    subjectName = subjectName.Replace("&nbsp;", " ");
                    var subjectEndings = site.DocumentNode.SelectSingleNode("//*[@id=\"app_content\"]/dl/dd[1]/text()[1]").InnerText;
                    var extentSplitted = subjectEndings.Split('/');
                    Classes.ThreadHelperClass.SetText(this, subjectNameTextBox, subjectName);
                    Classes.ThreadHelperClass.SetText(this, subjectEndTextBox, subjectEndings);
                    Classes.ThreadHelperClass.EnableElement(this, saveButton);
                }
                else
                {
                    var errorText = notPublishedOrNotFound.InnerText;
                    Classes.ThreadHelperClass.SetText(this, subjectNameTextBox, errorText);
                    Classes.ThreadHelperClass.SetText(this, subjectEndTextBox, "");
                    Classes.ThreadHelperClass.DisableElement(this, saveButton);
                }
            }
        }

        private async void AutoFillButton_ClickAsync(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            subjectNameTextBox.Enabled = false;
            subjectEndTextBox.Enabled = false;
            await Task.Run(() => CheckSubjectAsync());
        }

        private void ManualAddButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            subjectNameTextBox.Enabled = true;
            subjectEndTextBox.Enabled = true;
        }
    }
}
