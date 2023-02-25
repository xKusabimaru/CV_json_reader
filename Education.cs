using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Education
    {
        private String education;

        public Education(String education)
        {
            this.education = education;
        }

        public String getEducation()
        {
            return education;
        }
    }
}
