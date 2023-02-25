using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonCertificationsReader
    {
        private dynamic array;

        public JsonCertificationsReader(dynamic array)
        {
            this.array = array;
        }
        public String[] readCertifications()
        {
            List<String> certificationsList = new List<String>();
            array = array.Value.Data.Certifications;

            foreach (var certification in array)
            {
                certificationsList.Add((String)certification);
            }

            return certificationsList.ToArray();
        }
    }
}
