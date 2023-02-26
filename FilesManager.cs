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

                JsonReader reader = new JsonReader(array);

                String name = reader.readName();
                String dateOfBirth = reader.readDateOfBirth();
                int totalYearsExperience = reader.readTotalYearsExperience();
                String profession = reader.readProfession();
                String linkedin = reader.readLinkedin();
                String[] emails = reader.readEmails();
                dynamic[][] educations = reader.readEducations();
                dynamic[][] workExperiences = reader.readWorkExperiences();
                String[][] skills = reader.readSkills();
                String[] certifications = reader.readCertifications();
                String[] phoneNumbers = reader.readPhoneNumbers();
                String[] websites = reader.readWebsites();
                String location = reader.readLocation();
                String[] languages = reader.readLanguages();

                candidateManager.setName(name);
                candidateManager.setEmails(emails);
                candidateManager.setEducations(educations);
                candidateManager.setWorkExperiences(workExperiences);
                candidateManager.setSkills(skills);
                candidateManager.setCertifications(certifications);
                candidateManager.setPhoneNumbers(phoneNumbers);
                candidateManager.setWebsites(websites);
                candidateManager.setDateOfBirth(dateOfBirth);
                candidateManager.setLocation(location);
                candidateManager.setLanguages(languages);
                candidateManager.setTotalYearsExperience(totalYearsExperience);
                candidateManager.setProfession(profession);
                candidateManager.setLinkedin(linkedin);

                candidateManager.createCandidate();
            }
            return candidateManager;
        }
    }
}
