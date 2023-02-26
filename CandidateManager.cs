using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class CandidateManager
    {
        private String name;
        private String[] emails;
        private dynamic[][] educations;
        private dynamic[][] workExperience;
        private String[][] skills;
        private String[] certifications;
        private String[] phoneNumbers;
        private String[] websites;
        private String dateOfBirth;
        private String location;
        private String[] languages;
        private int totalYearsExperience;
        private String profession;
        private String linkedin;
        private List<Candidate> candidates = new List<Candidate>();

        public CandidateManager()
        {

        }

        public void createCandidate()
        {
            String nameObj = name;
            Email[] emailsObj = createEmails();
            Education[] educationsObj = createEducations();
            WorkExperience[] workExperiencesObj = createWorkExperiences();
            Skill[] skillsObj = createSkills();
            Certification[] certificationsObj = createCertifications();
            PhoneNumber[] phoneNumbersObj = createPhoneNumbers();
            Website[] websitesObj = createWebsites();
            String dateOfBirthObj = dateOfBirth;
            Location locationObj = createLocation();
            Language[] languagesObj = createLanguages();
            int totalYearsExperienceObj = totalYearsExperience;
            String professionObj = profession;
            String linkedinObj = linkedin;

        Candidate candidate = new Candidate(nameObj, emailsObj, educationsObj, workExperiencesObj, skillsObj, certificationsObj, phoneNumbersObj,
            websitesObj, dateOfBirthObj, locationObj, languagesObj, totalYearsExperienceObj, professionObj, linkedinObj);

            candidates.Add(candidate);
        }
        
        public Candidate[] GetAllCandidates()
        {
            return candidates.ToArray();
        }
        private Email[] createEmails()
        {
            List<Email> emailsObj = new List<Email>();
            foreach (String email in emails)
            {
                Email obj = new Email(email);
                emailsObj.Add(obj);
            }

            return emailsObj.ToArray();
        }
        private Education[] createEducations()
        {
            List<Education> educationsObj = new List<Education>();

            for(int i = 0; i < educations.GetLength(0); i++)
            {
                Date date = new Date(educations[i][4], educations[i][5], educations[i][6]);
                Location location = new Location(educations[i][3]);

                Education obj = new Education
                    (
                    educations[i][0], educations[i][1], educations[i][2], location, date
                    );

                educationsObj.Add(obj);
            }

            return educationsObj.ToArray();
        }
        private WorkExperience[] createWorkExperiences()
        {
            List<WorkExperience> workExperiencesObj = new List<WorkExperience>();

            for (int i = 0; i < workExperience.GetLength(0); i++)
            {
                Date date = new Date(workExperience[i][4], workExperience[i][5], workExperience[i][6]);
                Location location = new Location(workExperience[i][2]);

                WorkExperience obj = new WorkExperience
                    (
                    workExperience[i][0], workExperience[i][1], location, workExperience[i][3], date
                    );

                workExperiencesObj.Add(obj);
            }

            return workExperiencesObj.ToArray();
        }
        private Skill[] createSkills()
        {
            List<Skill> skillsObj = new List<Skill>();

            for (int i = 0; i < skills.GetLength(0); i++)
            {
                Skill obj = new Skill
                    (
                    skills[i][0], skills[i][1]
                    );

                skillsObj.Add(obj);
            }

            return skillsObj.ToArray();
        }
        private Certification[] createCertifications()
        {
            List<Certification> certificationsObj = new List<Certification>();
            foreach (String certification in certifications)
            {
                Certification obj = new Certification(certification);
                certificationsObj.Add(obj);
            }

            return certificationsObj.ToArray();
        }
        private PhoneNumber[] createPhoneNumbers()
        {
            List<PhoneNumber> phoneNumbersObj = new List<PhoneNumber>();
            foreach (String phoneNumber in phoneNumbers)
            {
                PhoneNumber obj = new PhoneNumber(phoneNumber);
                phoneNumbersObj.Add(obj);
            }

            return phoneNumbersObj.ToArray();
        }
        private Website[] createWebsites()
        {
            List<Website> websitesObj = new List<Website>();
            foreach (String website in websites)
            {
                Website obj = new Website(website);
                websitesObj.Add(obj);
            }

            return websitesObj.ToArray();
        }
        private Location createLocation()
        {
            Location locationObj = new Location(location);
            return locationObj;
        }
        private Language[] createLanguages()
        {
            List<Language> languagesObj = new List<Language>();
            foreach (String language in languages)
            {
                Language obj = new Language(language);
                languagesObj.Add(obj);
            }

            return languagesObj.ToArray();
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setEmails(String[] emails)
        {
            this.emails = emails;
        }
        public void setEducations(dynamic[][] educations)
        {
            this.educations = educations;
        }
        public void setWorkExperiences(dynamic[][] workExperience)
        {
            this.workExperience = workExperience;
        }
        public void setSkills(String[][] skills)
        {
            this.skills = skills;
        }
        public void setCertifications(String[] certifications)
        {
            this.certifications = certifications;
        }
        public void setPhoneNumbers(String[] phoneNumbers)
        {
            this.phoneNumbers = phoneNumbers;
        }
        public void setWebsites(String[] websites)
        {
            this.websites = websites;
        }
        public void setDateOfBirth(String dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void setLocation(String location)
        {
            this.location = location;
        }
        public void setLanguages(String[] languages)
        {
            this.languages = languages;
        }
        public void setTotalYearsExperience(int totalYearsExperience)
        {
            this.totalYearsExperience = totalYearsExperience;
        }
        public void setProfession(String profession)
        {
            this.profession = profession;
        }
        public void setLinkedin(String linkedin)
        {
            this.linkedin = linkedin;
        }
    }
}
