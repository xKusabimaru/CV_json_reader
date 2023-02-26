using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_json_reader
{
    class PhoneNumber
    {
        private String phoneNumber;

        public PhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }
    }
}
