using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class CandidateManager
    {
        private List<Candidate> candidates = new List<Candidate>();

        public CandidateManager()
        {

        }

        public void createCandidate(String name, String[] emails, dynamic[][] educations, dynamic[][] workExperiences, String[][] skills, String[] certifications, String[] phoneNumbers,
                    String[] websites, String dateOfBirth, String location, String[] languages, int totalYearsExperience, String profession, String linkedin)
        {
            Name nameObj = new Name(name);
            Email[] emailsObj = createEmails(emails);
            Education[] educationsObj = createEducations(educations);
            WorkExperience[] workExperiencesObj = createWorkExperiences(workExperiences);
            Skill[] skillsObj = createSkills(skills);
            Certification[] certificationsObj = createCertifications(certifications);
            PhoneNumber[] phoneNumbersObj = createPhoneNumbers(phoneNumbers);
            Website[] websitesObj = createWebsites(websites);
            BirthDate dateOfBirthObj = new BirthDate(dateOfBirth);
            Location locationObj = new Location(location);
            Language[] languagesObj = createLanguages(languages);
            Experience totalYearsExperienceObj = new Experience(totalYearsExperience);
            Profession professionObj = new Profession(profession);
            Linkedin linkedinObj = new Linkedin(linkedin);

        Candidate candidate = new Candidate(nameObj, emailsObj, educationsObj, workExperiencesObj, skillsObj, certificationsObj, phoneNumbersObj,
            websitesObj, dateOfBirthObj, locationObj, languagesObj, totalYearsExperienceObj, professionObj, linkedinObj);

            candidates.Add(candidate);
        }
        
        public Candidate[] getAllCandidates()
        {
            return candidates.ToArray();
        }
        private Email[] createEmails(String[] emails)
        {
            List<Email> emailsObj = new List<Email>();
            foreach (String email in emails)
            {
                Email obj = new Email(email);
                emailsObj.Add(obj);
            }

            return emailsObj.ToArray();
        }
        private Education[] createEducations(dynamic[][] educations)
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
        private WorkExperience[] createWorkExperiences(dynamic[][] workExperience)
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
        private Skill[] createSkills(String[][] skills)
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
        private Certification[] createCertifications(String[] certifications)
        {
            List<Certification> certificationsObj = new List<Certification>();
            foreach (String certification in certifications)
            {
                Certification obj = new Certification(certification);
                certificationsObj.Add(obj);
            }

            return certificationsObj.ToArray();
        }
        private PhoneNumber[] createPhoneNumbers(String[] phoneNumbers)
        {
            List<PhoneNumber> phoneNumbersObj = new List<PhoneNumber>();
            foreach (String phoneNumber in phoneNumbers)
            {
                PhoneNumber obj = new PhoneNumber(phoneNumber);
                phoneNumbersObj.Add(obj);
            }

            return phoneNumbersObj.ToArray();
        }
        private Website[] createWebsites(String[] websites)
        {
            List<Website> websitesObj = new List<Website>();
            foreach (String website in websites)
            {
                Website obj = new Website(website);
                websitesObj.Add(obj);
            }

            return websitesObj.ToArray();
        }
        private Language[] createLanguages(String[] languages)
        {
            List<Language> languagesObj = new List<Language>();
            foreach (String language in languages)
            {
                Language obj = new Language(language);
                languagesObj.Add(obj);
            }

            return languagesObj.ToArray();
        }
    }
}
