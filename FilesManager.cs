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
            JsonFilesFinder jff = new JsonFilesFinder("../../jsons/");
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

                candidateManager.createCandidate(name, emails, educations, workExperiences, skills, certifications, phoneNumbers,
                    websites, dateOfBirth, location, languages, totalYearsExperience, profession, linkedin);
            }
            return candidateManager;
        }
    }
}
