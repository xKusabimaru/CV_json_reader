using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonSkillsReader
    {
        private dynamic array;

        public JsonSkillsReader(dynamic array)
        {
            this.array = array;
        }
        public String[] readSkills()
        {
            List<String> skillsList = new List<String>();
            array =  array.Value.Data.Skills;

            foreach(var skill in array)
            {
                skillsList.Add((String)skill.Name);
            }
            
            return skillsList.ToArray();
        }
    }
}
