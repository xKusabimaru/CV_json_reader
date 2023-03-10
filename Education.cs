using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Education
    {
        private String organization;
        private String education;
        private String grade;
        private Location location;
        private Date date;

        public Education(String organization, String education, String grade, Location location, Date date)
        {
            this.organization = organization;
            this.education = education;
            this.grade = grade;
            this.location = location;
            this.date = date;
        }

        public String getOrganization()
        {
            return organization;
        }
        public String getEducation()
        {
            return education;
        }
        public String getGrade()
        {
            return grade;
        }
        public String getLocation()
        {
            return location.getLocation();
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
