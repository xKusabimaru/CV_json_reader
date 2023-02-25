using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonEducationsReader
    {
        private dynamic array;

        public JsonEducationsReader(dynamic array)
        {
            this.array = array;
        }
        public String[] readEducations()
        {
            List<String> educationsList = new List<String>();
            array = array.Value.Data.Education;

            foreach (var education in array)
            {
                educationsList.Add((String)education.Accreditation.Education);
            }

            return educationsList.ToArray();
        }
    }
}
