using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Experience
    {
        private int totalYearsExperience;
        public Experience(int totalYearsExperience)
        {
            this.totalYearsExperience = totalYearsExperience;
        }
        public int getExperience()
        {
            return totalYearsExperience;
        }
    }
}
