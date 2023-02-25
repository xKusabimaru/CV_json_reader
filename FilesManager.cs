using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class FilesManager
    {
        private String[] fileNames;

        public FilesManager()
        {
            JsonFilesFinder jff = new JsonFilesFinder();
            this.fileNames = jff.getJsonFiles();
        }

        public CandidateManager manageLoader()
        {
            CandidateManager candidateManager = new CandidateManager();
            foreach (String fileName in fileNames)
            {
                JsonLoader jl = new JsonLoader(fileName);
                dynamic array = jl.loadJson();

                String name = nameManager(array);
                String[] emails = emailsManager(array);
                String[] educations = educationsManager(array);
                String[] skills = skillsManager(array);
                String[] certifications = certificationsManager(array);

                candidateManager.setName(name);
                candidateManager.setEmails(emails);
                candidateManager.setEducations(educations);
                candidateManager.setSkills(skills);
                candidateManager.setCertifications(certifications);

                candidateManager.createCandidate();
            }
            return candidateManager;
        }
        private String nameManager(dynamic array)
        {
            JsonNameReader name = new JsonNameReader(array);
            return name.readName();
        }
        private String[] emailsManager(dynamic array)
        {
            JsonEmailsReader emails = new JsonEmailsReader(array);
            return emails.readEmails();
        }
        private String[] educationsManager(dynamic array)
        {
            JsonEducationsReader educations = new JsonEducationsReader(array);
            return educations.readEducations();
        }
        private String[] skillsManager(dynamic array)
        {
            JsonSkillsReader skills = new JsonSkillsReader(array);
            return skills.readSkills();
        }
        private String[] certificationsManager(dynamic array)
        {
            JsonCertificationsReader certifications = new JsonCertificationsReader(array);
            return certifications.readCertifications();
        }
    }
}
