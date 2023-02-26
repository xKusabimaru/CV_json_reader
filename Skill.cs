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
        private String skillType;

        public Skill(String skill, String skillType)
        {
            this.skill = skill;
            this.skillType = skillType;
        }

        public String getSkill()
        {
            return skill;
        }
        public String getSkillType()
        {
            return skillType;
        }
    }
}
