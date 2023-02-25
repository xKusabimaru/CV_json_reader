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
        private String[] educations;
        private String[] skills;
        private String[] certifications;
        private List<Candidate> candidates = new List<Candidate>();

        public CandidateManager()
        {

        }

        public CandidateManager(String name, String[] emails, String[] educations, String[] skills, String[] certifications)
        {
            this.name = name;
            this.emails = emails;
            this.educations = educations;
            this.skills = skills;
            this.certifications = certifications;
        }

        public void createCandidate()
        {
            Name nameObj = new Name(name);
            Email[] emailsObj = createEmails();
            Education[] educationsObj = createEducations();
            Skill[] skillsObj = createSkills();
            Certification[] certificationsObj = createCertifications();

            Candidate candidate = new Candidate(nameObj, emailsObj, educationsObj, skillsObj, certificationsObj);
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
            foreach (String education in educations)
            {
                Education obj = new Education(education);
                educationsObj.Add(obj);
            }

            return educationsObj.ToArray();
        }
        private Skill[] createSkills()
        {
            List<Skill> skillsObj = new List<Skill>();
            foreach (String skill in skills)
            {
                Skill obj = new Skill(skill);
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
        public void setName(String name)
        {
            this.name = name;
        }
        public void setEmails(String[] emails)
        {
            this.emails = emails;
        }
        public void setEducations(String[] educations)
        {
            this.educations = educations;
        }
        public void setSkills(String[] skills)
        {
            this.skills = skills;
        }
        public void setCertifications(String[] certifications)
        {
            this.certifications = certifications;
        }
    }
}
