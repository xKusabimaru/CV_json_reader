using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonEmailsReader
    {
        private dynamic array;

        public JsonEmailsReader(dynamic array)
        {
            this.array = array;
        }
        public String[] readEmails()
        {
            List<String> emailsList = new List<String>();
            array = array.Value.Data.Emails;

            foreach (var email in array)
            {
                emailsList.Add((String)email);
            }

            return emailsList.ToArray();
        }
    }
}
