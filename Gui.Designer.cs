
namespace CV_json_reader
{
    partial class Gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resumeLabel = new System.Windows.Forms.Label();
            this.namesList = new System.Windows.Forms.ListBox();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameViewer = new System.Windows.Forms.ListView();
            this.emailsLabel = new System.Windows.Forms.Label();
            this.emailsViewer = new System.Windows.Forms.ListView();
            this.phoneNumbersLabel = new System.Windows.Forms.Label();
            this.phoneNumbersViewer = new System.Windows.Forms.ListView();
            this.websitesLabel = new System.Windows.Forms.Label();
            this.websitesViewer = new System.Windows.Forms.ListView();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthDateViewer = new System.Windows.Forms.ListView();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationViewer = new System.Windows.Forms.ListView();
            this.languagesLabel = new System.Windows.Forms.Label();
            this.languagesViewer = new System.Windows.Forms.ListView();
            this.yearsExperienceLabel = new System.Windows.Forms.Label();
            this.yearsExperienceViewer = new System.Windows.Forms.ListView();
            this.professionLabel = new System.Windows.Forms.Label();
            this.professionViewer = new System.Windows.Forms.ListView();
            this.linkedinLabel = new System.Windows.Forms.Label();
            this.linkedinViewer = new System.Windows.Forms.ListView();
            this.educationLabel = new System.Windows.Forms.Label();
            this.educationViewer = new System.Windows.Forms.ListView();
            this.workExperienceLabel = new System.Windows.Forms.Label();
            this.workExperienceViewer = new System.Windows.Forms.ListView();
            this.certificationsLabel = new System.Windows.Forms.Label();
            this.certificationsViewer = new System.Windows.Forms.ListView();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.skillsViewer = new System.Windows.Forms.ListView();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resumeLabel
            // 
            this.resumeLabel.AutoSize = true;
            this.resumeLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.resumeLabel.Location = new System.Drawing.Point(64, 54);
            this.resumeLabel.Name = "resumeLabel";
            this.resumeLabel.Size = new System.Drawing.Size(100, 27);
            this.resumeLabel.TabIndex = 0;
            this.resumeLabel.Text = "Resumes";
            this.resumeLabel.Click += new System.EventHandler(this.resumeLabel_Click);
            // 
            // namesList
            // 
            this.namesList.FormattingEnabled = true;
            this.namesList.Location = new System.Drawing.Point(37, 84);
            this.namesList.Name = "namesList";
            this.namesList.Size = new System.Drawing.Size(165, 459);
            this.namesList.TabIndex = 1;
            this.namesList.SelectedIndexChanged += new System.EventHandler(this.namesList_SelectedIndexChanged);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.skillsViewer);
            this.infoBox.Controls.Add(this.skillsLabel);
            this.infoBox.Controls.Add(this.certificationsViewer);
            this.infoBox.Controls.Add(this.certificationsLabel);
            this.infoBox.Controls.Add(this.workExperienceViewer);
            this.infoBox.Controls.Add(this.workExperienceLabel);
            this.infoBox.Controls.Add(this.educationViewer);
            this.infoBox.Controls.Add(this.educationLabel);
            this.infoBox.Controls.Add(this.linkedinViewer);
            this.infoBox.Controls.Add(this.linkedinLabel);
            this.infoBox.Controls.Add(this.professionViewer);
            this.infoBox.Controls.Add(this.professionLabel);
            this.infoBox.Controls.Add(this.yearsExperienceViewer);
            this.infoBox.Controls.Add(this.yearsExperienceLabel);
            this.infoBox.Controls.Add(this.languagesViewer);
            this.infoBox.Controls.Add(this.languagesLabel);
            this.infoBox.Controls.Add(this.locationViewer);
            this.infoBox.Controls.Add(this.locationLabel);
            this.infoBox.Controls.Add(this.birthDateViewer);
            this.infoBox.Controls.Add(this.birthDateLabel);
            this.infoBox.Controls.Add(this.websitesViewer);
            this.infoBox.Controls.Add(this.websitesLabel);
            this.infoBox.Controls.Add(this.phoneNumbersViewer);
            this.infoBox.Controls.Add(this.phoneNumbersLabel);
            this.infoBox.Controls.Add(this.emailsViewer);
            this.infoBox.Controls.Add(this.emailsLabel);
            this.infoBox.Controls.Add(this.nameViewer);
            this.infoBox.Controls.Add(this.nameLabel);
            this.infoBox.Font = new System.Drawing.Font("Tahoma", 16F);
            this.infoBox.Location = new System.Drawing.Point(256, 54);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(905, 489);
            this.infoBox.TabIndex = 2;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            this.infoBox.Enter += new System.EventHandler(this.infoBox_Enter);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nameLabel.Location = new System.Drawing.Point(6, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // nameViewer
            // 
            this.nameViewer.HideSelection = false;
            this.nameViewer.Location = new System.Drawing.Point(10, 52);
            this.nameViewer.Name = "nameViewer";
            this.nameViewer.Size = new System.Drawing.Size(207, 29);
            this.nameViewer.TabIndex = 1;
            this.nameViewer.UseCompatibleStateImageBehavior = false;
            this.nameViewer.SelectedIndexChanged += new System.EventHandler(this.nameViewer_SelectedIndexChanged);
            // 
            // emailsLabel
            // 
            this.emailsLabel.AutoSize = true;
            this.emailsLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.emailsLabel.Location = new System.Drawing.Point(6, 88);
            this.emailsLabel.Name = "emailsLabel";
            this.emailsLabel.Size = new System.Drawing.Size(55, 19);
            this.emailsLabel.TabIndex = 2;
            this.emailsLabel.Text = "Emails";
            this.emailsLabel.Click += new System.EventHandler(this.emailsLabel_Click);
            // 
            // emailsViewer
            // 
            this.emailsViewer.HideSelection = false;
            this.emailsViewer.Location = new System.Drawing.Point(10, 110);
            this.emailsViewer.Name = "emailsViewer";
            this.emailsViewer.Size = new System.Drawing.Size(203, 97);
            this.emailsViewer.TabIndex = 3;
            this.emailsViewer.UseCompatibleStateImageBehavior = false;
            this.emailsViewer.SelectedIndexChanged += new System.EventHandler(this.emailsViewer_SelectedIndexChanged);
            // 
            // phoneNumbersLabel
            // 
            this.phoneNumbersLabel.AutoSize = true;
            this.phoneNumbersLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.phoneNumbersLabel.Location = new System.Drawing.Point(6, 215);
            this.phoneNumbersLabel.Name = "phoneNumbersLabel";
            this.phoneNumbersLabel.Size = new System.Drawing.Size(122, 19);
            this.phoneNumbersLabel.TabIndex = 4;
            this.phoneNumbersLabel.Text = "Phone Numbers";
            this.phoneNumbersLabel.Click += new System.EventHandler(this.phoneNumbersLabel_Click);
            // 
            // phoneNumbersViewer
            // 
            this.phoneNumbersViewer.HideSelection = false;
            this.phoneNumbersViewer.Location = new System.Drawing.Point(10, 237);
            this.phoneNumbersViewer.Name = "phoneNumbersViewer";
            this.phoneNumbersViewer.Size = new System.Drawing.Size(199, 97);
            this.phoneNumbersViewer.TabIndex = 5;
            this.phoneNumbersViewer.UseCompatibleStateImageBehavior = false;
            this.phoneNumbersViewer.SelectedIndexChanged += new System.EventHandler(this.phoneNumbersViewer_SelectedIndexChanged);
            // 
            // websitesLabel
            // 
            this.websitesLabel.AutoSize = true;
            this.websitesLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.websitesLabel.Location = new System.Drawing.Point(6, 342);
            this.websitesLabel.Name = "websitesLabel";
            this.websitesLabel.Size = new System.Drawing.Size(71, 19);
            this.websitesLabel.TabIndex = 6;
            this.websitesLabel.Text = "Websites";
            this.websitesLabel.Click += new System.EventHandler(this.websitesLabel_Click);
            // 
            // websitesViewer
            // 
            this.websitesViewer.HideSelection = false;
            this.websitesViewer.Location = new System.Drawing.Point(10, 364);
            this.websitesViewer.Name = "websitesViewer";
            this.websitesViewer.Size = new System.Drawing.Size(195, 119);
            this.websitesViewer.TabIndex = 7;
            this.websitesViewer.UseCompatibleStateImageBehavior = false;
            this.websitesViewer.SelectedIndexChanged += new System.EventHandler(this.websitesViewer_SelectedIndexChanged);
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.birthDateLabel.Location = new System.Drawing.Point(219, 30);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(79, 19);
            this.birthDateLabel.TabIndex = 8;
            this.birthDateLabel.Text = "Birth Date";
            this.birthDateLabel.Click += new System.EventHandler(this.birthDateLabel_Click);
            // 
            // birthDateViewer
            // 
            this.birthDateViewer.HideSelection = false;
            this.birthDateViewer.Location = new System.Drawing.Point(223, 52);
            this.birthDateViewer.Name = "birthDateViewer";
            this.birthDateViewer.Size = new System.Drawing.Size(182, 29);
            this.birthDateViewer.TabIndex = 9;
            this.birthDateViewer.UseCompatibleStateImageBehavior = false;
            this.birthDateViewer.SelectedIndexChanged += new System.EventHandler(this.birthDateViewer_SelectedIndexChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.locationLabel.Location = new System.Drawing.Point(219, 84);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(68, 19);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location";
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // locationViewer
            // 
            this.locationViewer.HideSelection = false;
            this.locationViewer.Location = new System.Drawing.Point(223, 106);
            this.locationViewer.Name = "locationViewer";
            this.locationViewer.Size = new System.Drawing.Size(182, 31);
            this.locationViewer.TabIndex = 11;
            this.locationViewer.UseCompatibleStateImageBehavior = false;
            this.locationViewer.SelectedIndexChanged += new System.EventHandler(this.locationViewer_SelectedIndexChanged);
            // 
            // languagesLabel
            // 
            this.languagesLabel.AutoSize = true;
            this.languagesLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.languagesLabel.Location = new System.Drawing.Point(219, 140);
            this.languagesLabel.Name = "languagesLabel";
            this.languagesLabel.Size = new System.Drawing.Size(84, 19);
            this.languagesLabel.TabIndex = 12;
            this.languagesLabel.Text = "Languages";
            this.languagesLabel.Click += new System.EventHandler(this.languagesLabel_Click);
            // 
            // languagesViewer
            // 
            this.languagesViewer.HideSelection = false;
            this.languagesViewer.Location = new System.Drawing.Point(223, 163);
            this.languagesViewer.Name = "languagesViewer";
            this.languagesViewer.Size = new System.Drawing.Size(182, 71);
            this.languagesViewer.TabIndex = 13;
            this.languagesViewer.UseCompatibleStateImageBehavior = false;
            this.languagesViewer.SelectedIndexChanged += new System.EventHandler(this.languagesViewer_SelectedIndexChanged);
            // 
            // yearsExperienceLabel
            // 
            this.yearsExperienceLabel.AutoSize = true;
            this.yearsExperienceLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yearsExperienceLabel.Location = new System.Drawing.Point(464, 433);
            this.yearsExperienceLabel.Name = "yearsExperienceLabel";
            this.yearsExperienceLabel.Size = new System.Drawing.Size(148, 19);
            this.yearsExperienceLabel.TabIndex = 14;
            this.yearsExperienceLabel.Text = "Years of Experience";
            this.yearsExperienceLabel.Click += new System.EventHandler(this.yearsExperienceLabel_Click);
            // 
            // yearsExperienceViewer
            // 
            this.yearsExperienceViewer.HideSelection = false;
            this.yearsExperienceViewer.Location = new System.Drawing.Point(464, 455);
            this.yearsExperienceViewer.Name = "yearsExperienceViewer";
            this.yearsExperienceViewer.Size = new System.Drawing.Size(244, 28);
            this.yearsExperienceViewer.TabIndex = 15;
            this.yearsExperienceViewer.UseCompatibleStateImageBehavior = false;
            this.yearsExperienceViewer.SelectedIndexChanged += new System.EventHandler(this.yearsExperienceViewer_SelectedIndexChanged);
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.professionLabel.Location = new System.Drawing.Point(464, 377);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(82, 19);
            this.professionLabel.TabIndex = 16;
            this.professionLabel.Text = "Profession";
            this.professionLabel.Click += new System.EventHandler(this.professionLabel_Click);
            // 
            // professionViewer
            // 
            this.professionViewer.HideSelection = false;
            this.professionViewer.Location = new System.Drawing.Point(464, 399);
            this.professionViewer.Name = "professionViewer";
            this.professionViewer.Size = new System.Drawing.Size(244, 31);
            this.professionViewer.TabIndex = 17;
            this.professionViewer.UseCompatibleStateImageBehavior = false;
            this.professionViewer.SelectedIndexChanged += new System.EventHandler(this.professionViewer_SelectedIndexChanged);
            // 
            // linkedinLabel
            // 
            this.linkedinLabel.AutoSize = true;
            this.linkedinLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.linkedinLabel.Location = new System.Drawing.Point(407, 29);
            this.linkedinLabel.Name = "linkedinLabel";
            this.linkedinLabel.Size = new System.Drawing.Size(68, 19);
            this.linkedinLabel.TabIndex = 18;
            this.linkedinLabel.Text = "Linkedin";
            this.linkedinLabel.Click += new System.EventHandler(this.linkedinLabel_Click);
            // 
            // linkedinViewer
            // 
            this.linkedinViewer.HideSelection = false;
            this.linkedinViewer.Location = new System.Drawing.Point(411, 52);
            this.linkedinViewer.Name = "linkedinViewer";
            this.linkedinViewer.Size = new System.Drawing.Size(468, 29);
            this.linkedinViewer.TabIndex = 19;
            this.linkedinViewer.UseCompatibleStateImageBehavior = false;
            this.linkedinViewer.SelectedIndexChanged += new System.EventHandler(this.linkedinViewer_SelectedIndexChanged);
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.educationLabel.Location = new System.Drawing.Point(219, 237);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(78, 19);
            this.educationLabel.TabIndex = 20;
            this.educationLabel.Text = "Education";
            this.educationLabel.Click += new System.EventHandler(this.educationLabel_Click);
            // 
            // educationViewer
            // 
            this.educationViewer.HideSelection = false;
            this.educationViewer.Location = new System.Drawing.Point(223, 260);
            this.educationViewer.Name = "educationViewer";
            this.educationViewer.Size = new System.Drawing.Size(235, 223);
            this.educationViewer.TabIndex = 21;
            this.educationViewer.UseCompatibleStateImageBehavior = false;
            this.educationViewer.SelectedIndexChanged += new System.EventHandler(this.educationViewer_SelectedIndexChanged);
            // 
            // workExperienceLabel
            // 
            this.workExperienceLabel.AutoSize = true;
            this.workExperienceLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.workExperienceLabel.Location = new System.Drawing.Point(460, 215);
            this.workExperienceLabel.Name = "workExperienceLabel";
            this.workExperienceLabel.Size = new System.Drawing.Size(127, 19);
            this.workExperienceLabel.TabIndex = 22;
            this.workExperienceLabel.Text = "Work Experience";
            this.workExperienceLabel.Click += new System.EventHandler(this.workExperienceLabel_Click);
            // 
            // workExperienceViewer
            // 
            this.workExperienceViewer.HideSelection = false;
            this.workExperienceViewer.Location = new System.Drawing.Point(464, 237);
            this.workExperienceViewer.Name = "workExperienceViewer";
            this.workExperienceViewer.Size = new System.Drawing.Size(244, 137);
            this.workExperienceViewer.TabIndex = 23;
            this.workExperienceViewer.UseCompatibleStateImageBehavior = false;
            this.workExperienceViewer.SelectedIndexChanged += new System.EventHandler(this.workExperienceViewer_SelectedIndexChanged);
            // 
            // certificationsLabel
            // 
            this.certificationsLabel.AutoSize = true;
            this.certificationsLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.certificationsLabel.Location = new System.Drawing.Point(407, 84);
            this.certificationsLabel.Name = "certificationsLabel";
            this.certificationsLabel.Size = new System.Drawing.Size(100, 19);
            this.certificationsLabel.TabIndex = 24;
            this.certificationsLabel.Text = "Certifications";
            this.certificationsLabel.Click += new System.EventHandler(this.certificationsLabel_Click);
            // 
            // certificationsViewer
            // 
            this.certificationsViewer.HideSelection = false;
            this.certificationsViewer.Location = new System.Drawing.Point(411, 105);
            this.certificationsViewer.Name = "certificationsViewer";
            this.certificationsViewer.Size = new System.Drawing.Size(297, 107);
            this.certificationsViewer.TabIndex = 25;
            this.certificationsViewer.UseCompatibleStateImageBehavior = false;
            this.certificationsViewer.SelectedIndexChanged += new System.EventHandler(this.certificationsViewer_SelectedIndexChanged);
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.skillsLabel.Location = new System.Drawing.Point(729, 88);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(45, 19);
            this.skillsLabel.TabIndex = 26;
            this.skillsLabel.Text = "Skills";
            this.skillsLabel.Click += new System.EventHandler(this.skillsLabel_Click);
            // 
            // skillsViewer
            // 
            this.skillsViewer.HideSelection = false;
            this.skillsViewer.Location = new System.Drawing.Point(714, 110);
            this.skillsViewer.Name = "skillsViewer";
            this.skillsViewer.Size = new System.Drawing.Size(165, 373);
            this.skillsViewer.TabIndex = 27;
            this.skillsViewer.UseCompatibleStateImageBehavior = false;
            this.skillsViewer.SelectedIndexChanged += new System.EventHandler(this.skillsViewer_SelectedIndexChanged);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 556);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.namesList);
            this.Controls.Add(this.resumeLabel);
            this.Name = "Gui";
            this.Text = "Resume App";
            this.Load += new System.EventHandler(this.Gui_Load);
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resumeLabel;
        private System.Windows.Forms.ListBox namesList;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.ListView nameViewer;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.ListView linkedinViewer;
        private System.Windows.Forms.Label linkedinLabel;
        private System.Windows.Forms.ListView professionViewer;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.ListView yearsExperienceViewer;
        private System.Windows.Forms.Label yearsExperienceLabel;
        private System.Windows.Forms.ListView languagesViewer;
        private System.Windows.Forms.Label languagesLabel;
        private System.Windows.Forms.ListView locationViewer;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListView birthDateViewer;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.ListView websitesViewer;
        private System.Windows.Forms.Label websitesLabel;
        private System.Windows.Forms.ListView phoneNumbersViewer;
        private System.Windows.Forms.Label phoneNumbersLabel;
        private System.Windows.Forms.ListView emailsViewer;
        private System.Windows.Forms.Label emailsLabel;
        private System.Windows.Forms.ListView skillsViewer;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.ListView certificationsViewer;
        private System.Windows.Forms.Label certificationsLabel;
        private System.Windows.Forms.ListView workExperienceViewer;
        private System.Windows.Forms.Label workExperienceLabel;
        private System.Windows.Forms.ListView educationViewer;
    }
}

