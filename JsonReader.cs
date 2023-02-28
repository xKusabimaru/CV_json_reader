using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonReader
    {
        private dynamic array;

        public JsonReader(dynamic array)
        {
            this.array = array;
        }
        public String readName()
        {
            return array.Value.Data.Name.Raw;
        }
        public String readDateOfBirth()
        {
            if (array.Value.Data.DateOfBirth != null)
            {
                return (String)array.Value.Data.DateOfBirth;
            }
            else
            {
                return "Not Provided";
            }
        }
        public int readTotalYearsExperience()
        {
            return (int)array.Value.Data.TotalYearsExperience;
        }
        public String readProfession()
        {
            return (String)array.Value.Data.Profession;
        }
        public String readLinkedin()
        {
            return (String)array.Value.Data.Linkedin;
        }
        public String[] readCertifications()
        {
            List<String> certificationsList = new List<String>();

            foreach (var certification in array.Value.Data.Certifications)
            {
                certificationsList.Add((String)certification);
            }

            return certificationsList.ToArray();
        }
        public dynamic[][] readEducations()
        {
            List<dynamic[]> educationsList = new List<dynamic[]>();

            foreach (var education in array.Value.Data.Education)
            {
                dynamic[] educationArray = new dynamic[7];
                educationArray[0] = (String)education.Organization;
                educationArray[1] = (String)education.Accreditation.Education;
                educationArray[2] = (String)education.Grade.Value;
                if (education.Location != null)
                {
                    educationArray[3] = (String)education.Location.Formatted;
                }
                else
                {
                    educationArray[3] = "Not Provided";
                }
                if (education.Dates != null)
                {
                    educationArray[4] = (String)education.Dates.StartDate;
                    educationArray[5] = (String)education.Dates.CompletionDate;
                    educationArray[6] = (bool)education.Dates.IsCurrent;
                }
                else
                {
                    educationArray[4] = "Not Provided";
                    educationArray[5] = "Not Provided";
                    educationArray[6] = false;
                }
                educationsList.Add(educationArray);
            }

            return educationsList.ToArray();
        }
        public dynamic[][] readWorkExperiences()
        {
            List<dynamic[]> workExperiencesList = new List<dynamic[]>();

            foreach (var workExperience in array.Value.Data.WorkExperience)
            {
                dynamic[] workExperienceArray = new dynamic[7];
                workExperienceArray[0] = (String)workExperience.JobTitle;
                workExperienceArray[1] = (String)workExperience.Organization;
                if (workExperience.Location != null)
                {
                    workExperienceArray[2] = (String)workExperience.Location.Formatted;
                }
                else
                {
                    workExperienceArray[2] = "Not Provided";
                }
                workExperienceArray[3] = (String)workExperience.JobDescription;
                if (workExperience.Dates != null)
                {
                    workExperienceArray[4] = (String)workExperience.Dates.StartDate;
                    workExperienceArray[5] = (String)workExperience.Dates.CompletionDate;
                    workExperienceArray[6] = (bool)workExperience.Dates.IsCurrent;
                }
                else
                {
                    workExperienceArray[4] = "Not Provided";
                    workExperienceArray[5] = "Not Provided";
                    workExperienceArray[6] = false;
                }
                workExperiencesList.Add(workExperienceArray);
            }

            return workExperiencesList.ToArray();
        }
        public String[] readEmails()
        {
            List<String> emailsList = new List<String>();

            foreach (var email in array.Value.Data.Emails)
            {
                emailsList.Add((String)email);
            }

            return emailsList.ToArray();
        }
        public String[] readPhoneNumbers()
        {
            List<String> phoneNumbersList = new List<String>();

            foreach (var phoneNumber in array.Value.Data.PhoneNumbers)
            {
                phoneNumbersList.Add((String)phoneNumber);
            }

            return phoneNumbersList.ToArray();
        }
        public String[][] readSkills()
        {
            List<String[]> skillsList = new List<String[]>();

            foreach (var skill in array.Value.Data.Skills)
            {
                String[] skillArray = new string[2];
                skillArray[0] = (String)skill.Name;
                skillArray[1] = (String)skill.Type;
                skillsList.Add(skillArray);
            }

            return skillsList.ToArray();
        }
        public String[] readWebsites()
        {
            List<String> websitesList = new List<String>();

            foreach (var website in array.Value.Data.Websites)
            {
                websitesList.Add((String)website);
            }

            return websitesList.ToArray();
        }
        public String[] readLanguages()
        {
            List<String> languagesList = new List<String>();

            foreach (var language in array.Value.Data.Languages)
            {
                languagesList.Add((String)language);
            }

            return languagesList.ToArray();
        }
        public String readLocation()
        {
            if (array.Value.Data.Location != null)
            {
                return (String)array.Value.Data.Location.Formatted;
            }
            return "Not Provided";
        }
        
    }
}
