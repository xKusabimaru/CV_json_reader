using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Profession
    {
        private String profession;
        public Profession(String profession)
        {
            this.profession = profession;
        }
        public String getProfession()
        {
            return profession;
        }
    }
}
