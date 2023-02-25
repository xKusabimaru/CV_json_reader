using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Skill
    {
        private String skill;

        public Skill(String skill)
        {
            this.skill = skill;
        }

        public String getSkill()
        {
            return skill;
        }
    }
}
