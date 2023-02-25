using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonFilesFinder
    {
        private String directoryPath;

        public JsonFilesFinder()
        {
            this.directoryPath = "../../jsons/";
        }
        public String[] getJsonFiles()
        {
            string[] fileNames = Directory.GetFiles(directoryPath);
            return fileNames;
        }
    }
}
