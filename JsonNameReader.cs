using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class JsonNameReader
    {
        private dynamic array;

        public JsonNameReader(dynamic array)
        {
            this.array = array;
        }
        public String readName()
        {
            String name = array.Value.Data.Name.Raw;
            return name;
        }
    }
}
