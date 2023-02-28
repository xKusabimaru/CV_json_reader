using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Candidate
    {
        private Name name;
        private Email[] emails;
        private Education[] educations;
        private Skill[] skills;
        private Certification[] certifications;
        private PhoneNumber[] phoneNumbers;
        private Website[] websites;
        private BirthDate dateOfBirth;
        private Location location;
        private Language[] languages;
        private Experience totalYearsExperience;
        private Profession profession;
        private Linkedin linkedin;
        private WorkExperience[] workExperiences;

        public Candidate(Name name, Email[] emails, Education[] educations, WorkExperience[] workExperiences, Skill[] skills, Certification[] certifications, PhoneNumber[] phoneNumbers,
            Website[] websites, BirthDate dateOfBirth, Location location, Language[] languages, Experience totalYearsExperience, Profession profession, Linkedin linkedin)
        {
            this.name = name;
            this.emails = emails;
            this.educations = educations;
            this.skills = skills;
            this.certifications = certifications;
            this.phoneNumbers = phoneNumbers;
            this.websites = websites;
            this.dateOfBirth = dateOfBirth;
            this.location = location;
            this.languages = languages;
            this.totalYearsExperience = totalYearsExperience;
            this.profession = profession;
            this.linkedin = linkedin;
            this.workExperiences = workExperiences;
        }
        public String getName()
        {
            return name.getName();
        }

        public String[] getEmails()
        {
            String[] emailsList = new String[emails.Length];
            for(int i = 0; i< emails.Length; i++)
            {
                emailsList[i] = emails[i].getEmail();
            }
            return emailsList;
        }

        public String[] getEducationsOrganization()
        {
            String[] organizationsList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                organizationsList[i] = educations[i].getOrganization();
            }
            return organizationsList;
        }
        public String[] getEducationsEducation()
        {
            String[] educationsList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                educationsList[i] = educations[i].getEducation();
            }
            return educationsList;
        }
        public String[] getEducationsGrade()
        {
            String[] gradesList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                gradesList[i] = educations[i].getGrade();
            }
            return gradesList;
        }
        public String[] getEducationsLocation()
        {
            String[] locationsList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                locationsList[i] = educations[i].getLocation();
            }
            return locationsList;
        }
        public String[] getEducationsDate()
        {
            String[] datesList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                datesList[i] = ($"Start Date:{educations[i].getStartDate()}, End Date:{educations[i].getEndDate()}, isCurrent:{educations[i].getIsCurrent()}");
            }
            return datesList;
        }

        public String[] getWorkExperiencesJobTitle()
        {
            String[] jobTitlesList = new String[workExperiences.Length];
            for (int i = 0; i < workExperiences.Length; i++)
            {
                jobTitlesList[i] = workExperiences[i].getJobTitle();
            }
            return jobTitlesList;
        }
        public String[] getWorkExperiencesOrganization()
        {
            String[] organizationsList = new String[workExperiences.Length];
            for (int i = 0; i < workExperiences.Length; i++)
            {
                organizationsList[i] = workExperiences[i].getOrganization();
            }
            return organizationsList;
        }
        public String[] getWorkExperiencesLocation()
        {
            String[] locationsList = new String[workExperiences.Length];
            for (int i = 0; i < workExperiences.Length; i++)
            {
                locationsList[i] = workExperiences[i].getLocation();
            }
            return locationsList;
        }
        public String[] getWorkExperiencesJobDescription()
        {
            String[] jobDescriptionsList = new String[workExperiences.Length];
            for (int i = 0; i < workExperiences.Length; i++)
            {
                jobDescriptionsList[i] = workExperiences[i].getJobDescription();
            }
            return jobDescriptionsList;
        }
        public String[] getWorkExperiencesDate()
        {
            String[] datesList = new String[workExperiences.Length];
            for (int i = 0; i < workExperiences.Length; i++)
            {
                datesList[i] = ($"Start Date:{workExperiences[i].getStartDate()}, End Date:{workExperiences[i].getEndDate()}, isCurrent:{workExperiences[i].getIsCurrent()}");
            }
            return datesList;
        }

        public String[] getSkills()
        {
            String[] skillsList = new String[skills.Length];
            for (int i = 0; i < skills.Length; i++)
            {
                skillsList[i] = skills[i].getSkill();
            }
            return skillsList;
        }

        public String[] getCertifications()
        {
            String[] certificationsList = new String[certifications.Length];
            for (int i = 0; i < certifications.Length; i++)
            {
                certificationsList[i] = certifications[i].getCertification();
            }
            return certificationsList;
        }
        public String[] getPhoneNumbers()
        {
            String[] phoneNumbersList = new String[phoneNumbers.Length];
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                phoneNumbersList[i] = phoneNumbers[i].getPhoneNumber();
            }
            return phoneNumbersList;
        }
        public String[] getWebsites()
        {
            String[] websitesList = new String[websites.Length];
            for (int i = 0; i < websites.Length; i++)
            {
                websitesList[i] = websites[i].getWebsite();
            }
            return websitesList;
        }
        public String getDateOfBirth()
        {
            return dateOfBirth.getBirthDate();
        }
        public String getLocation()
        {
            return location.getLocation();
        }
        public String[] getLanguages()
        {
            String[] languagesList = new String[languages.Length];
            for (int i = 0; i < languages.Length; i++)
            {
                languagesList[i] = languages[i].getLanguage();
            }
            return languagesList;
        }
        public int getTotalYearsExperience()
        {
            return totalYearsExperience.getExperience();
        }
        public String getProfession()
        {
            return profession.getProfession();
        }
        public String getLinkedin()
        {
            return linkedin.getLinkedin();
        }
    }
}
