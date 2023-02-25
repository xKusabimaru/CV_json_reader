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

        public Candidate(Name name, Email[] emails, Education[] educations, Skill[] skills, Certification[] certifications)
        {
            this.name = name;
            this.emails = emails;
            this.educations = educations;
            this.skills = skills;
            this.certifications = certifications;
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

        public String[] getEducations()
        {
            String[] educationsList = new String[educations.Length];
            for (int i = 0; i < educations.Length; i++)
            {
                educationsList[i] = educations[i].getEducation();
            }
            return educationsList;
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
    }
}
