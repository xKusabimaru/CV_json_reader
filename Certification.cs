using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Certification
    {
        private String certification;

        public Certification(String certification)
        {
            this.certification = certification;
        }

        public String getCertification()
        {
            return certification;
        }
    }
}
