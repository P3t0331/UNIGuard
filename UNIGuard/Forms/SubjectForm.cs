using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace UNIGuard.Forms
{
    public partial class SubjectInput : Form
    {
        private List<(string, DateTime, DateTime)> semesters = new List<(string, DateTime, DateTime)>();

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
            if (semesters.Count != 0)
            {
                startDateLabel.Text = semesters[semesterPicker.SelectedIndex].Item2.ToShortDateString();
                endDateLabel.Text = semesters[semesterPicker.SelectedIndex].Item3.ToShortDateString();
            }
        }

        private async Task LoadListBoxAsync()
        {
            var path = Environment.CurrentDirectory + "\\Data\\SemesterData.csv";
            using (var reader = new StreamReader(path))
            {
                var line = await reader.ReadLineAsync();
                while (line != null)
                {
                    var lineContent = line.Split(',');

                    var semesterType = lineContent[0];
                    var startDate = DateTime.Parse(lineContent[1]);
                    var endDate = DateTime.Parse(lineContent[2]);
                    semesters.Add((semesterType, startDate, endDate));
                    semesterPicker.Items.Add($"{semesterType} {startDate.Year}");
                    line = await reader.ReadLineAsync();
                }
            }
        }

        private void LectureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lectureCheckBox.Checked)
            {
                lectureGroupBox.Visible = true;
            }
            else
            {
                lectureGroupBox.Visible = false;
            }
        }

        private void SeminarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seminarCheckBox.Checked)
            {
                seminarGroupBox.Visible = true;
            }
            else
            {
                seminarGroupBox.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SaveButton_ClickAsync(object sender, EventArgs e)
        {
            await SaveSubjectAsync();
        }

        private async Task SaveSubjectAsync()
        {
            var path = Environment.CurrentDirectory + "\\Data\\SubjectData.csv";
            using (var writer = new StreamWriter(path, true))
            {
                await writer.WriteLineAsync($"{semesterPicker.SelectedItem},{subjectCodeTextBox.Text},{subjectNameTextBox.Text}");
            }
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
