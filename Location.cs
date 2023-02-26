using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class Location
    {
        private String location;

        public Location(String location)
        {
            this.location = location;
        }

        public String getLocation()
        {
            return location;
        }
    }
}
