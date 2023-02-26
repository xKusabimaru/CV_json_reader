using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Language
    {
        private String language;

        public Language(String language)
        {
            this.language = language;
        }

        public String getLanguage()
        {
            return language;
        }
    }
}
