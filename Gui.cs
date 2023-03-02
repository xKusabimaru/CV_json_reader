using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_json_reader
{
    public partial class Gui : Form
    {
        private Candidate[] candidates;
        public Gui()
        {
            InitializeComponent();
        }

        private void Gui_Load(object sender, EventArgs e)
        {
            FilesManager filesManager = new FilesManager();
            CandidateManager cm = filesManager.manageLoader();
            this.candidates = cm.getAllCandidates();

            List<String> names = new List<String>();

            foreach (Candidate i in candidates)
            {
                names.Add(i.getName());
            }

            foreach (String i in names)
            {
                namesList.Items.Add(i);
            }

        }

        private void clearViewers()
        {
            nameViewer.Items.Clear();
            birthDateViewer.Items.Clear();
            linkedinViewer.Items.Clear();
            emailsViewer.Items.Clear();
            locationViewer.Items.Clear();
            languagesViewer.Items.Clear();
            certificationsViewer.Items.Clear();
            phoneNumbersViewer.Items.Clear();
            websitesViewer.Items.Clear();
            educationViewer.Items.Clear();
            professionViewer.Items.Clear();
            yearsExperienceViewer.Items.Clear();
            workExperienceViewer.Items.Clear();
            skillsViewer.Items.Clear();
        }

        private void fillNameViewer(int index)
        {
            nameViewer.Items.Add(candidates[index].getName());
        }
        private void fillBirthDateViewer(int index)
        {
            birthDateViewer.Items.Add(candidates[index].getDateOfBirth());
        }
        private void fillLinkedinViewer(int index)
        {
            linkedinViewer.Items.Add(candidates[index].getLinkedin());
        }
        private void fillLocationViewer(int index)
        {
            locationViewer.Items.Add(candidates[index].getLocation());
        }
        private void fillProfessionViewer(int index)
        {
            professionViewer.Items.Add(candidates[index].getProfession());
        }
        private void fillYearsViewer(int index)
        {
            yearsExperienceViewer.Items.Add(candidates[index].getTotalYearsExperience().ToString());
        }
        private void fillEmailsViewer(int index)
        {
            foreach (String i in candidates[index].getEmails())
            {
                emailsViewer.Items.Add(i);
            }
        }
        private void fillLanguagesViewer(int index)
        {
            foreach (String i in candidates[index].getLanguages())
            {
                languagesViewer.Items.Add(i);
            }
        }
        private void fillCertificationsViewer(int index)
        {
            foreach (String i in candidates[index].getCertifications())
            {
                certificationsViewer.Items.Add(i);
            }
        }
        private void fillPhoneNumbersViewer(int index)
        {
            foreach (String i in candidates[index].getPhoneNumbers())
            {
                phoneNumbersViewer.Items.Add(i);
            }
        }
        private void fillWebsitesViewer(int index)
        {
            foreach (String i in candidates[index].getWebsites())
            {
                websitesViewer.Items.Add(i);
            }
        }
        private void fillEducationViewer(int index)
        {
            for (int i = 0; i < candidates[index].getEducationsEducation().Length; i++)
            {              
                educationViewer.Items.Add("Education: " + candidates[index].getEducationsEducation()[i]);
                educationViewer.Items.Add("Organization: " + candidates[index].getEducationsOrganization()[i]);
                educationViewer.Items.Add("Location: " + candidates[index].getEducationsLocation()[i]);
                educationViewer.Items.Add("Grade: " + candidates[index].getEducationsGrade()[i]);
                educationViewer.Items.Add("Date: " + candidates[index].getEducationsDate()[i]);
                educationViewer.Items.Add("-----------------------------------------------------------------");
            }
        }
        private void fillWorkExperiencesViewer(int index)
        {
            for (int i = 0; i < candidates[index].getWorkExperiencesJobTitle().Length; i++)
            {
                workExperienceViewer.Items.Add("JobTitle: " + candidates[index].getWorkExperiencesJobTitle()[i]);
                workExperienceViewer.Items.Add("JobDescription: " + candidates[index].getWorkExperiencesJobDescription()[i]);
                workExperienceViewer.Items.Add("Organization: " + candidates[index].getWorkExperiencesOrganization()[i]);
                workExperienceViewer.Items.Add("Location: " + candidates[index].getWorkExperiencesLocation()[i]);
                workExperienceViewer.Items.Add("Date: " + candidates[index].getWorkExperiencesDate()[i]);
                workExperienceViewer.Items.Add("-----------------------------------------------------------------");
            }
        }
        private void fillSkillsViewer(int index)
        {
            foreach (String i in candidates[index].getSkills())
            {
                skillsViewer.Items.Add(i);
            }
        }

        private void resumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void namesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = namesList.SelectedIndex;

            if (index >= 0)
            {
                clearViewers();
                fillNameViewer(index);
                fillBirthDateViewer(index);
                fillCertificationsViewer(index);
                fillEducationViewer(index);
                fillEmailsViewer(index);
                fillLanguagesViewer(index);
                fillLinkedinViewer(index);
                fillLocationViewer(index);
                fillPhoneNumbersViewer(index);
                fillProfessionViewer(index);
                fillSkillsViewer(index);
                fillWebsitesViewer(index);
                fillWorkExperiencesViewer(index);
                fillYearsViewer(index);
            }
        }

        private void infoBox_Enter(object sender, EventArgs e)
        {

        }

        private void nameViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void workExperienceViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void educationViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void professionViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearsExperienceViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailsViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumbersLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumbersViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void websitesLabel_Click(object sender, EventArgs e)
        {

        }

        private void websitesViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birthDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthDateViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void locationViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void languagesLabel_Click(object sender, EventArgs e)
        {

        }

        private void languagesViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void educationLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkedinLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkedinViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void certificationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void certificationsViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void workExperienceLabel_Click(object sender, EventArgs e)
        {

        }

        private void professionLabel_Click(object sender, EventArgs e)
        {

        }

        private void yearsExperienceLabel_Click(object sender, EventArgs e)
        {

        }

        private void skillsLabel_Click(object sender, EventArgs e)
        {

        }

        private void skillsViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameViewer_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
