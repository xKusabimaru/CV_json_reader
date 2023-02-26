using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class WorkExperience
    {
        private String jobTitle;
        private String organization;
        private Location location;
        private String jobDescription;
        private Date date;

        public WorkExperience(String jobTitle, String organization, Location location, String jobDescription, Date date)
        {
            this.jobTitle = jobTitle;
            this.organization = organization;
            this.location = location;
            this.jobDescription = jobDescription;
            this.date = date;
        }

        public String getJobTitle()
        {
            return jobTitle;
        }
        public String getOrganization()
        {
            return organization;
        }
        public String getLocation()
        {
            return location.getLocation();
        }
        public String getJobDescription()
        {
            return jobDescription;
        }
        public String getStartDate()
        {
            return date.getStartDate();
        }
        public String getEndDate()
        {
            return date.getEndDate();
        }
        public bool getIsCurrent()
        {
            return date.getIsCurrent();
        }
    }
}
