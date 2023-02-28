using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class BirthDate
    {
        private String birthOfDate;
        public BirthDate(String birthOfDate)
        {
            this.birthOfDate = birthOfDate;
        }
        public String getBirthDate()
        {
            return birthOfDate;
        }
    }
}
