using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class Call
    {
        public Call(DateTime dateAndTime, string dialedPhoneNumber, uint duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime { set; get; }
        public string DialedPhoneNumber { set; get; }
        public uint Duration { set; get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.DateAndTime.ToString());
            result.AppendLine(this.Duration.ToString());
            result.AppendLine(this.DialedPhoneNumber);

            return result.ToString();
        }

    }
}
