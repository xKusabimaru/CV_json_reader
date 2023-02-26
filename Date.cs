using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Date
    {
        private String startDate;
        private String endDate;
        private bool isCurrent;

        public Date(String startDate, String endDate, bool isCurrent)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.isCurrent = isCurrent;
        }

        public String getStartDate()
        {
            return startDate; 
        }
        public String getEndDate()
        {
            return endDate;
        }
        public bool getIsCurrent()
        {
            return isCurrent;
        }
    }
}
